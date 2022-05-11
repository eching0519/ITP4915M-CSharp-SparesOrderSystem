using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLMC_MS.model;

namespace SLMC_MS
{
    public partial class ViewOrder : Form
    {
        //user myUser;
        order myOrder;

        public ViewOrder(String orderID)
        {
            //this.myUser = myUser;
            int myOrderID = Convert.ToInt32(orderID);
            using (slmc content = new slmc())
            {
                myOrder = content.order.FirstOrDefault(i => i.orderID == myOrderID);
            }
                InitializeComponent();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            // Order basic information
            lbl_orderID_No.Text = Convert.ToString(myOrder.orderID);
            dtp_orderDate.Value = myOrder.orderDate;
            using (slmc content = new slmc())
            {
                lbl_status.Text = (content.orderstatus.FirstOrDefault(i => i.statusID.Equals(myOrder.statusID))).status;

                // Dealer information
                staff myDealer = content.staff.FirstOrDefault(i => i.staffID.Equals(myOrder.dealerID));
                txt_dealerID.Text = myDealer.staffID;
                txt_dealerName.Text = myDealer.name;

                // Receiver Information
                city mycity = content.city.FirstOrDefault(i => i.cityID.Equals(myOrder.cityID));
                province myProvince = mycity.province;
                cbBox_recAdd_province.Text = myProvince.province1;
                cbBox_recAdd_city.Text = mycity.city1;
                txt_recAdd.Text = myOrder.deliveryAddress;

                // Invoice information
                txt_invName.Text = myOrder.invName;
                dtp_expectDate.Value = myOrder.expDeliverTime;
                txt_invAdd.Text = myOrder.invAddress;

                // Item List
                var orderedItemList = content.orderitem.Where(i => i.orderID == myOrder.orderID).Select(i => i);
                foreach (var orderLine in orderedItemList.ToList())
                {
                    item item = Items.GetItem(orderLine.itemID);
                    String itemID = orderLine.itemID;
                    String itemName = item.name;
                    int qty = orderLine.qty;
                    double price = Items.GetSellingPrice(item.itemID, myOrder.orderDate);
                    double subtotal = price * qty;
                    dataGridView_itemList.Rows.Add(itemID, itemName, Convert.ToString(qty), Convert.ToString(price), subtotal.ToString(".00"));
                }
                CalculateTotal();
            }

            if (!(lbl_status.Text.Equals("Delivering") || lbl_status.Text.Equals("Complete")))
            {
                bt_invoice.Visible = false;
            }
        }

        private void CalculateTotal()
        {
            double total = 0;
            foreach(DataGridViewRow row in dataGridView_itemList.Rows)
            {
                total += Convert.ToDouble(row.Cells[4].Value);
            }
            lbl_totalAmt.Text = total.ToString(".00");
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

        private void CloseThisPage()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is OrderHistory);
            if (formToShow != null)
            {
                formToShow.Show();
                this.Close();
                return;
            }

            formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is OrderSearchEngine);
            if (formToShow != null)
            {
                formToShow.Show();
                this.Close();
                return;
            }

            formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is HomePage);
            if (formToShow != null)
            {
                formToShow.Show();
                this.Close();
                return;
            }
        }

        private void bt_invoice_Click(object sender, EventArgs e)
        {
            Invoice inv = new Invoice(myOrder);
            inv.exportPDF();
        }
    }

    
}
