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
using SLMC_MS.model;

namespace SLMC_MS
{
    public partial class CreateOrder : Form
    {
        user myUser;
        public CreateOrder(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();
            try
            {
                PermissionCheck();
            }
            catch (PermissionDeniedException exc)
            {
                throw exc;
            }
        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void PermissionCheck()
        {
            if (myUser.staffID == null)
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }

            staff myStaff = Users.GetStaff(myUser);
            if (!Staffs.isDealer(myStaff) && !Staffs.isSalesOrderOfficer(myStaff)) 
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void SetForm()
        {
            // Reset all value
            dtp_orderDate.Value = DateTime.Today;
            txt_dealerID.Clear();
            txt_dealerName.Clear();
            cbBox_province.Items.Clear();
            cbBox_city.Items.Clear();
            txt_dealerAdd.Clear();
            ck_same1.Checked = false;
            ck_same2.Checked = false;
            cbBox_recAdd_province.Items.Clear();
            cbBox_recAdd_province.Text = "";
            cbBox_recAdd_city.Items.Clear();
            cbBox_recAdd_city.Text = "";
            txt_recAdd.Clear();
            txt_invName.Clear();
            dtp_expectDate.Value = DateTime.Today.AddDays(7);
            txt_invAdd.Clear();
            txt_itemID.Text = "";
            dataGridView_itemList.Rows.Clear();

            var provinceList = Provinces.GetProvinces();
            foreach (var pro in provinceList)
            {
                cbBox_province.Items.Add(pro.province1);
                cbBox_recAdd_province.Items.Add(pro.province1);
            }


            txt_qty.Enabled = false;
            bt_addItem.Enabled = false;
            dataGridView_itemList.Rows.Clear();
            txt_dealerID.Clear();

            staff myStaff = Users.GetStaff(myUser);
            if (Staffs.isDealer(myStaff))
            {
                txt_dealerID.ReadOnly = true;
                SetForm_Dealer(myStaff);
            }

            errorProvider1.Clear();
        }

        private void SetForm_Dealer(staff dealer)
        {
            city myCity = Staffs.GetCity(dealer);
            province myProvince = null;
            if (myCity != null)
                myProvince = Cities.GetProvince(myCity);
            
            txt_dealerID.Text = dealer.staffID;
            txt_dealerName.Text = dealer.name;
            txt_dealerAdd.Text = dealer.address;
            if (myProvince != null)
                cbBox_province.Text = myProvince.province1;
            if (myCity != null)
                cbBox_city.Text = myCity.city1;
            if (myProvince == null || myCity == null || dealer.address == null)
                ck_same1.Enabled = false;
        }

        private void cbBox_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBox_city.ResetText();
            cbBox_city.Items.Clear();

            province province = Provinces.GetProvince(cbBox_province.Text);
            var cityList = Cities.GetCities(province);
            foreach (var city in cityList.ToList())
            {
                cbBox_city.Items.Add(city.city1);
            }
        }

        private void cbBox_recAdd_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBox_recAdd_city.ResetText();
            cbBox_recAdd_city.Items.Clear();

            province province = Provinces.GetProvince(cbBox_recAdd_province.Text);
            var cityList = Cities.GetCities(province);
            foreach (var city in cityList.ToList())
            {
                cbBox_recAdd_city.Items.Add(city.city1);
            }
        }
        

