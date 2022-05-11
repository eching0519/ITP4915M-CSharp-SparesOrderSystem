using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using SLMC_MS.model;

namespace SLMC_MS
{
    public partial class ModifyOrder : Form
    {
        user myUser;
        order myOrder;
        List<orderitem> myOrderItems;

        public ModifyOrder(user myUser, String orderID)
        {
            this.myUser = myUser;
            int myOrderID = Convert.ToInt32(orderID);
            myOrder = Orders.GetOrder(myOrderID);
            myOrderItems = Orders.GetOrderItemList(myOrder);

            // check permission
            if (myOrder.dealerID != myUser.staffID)
            {
                MessageBox.Show("No such permission!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseThisPage();
            }

            InitializeComponent();

        }

        private void ModifyOrder_Load(object sender, EventArgs e) 
        {
            SetForm();
            FillForm();
            SetModifiable();
        }

        private void SetForm()
        {
            var provinceList = Provinces.GetProvinces();
            foreach (var pro in provinceList)
            {
                cbBox_recAdd_province.Items.Add(pro.province1);
            }
        }


        private void FillForm()
        {
            // Order basic information
            lbl_orderID_No.Text = Convert.ToString(myOrder.orderID);
            dtp_orderDate.Value = myOrder.orderDate;
            lbl_status.Text = Orders.GetOrderStatus(myOrder);

            // Dealer information
            staff myDealer = Staffs.GetStaff(myOrder.dealerID);
            txt_dealerID.Text = myDealer.staffID;
            txt_dealerName.Text = myDealer.name;

            // Receiver Information
            city mycity = Cities.GetCity(myOrder.cityID);
            province myProvince = Cities.GetProvince(mycity);
            cbBox_recAdd_province.Text = myProvince.province1;
            cbBox_recAdd_city.Text = mycity.city1;
            txt_recAdd.Text = myOrder.deliveryAddress;

            // Invoice information
            txt_invName.Text = myOrder.invName;
            dtp_expectDate.Value = myOrder.expDeliverTime;
            txt_invAdd.Text = myOrder.invAddress;

            // Item List
            dataGridView_itemList.Rows.Clear();
            var orderedItemList = Orders.GetOrderItemList(myOrder);
            foreach (var orderLine in orderedItemList)
            {
                FillItemList(orderLine);
            }
            CalculateTotalAndWeight();
        }

        private void FillItemList(orderitem orderLine)
        {
            var myItem = Items.GetItem(orderLine.itemID);

            // Find reserved item amount
            int reservedAmt = Items.GetTotalReservedAmount(orderLine.itemID);

            // Find the user(dealer) reserved instock item
            int myReserved = 0;
            staff myStaff = Users.GetStaff(myUser);
            if (myStaff != null && Staffs.isDealer(myStaff))
            {
                List<reserveditem> myResItems = Items.GetReservedItems(myStaff);
                myReserved = myResItems.Where(i => i.itemID.Equals(myItem.itemID) && i.availible.Equals("Y")).Select(i => i.reservedAmt).Sum();
            }

            // Find item available amount
            int available = myItem.actualStock - myItem.orderedAmt - reservedAmt + myReserved + orderLine.qty;

            // Find item selling price
            double sellPrice = Items.GetSellingPrice(orderLine.itemID, myOrder.orderDate);

            // Find subtotal
            double subtotal = sellPrice * orderLine.qty;

            // Find weight
            double weight = myItem.weight * orderLine.qty;

            // Add row
            dataGridView_itemList.Rows.Add(orderLine.itemID, myItem.name, Convert.ToString(available), Convert.ToString(orderLine.qty),
            sellPrice.ToString(), subtotal.ToString("0.00"), "Delete", Convert.ToString(myItem.weight));
        }

        private void SetModifiable()
        {
            if(lbl_status.Text.Equals("Processing"))
            {
                cbBox_recAdd_province.Enabled = true;
                cbBox_recAdd_city.Enabled = true;
                txt_recAdd.ReadOnly = false;
                txt_invName.ReadOnly = false;
                dtp_expectDate.Enabled = true;
                txt_invAdd.ReadOnly = false;
                txt_itemID.Enabled = true;
                dataGridView_itemList.Enabled = true;
                return;
            }

            if (lbl_status.Text.Equals("Assembled") || lbl_status.Text.Equals("Packing"))
            {
                cbBox_recAdd_province.Enabled = true;
                cbBox_recAdd_city.Enabled = true;
                txt_recAdd.ReadOnly = false;
                txt_invName.ReadOnly = false;
                dtp_expectDate.Enabled = true;
                txt_invAdd.ReadOnly = false;
                dataGridView_itemList.Columns[6].Visible = false;
                dataGridView_itemList.Columns[1].Width += 100;
                dataGridView_itemList.Location = new Point(12, 23);
                dataGridView_itemList.Height = 203;
                return;
            }

            // Not modifiable
            MessageBox.Show("Sorry! The order status of this order (ID: " + myOrder.orderID + ") is \""
                            + lbl_status.Text + "\". It can not be modified. You are directed to view the order details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ViewOrder vo = new ViewOrder(myOrder.orderID.ToString());
            vo.Show();
            this.Close();

        }

        private void CalculateTotalAndWeight()
        {
            double total = 0;
            double totalWeight = 0;
            for (int x = 0; x < dataGridView_itemList.RowCount; x++) 
            {
                total += Convert.ToDouble(dataGridView_itemList.Rows[x].Cells[5].Value);
                totalWeight += Convert.ToDouble(dataGridView_itemList.Rows[x].Cells[7].Value) * Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
            }
            lbl_totalAmt.Text = total.ToString("0.00");
            lbl_weightAmt.Text = totalWeight.ToString();
        }

        private bool CheckReceivingDate()
        {
            if (dtp_expectDate.Value < myOrder.expDeliverTime)
            {
                errorProvider1.SetError(dtp_expectDate, "The expect receiving date should not ealier than the previous setting date.");
                return false;
            }
            else
            {
                errorProvider1.SetError(dtp_expectDate, "");
                return true;
            }
        }

        private bool CheckInvName()
        {
            if (txt_invName.Text.Equals(""))
            {
                errorProvider1.SetError(txt_invName, "This field is required.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_invName, "");
                return true;
            }
        }

        private bool CheckRecAdd()
        {
            if (cbBox_recAdd_province.Equals("") || cbBox_recAdd_city.Equals("") || txt_recAdd.Text.Equals(""))
            {
                errorProvider1.SetError(cbBox_recAdd_city, "This field is required.");
                return false;
            }
            else
            {
                errorProvider1.SetError(cbBox_recAdd_city, "");
                return true;
            }
        }

        private bool CheckInvAdd()
        {
            if (txt_invAdd.Text.Equals(""))
            {
                errorProvider1.SetError(txt_invAdd, "This field is required.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_invAdd, "");
                return true;
            }
        }

        private void txt_itemID_TextChanged(object sender, EventArgs e)
        {
            txt_item.Text = "";
            lbl_availableQty.Text = "";
            lbl_price.Text = "";
            txt_qty.Clear();
            txt_qty.Enabled = false;
            bt_addItem.Enabled = false;
            errorProvider1.SetError(txt_itemID, "");

            if (txt_itemID.Text == "")
            {
                errorProvider1.SetError(txt_itemID, "");
                return;
            }


            var myItem = Items.GetItem(txt_itemID.Text);
            if (myItem == null)
            {
                errorProvider1.SetError(txt_itemID, "Item does not exist.");
                return;
            }

            txt_item.Text = myItem.name;

            lbl_price.Text = "¥" + Items.GetSellingPrice(myItem.itemID, DateTime.Today);

            // Find the total instock reserved amount of the item
            int reservedAmt = Items.GetTotalReservedAmount(myItem.itemID);

            // Find the user(dealer) reserved instock item
            int myReserved = 0;
            staff myStaff = Users.GetStaff(myUser);
            if (myStaff != null && myStaff.positionID.Equals("DLR"))
            {
                List<reserveditem> myResItems = Items.GetReservedItems(myStaff);
                myReserved = myResItems.Where(i => i.itemID.Equals(myItem.itemID) && i.availible.Equals("Y")).Select(i => i.reservedAmt).Sum();
            }

            int itemQtyInList = GetItemQtyInList(txt_itemID.Text);
            if (myReserved > 0)
            {
                myReserved = myReserved - itemQtyInList + OriginalQty(txt_itemID.Text);
                if (myReserved < 0)
                {
                    itemQtyInList = 0 - myReserved;
                    myReserved = 0;
                }
                else
                {
                    itemQtyInList = 0;
                }
            }

            int availableItem = myItem.actualStock - myItem.orderedAmt - reservedAmt + myReserved - itemQtyInList + OriginalQty(txt_itemID.Text);
            lbl_availableQty.Text = availableItem + " (" + myReserved + ")";
            errorProvider1.SetError(txt_itemID, "");

            if (availableItem > 0)
            {
                txt_qty.Enabled = true;
            }

        }

        private int GetItemQtyInList(String myItemID)
        {
            for (int x = 0; x < dataGridView_itemList.RowCount; x++) 
            {
                String itemID = dataGridView_itemList.Rows[x].Cells[0].Value.ToString();
                if (itemID.Equals(myItemID))
                {
                    int qty = Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
                    return qty;
                }
            }
            return 0;
        }

        private int OriginalQty(String myItemID)
        {
            orderitem line = Orders.GetOrderitem(myOrder, myItemID);
            if (line != null)
                return line.qty;
            else
                return 0;
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text == "")
            {
                errorProvider1.SetError(txt_qty, "");
                return;
            }

            String[] available = lbl_availableQty.Text.Split(' ');

            if (!Regex.IsMatch(txt_qty.Text, @"^\d+$"))
            {
                bt_addItem.Enabled = false;
                errorProvider1.SetError(txt_qty, "Please enter the item quantities.");
            }
            else
            if (Convert.ToInt32(txt_qty.Text) > Convert.ToInt32(available[0]))
            {
                bt_addItem.Enabled = false;
                errorProvider1.SetError(txt_qty, "Item quantities should not larger than available quantities");
            }
            else
            {
                bt_addItem.Enabled = true;
                errorProvider1.SetError(txt_qty, "");
            }
        }

        private void bt_addItem_Click(object sender, EventArgs e)
        {
            if (!AddSameItem(txt_itemID.Text, Convert.ToInt32(txt_qty.Text)))
            {
                AddItemList(txt_itemID.Text, Convert.ToInt32(txt_qty.Text));
            }
            txt_itemID.Clear();
            txt_item.Text = "";
            lbl_availableQty.Text = "";
            txt_qty.Clear();
            txt_qty.Enabled = false;
            bt_addItem.Enabled = false;
            errorProvider1.SetError(txt_itemID, "");
            errorProvider1.SetError(txt_qty, "");
        }

        // determine if the added item is already occure in the list. if true, add on the new added value to the list
        private bool AddSameItem(String myItemID, int myQty)
        {
            for (int x = 0; x < dataGridView_itemList.RowCount; x++) 
            {
                String previousItemID = dataGridView_itemList.Rows[x].Cells[0].Value.ToString();
                if (previousItemID.Equals(myItemID))
                {
                    int previousQty = Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
                    dataGridView_itemList.Rows[x].Cells[3].Value = previousQty + myQty;
                    return true;
                }
            }
            return false;
        }

        private void AddItemList(String itemID, int qty)
        {
            var myItem = Items.GetItem(itemID);

            // Find reserved item amount
            int reservedAmt = Items.GetTotalReservedAmount(itemID);

            // Find the user(dealer) reserved instock item
            int myReserved = 0;
            staff myStaff = Users.GetStaff(myUser);
            if (myStaff != null && myStaff.positionID.Equals("DLR"))
            {
                List<reserveditem> myResItems = Items.GetReservedItems(myStaff);
                myReserved = myResItems.Where(i => i.itemID.Equals(myItem.itemID) && i.availible.Equals("Y")).Select(i => i.reservedAmt).Sum();
            }

            // Find item available amount
            int available = myItem.actualStock - myItem.orderedAmt - reservedAmt + myReserved;

            // Change qty if it is greater than available amount
            if (available == 0)
            {
                MessageBox.Show("The current item (" + itemID + ") is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (available < qty)
            {
                MessageBox.Show("The current available amount of item (" + itemID + ") is " + available + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                qty = available;
            }

            // Find item selling price
            double sellPrice = Items.GetSellingPrice(myItem.itemID, DateTime.Today);

            // Find subtotal
            double subtotal = sellPrice * qty;

            // Find weight
            double weight = myItem.weight * qty;

            // Add row
            dataGridView_itemList.Rows.Add(itemID, myItem.name, Convert.ToString(available), Convert.ToString(qty),
            sellPrice.ToString(), subtotal.ToString("0.00"), "Delete", Convert.ToString(myItem.weight));
        }

        private void dataGridView_itemList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotalAndWeight();
        }

        private void dataGridView_itemList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotalAndWeight();
        }

        private void dataGridView_itemList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (EmptyItemList())
                return;

            ValidateQty(e.RowIndex);
            UpdateItemListValue(e.RowIndex);
            CalculateTotalAndWeight();
        }

        private bool EmptyItemList()
        {
            return dataGridView_itemList.RowCount == 0;
        }

        private void ValidateQty(int rowIndex)
        {
            int available = Convert.ToInt32(dataGridView_itemList.Rows[rowIndex].Cells[2].Value);
            int qty = Convert.ToInt32(dataGridView_itemList.Rows[rowIndex].Cells[3].Value);
            if (qty > available)
                dataGridView_itemList.Rows[rowIndex].Cells[3].Value = available;
        }

        private void UpdateItemListValue(int rowIndex)
        {
            double price = Convert.ToDouble(dataGridView_itemList.Rows[rowIndex].Cells[4].Value);
            int qty = Convert.ToInt32(dataGridView_itemList.Rows[rowIndex].Cells[3].Value);
            dataGridView_itemList.Rows[rowIndex].Cells[5].Value = price * qty;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_itemID.Clear();
            FillForm();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (EmptyItemList())
            {
                MessageBox.Show("Item list should not empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDouble(lbl_weightAmt.Text) > 1500)
            {
                MessageBox.Show("Total weight should not over 1500 kg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckInvAdd() & CheckInvName() & CheckRecAdd() & CheckReceivingDate())
            {
                UpdateOrder();
                MessageBox.Show("The order is updated.", "Success");
                CloseThisPage();
            }
            else
            {
                MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseThisPage()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is OrderHistory);
            if (formToShow != null)
            {
                formToShow.Show();
            }

            this.Close();
        }

        private void UpdateOrder()
        {
            // Get order information
            String recAddress = txt_recAdd.Text;
            String recCity_Text = cbBox_recAdd_city.Text;
            String recCityID = Cities.GetCityID(recCity_Text);
            DateTime expRecDate = dtp_expectDate.Value;
            String invoiceName = txt_invName.Text;
            String invoiceAddress = txt_invAdd.Text;
            double orderWeight = Convert.ToDouble(lbl_weightAmt.Text);

            // Update order information
            Orders.SetOrder(myOrder.orderID, expRecDate, recCityID, recAddress, invoiceName, invoiceAddress, orderWeight);

            if (lbl_status.Text.Equals("Processing"))
                UpdateOrderLine();
        }

        private void UpdateOrderLine()
        {
            // Remove the original ordered item record
            Orders.RemoveOrderItems(myOrder.orderID);

            // Add new order item
            for (int x = 0; x < dataGridView_itemList.RowCount; x++)
            {
                String myItemID = dataGridView_itemList.Rows[x].Cells[0].Value.ToString();
                int myQty = Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
                double mySubtotal = Convert.ToDouble(dataGridView_itemList.Rows[x].Cells[5].Value);

                orderitem myOrderitem = new orderitem
                {
                    orderID = myOrder.orderID,
                    itemID = myItemID,
                    qty = myQty,
                    subTotal = mySubtotal
                };
                Orders.AddNewOrderItems(myOrder.orderID, myOrderitem);

                // Update user's reserved amount of that item
                orderitem previous = myOrderItems.FirstOrDefault(i => i.itemID.Equals(myItemID));
                if (previous != null && myQty > previous.qty)
                {
                    int updatingQTY = myQty - previous.qty;

                    staff myStaff = Staffs.GetStaff(myUser.staffID);
                    List<reserveditem> myReserved = Items.GetReservedItems(myStaff);
                    myReserved = myReserved.OrderBy(i => i.reserveID).Where(i => i.itemID.Equals(myItemID) && i.availible.Equals("Y")).Select(i => i).ToList();
                    int tmpQty = updatingQTY;
                    foreach (reserveditem reserved in myReserved)
                    {
                        if (tmpQty <= 0)
                            tmpQty = 0;

                        int reservedAmt = reserved.reservedAmt;

                        reservedAmt = reservedAmt - tmpQty;
                        if (reservedAmt <= 0)
                            Items.CancelReservation(reserved.reserveID);
                        else
                            Items.ModifyReservation(reserved.reserveID, reservedAmt);

                        tmpQty -= reserved.reservedAmt;
                    }
                }

            }
        }

        private void cbBox_recAdd_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBox_recAdd_city.ResetText();
            cbBox_recAdd_city.Items.Clear();

            province myProvince = Provinces.GetProvince(cbBox_recAdd_province.Text);
            var cityList = Cities.GetCities(myProvince);
            foreach (var city in cityList)
            {
                cbBox_recAdd_city.Items.Add(city.city1);
            }
        }

        private void dataGridView_itemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_itemList.Rows[e.RowIndex].Cells[0].Value == null)
                dataGridView_itemList.Rows[e.RowIndex].Cells[3].ReadOnly = true;
            else
                dataGridView_itemList.Rows[e.RowIndex].Cells[3].ReadOnly = false;

            if (e.ColumnIndex == 6 && e.RowIndex != dataGridView_itemList.RowCount)
            {
                var result = MessageBox.Show("Are you sure to remove this row?", "", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (result.ToString().Equals("Yes"))
                {
                    int row = e.RowIndex;
                    dataGridView_itemList.Rows.RemoveAt(row);
                }
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is OrderHistory);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Hide();
        }

        // Allow form move
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void picBox_return_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }
    }
    

    
}