        private void ck_same1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_same1.Checked)
            {
                cbBox_recAdd_province.Enabled = false;
                cbBox_recAdd_city.Enabled = false;
                txt_recAdd.Enabled = false;
            } else
            {
                cbBox_recAdd_province.Enabled = true;
                cbBox_recAdd_city.Enabled = true;
                txt_recAdd.Enabled = true;
            }
        }

        private void ck_same2_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_same2.Checked)
            {
                txt_invAdd.Enabled = false;
            }
            else
            {
                txt_invAdd.Enabled = true;
            }
        }

        private void txt_dealerID_TextChanged(object sender, EventArgs e)
        {
            txt_dealerName.Clear();
            cbBox_province.ResetText();
            cbBox_city.ResetText();
            txt_dealerAdd.Clear();
            if(CheckDealerID())
            {
                staff dealer = Staffs.GetStaff(txt_dealerID.Text);
                SetForm_Dealer(dealer);
            }
        }

        private bool CheckDealerID()
        {
            if(txt_dealerID.Text.Equals(""))
            {
                errorProvider1.SetError(txt_dealerID, "This field is required.");
                return false;
            }

            var dealer = Staffs.GetStaff(txt_dealerID.Text);
            if (dealer == null)
            {
                errorProvider1.SetError(txt_dealerID, "Dealer is not exist.");
                return false;
            }
            else if (!Staffs.isDealer(dealer))
            {
                errorProvider1.SetError(txt_dealerID, "The staff is not dealer.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_dealerID, "");
                return true;
            }
        }

        private bool CheckReceivingDate()
        {
            if(dtp_expectDate.Value < DateTime.Today.AddDays(7))
            {
                errorProvider1.SetError(dtp_expectDate,"The expect receiving date should be one week later.");
                return false;
            } else
            {
                errorProvider1.SetError(dtp_expectDate, "");
                return true;
            }
        }

        private void dtp_expectDate_ValueChanged(object sender, EventArgs e)
        {
            CheckReceivingDate();
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
            if (ck_same1.Checked)
            {
                errorProvider1.SetError(cbBox_recAdd_city, "");
                return true;
            }
            if(cbBox_recAdd_province.Equals("")||cbBox_recAdd_city.Equals("")||txt_recAdd.Text.Equals(""))
            {
                errorProvider1.SetError(cbBox_recAdd_city, "This field is required.");
                return false;
            } else
            {
                errorProvider1.SetError(cbBox_recAdd_city, "");
                return true;
            }
        }

        private bool CheckInvAdd()
        {
            if (ck_same2.Checked)
            {
                errorProvider1.SetError(txt_invAdd, "");
                return true;
            }
            if (txt_invAdd.Text.Equals(""))
            {
                errorProvider1.SetError(txt_invAdd, "This field is required.");
                return false;
            } else
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

            // Find the user(dealer) reserved instock item
            staff myStaff = Users.GetStaff(myUser);

            int myReserved = 0;
            if (myStaff != null && Staffs.isDealer(myStaff))
            {
                var reservedItemList = Items.GetReservedItems(myStaff);
                myReserved = reservedItemList.Where(i => i.availible.Equals("Y") && i.itemID.Equals(txt_itemID.Text)).Select(i => i.reservedAmt).Sum();
            }

            int itemQtyInList = GetItemQtyInList(txt_itemID.Text);
            if (myReserved > 0)
            {
                myReserved = myReserved - itemQtyInList;
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

            int availableItem = Items.GetAvailableAmount(myItem.itemID) + myReserved - itemQtyInList;
            lbl_availableQty.Text = availableItem.ToString() + " (" + myReserved.ToString() + ")";
            errorProvider1.SetError(txt_itemID, "");

            if (availableItem > 0)
            {
                txt_qty.Enabled = true;
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text == "")
            {
                errorProvider1.SetError(txt_qty, "");
                return;
            }

            String[] available = lbl_availableQty.Text.Split(' ');

            if (!Regex.IsMatch(txt_qty.Text,@"^\d+$"))
            {
                bt_addItem.Enabled = false;
                errorProvider1.SetError(txt_qty, "Please enter the item quantities.");
            } else 
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
                AddItemList(txt_itemID.Text,Convert.ToInt32(txt_qty.Text));
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

        private void AddItemList(String itemID, int qty)
        {
            using (slmc content = new slmc())
            {
                var myItem = content.item.FirstOrDefault(i=>i.itemID.Equals(itemID));

                // Find reserved item amount
                int reservedAmt = 0;
                var myReservedItem = from list in content.reserveditem
                                     where list.itemID.Equals(itemID)
                                     select list.reservedAmt;
                reservedAmt = myReservedItem.ToList().Sum();

                // Find the user(dealer) reserved instock item
                int myReserved = 0;
                staff myStaff = Users.GetStaff(myUser);
                if(myStaff != null && myStaff.positionID.Equals("DLR"))
                {
                    List<reserveditem> myResItems = Items.GetReservedItems(myStaff);
                    myReserved = myResItems.Where(i => i.itemID.Equals(myItem.itemID) && i.availible.Equals("Y")).Select(i => i.reservedAmt).Sum();
                }

                // Find item available amount
                int available = myItem.actualStock - myItem.orderedAmt - reservedAmt + myReserved;

                // Change qty if it is greater than available amount
                if(available == 0)
                {
                    MessageBox.Show("The current item (" + itemID + ") is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (available < qty)
                {
                    MessageBox.Show("The current available amount of item (" + itemID + ") is " + available + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    qty = available;
                }

                // Find item purchase price
                var price = myItem.itemprice.OrderByDescending(i=>i.issueDate).FirstOrDefault(i=>i.issueDate<=DateTime.Today);
                double sellPrice = price.sellingPrice;

                // Find subtotal
                double subtotal = sellPrice * qty;

                // Find weight
                double weight = myItem.weight * qty;

                // Add row
                dataGridView_itemList.Rows.Add(itemID, myItem.name, Convert.ToString(available), Convert.ToString(qty),
                sellPrice.ToString(), subtotal.ToString("0.00"), "Delete", Convert.ToString(myItem.weight));
            }
        }

        // determine if the added item is already occure in the list. if true, add on the new added value to the list
        private bool AddSameItem(String myItemID, int myQty)
        {
            for (int x = 0; x < dataGridView_itemList.RowCount; x++) 
            {
                String previousItemID = dataGridView_itemList.Rows[x].Cells[0].Value.ToString();
                if(previousItemID.Equals(myItemID))
                {
                    int previousQty = Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
                    dataGridView_itemList.Rows[x].Cells[3].Value = previousQty + myQty;
                    return true;
                }
            }
            return false;
        }

        private int GetItemQtyInList(String myItemID)
        {
            for (int x = 0; x < dataGridView_itemList.RowCount; x++) 
            {
                String itemID = dataGridView_itemList.Rows[x].Cells[0].Value.ToString();
                if(itemID.Equals(myItemID))
                {
                    int qty = Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
                    return qty;
                }
            }
            return 0;
        }

        private void UpdateItemListValue(int rowIndex)
        {
            double price = Convert.ToDouble(dataGridView_itemList.Rows[rowIndex].Cells[4].Value);
            int qty = Convert.ToInt32(dataGridView_itemList.Rows[rowIndex].Cells[3].Value);
            dataGridView_itemList.Rows[rowIndex].Cells[5].Value = price * qty;
        }

        private void dataGridView_itemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void bt_clear_Click(object sender, EventArgs e)
        {
            SetForm();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if(EmptyItemList())
            {
                MessageBox.Show("Item list should not empty.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(Convert.ToDouble(lbl_weightAmt.Text)>1500)
            {
                MessageBox.Show("Total weight should not over 1500 kg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckDealerID() & CheckInvAdd() & CheckInvName() & CheckRecAdd() & CheckReceivingDate())
            {
                NewOrder("proc");   // new order with "process" status
                DialogResult result = MessageBox.Show("Order (id: " + Orders.GetLatestOrderID(txt_dealerID.Text) + ") is created. Do you want to place another new order?",
                                                      "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    SetForm();
                else
                    CloseThisPage();
            }
            else
            {
                MessageBox.Show("Please complete and correct the form.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CloseThisPage()
        {
            DialogResult result = MessageBox.Show("Do you want to leave this page?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is HomePage);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Close();
        }

        private bool EmptyItemList()
        {
            return dataGridView_itemList.RowCount == 0;
        }
        
        private void NewOrder(String myOrderStatus)
        {
            using (slmc content = new slmc())
            {
                // Get order information
                String myDealerID = txt_dealerID.Text;
                DateTime expRecDate = dtp_expectDate.Value;
                String invoiceName = txt_invName.Text;
                String invoiceAddress = "";
                if (ck_same1.Checked && ck_same2.Checked)
                {
                    invoiceAddress = cbBox_province.Text + ", " + cbBox_city.Text + ", " + txt_dealerAdd.Text;
                }
                else if (!ck_same1.Checked && ck_same2.Checked)
                {
                    invoiceAddress = cbBox_recAdd_province.Text + ", " + cbBox_recAdd_city.Text + ", " + txt_recAdd.Text;
                }
                else
                {
                    invoiceAddress = txt_invAdd.Text;
                }

                String recAddress = (ck_same1.Checked) ? txt_dealerAdd.Text : txt_recAdd.Text;
                String recCity_Text = (ck_same1.Checked) ? cbBox_city.Text : cbBox_recAdd_city.Text;
                String recCityID = Cities.GetCityID(recCity_Text);
                double orderWeight = Convert.ToDouble(lbl_weightAmt.Text);

                // Add order
                order myOrder = new order
                {
                    dealerID = myDealerID,
                    expDeliverTime = expRecDate,
                    statusID = myOrderStatus,
                    invName = invoiceName,
                    invAddress = invoiceAddress,
                    deliveryAddress = recAddress,
                    cityID = recCityID,
                    orderDate = DateTime.Today,
                    weight = orderWeight
                };
                //order Order = content.order.Add(myOrder);

                List<orderitem> orderitems = new List<orderitem>();
                for (int x = 0; x < dataGridView_itemList.RowCount; x++) 
                {
                    String myItemID = dataGridView_itemList.Rows[x].Cells[0].Value.ToString();
                    int myQty = Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
                    double mySubtotal = Convert.ToDouble(dataGridView_itemList.Rows[x].Cells[5].Value);

                    // Add order item
                    orderitem myOrderitem = new orderitem
                    {
                        itemID = myItemID,
                        qty = myQty,
                        subTotal = mySubtotal
                    };
                    orderitems.Add(myOrderitem);
                    
                }
                Orders.Add(myOrder, orderitems);
            }
        }
        

        private void dataGridView_itemList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (EmptyItemList())
                return;

            ValidateQty(e.RowIndex);
            UpdateItemListValue(e.RowIndex);
            CalculateTotalAndWeight();
        }

        private void ValidateQty(int rowIndex)
        {
            int available = Convert.ToInt32(dataGridView_itemList.Rows[rowIndex].Cells[2].Value);
            int qty = Convert.ToInt32(dataGridView_itemList.Rows[rowIndex].Cells[3].Value);
            if (qty > available)
                dataGridView_itemList.Rows[rowIndex].Cells[3].Value = available;
        }

        private void CalculateTotalAndWeight()
        {
            double total = 0;
            double totalWeight = 0;
            for (int x = 0; x < dataGridView_itemList.RowCount ; x++)
            {
                total += Convert.ToDouble(dataGridView_itemList.Rows[x].Cells[5].Value);
                totalWeight += Convert.ToDouble(dataGridView_itemList.Rows[x].Cells[7].Value) * Convert.ToInt32(dataGridView_itemList.Rows[x].Cells[3].Value);
            }
            lbl_totalAmt.Text = total.ToString("0.00");
            lbl_weightAmt.Text = totalWeight.ToString();
        }

        private void dataGridView_itemList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotalAndWeight();
        }

        private void dataGridView_itemList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotalAndWeight();
        }

        private void CreateOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void picBox_return_Click(object sender, EventArgs e)
        {
            CloseThisPage();
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
    }

    
}
