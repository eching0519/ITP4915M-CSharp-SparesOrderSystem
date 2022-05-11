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
using System.Text.RegularExpressions;

namespace SLMC_MS
{
    public partial class ItemSearchingEngine : Form
    {
        user myUser;
        List<item> itemList;

        // Information type
        bool basic;
        bool sales;
        bool stock;
        bool restricted;

        public ItemSearchingEngine(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();
            basic = sales = stock = restricted = false;
            try
            {
                PermissionCheck();
            }
            catch (PermissionDeniedException exc)
            {
                throw exc;
            }
            itemList = Items.GetItems();
        }

        private void PermissionCheck()
        {
            if (!myUser.username.Equals("admin") && myUser.staffID == null)
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }

            // Administrator View
            if (myUser.username.Equals("admin"))
            {
                basic = sales = stock = restricted = true;
                return;
            }

            staff myStaff = Users.GetStaff(myUser);
            // Administrator View
            if (Staffs.isSalesManager(myStaff) || Staffs.isSalesOrderOfficeManager(myStaff) || Staffs.isStockRecordsClerk(myStaff))
            {
                basic = sales = stock = restricted = true;
                return;
            }

            //General View
            if (Staffs.isDealer(myStaff) || Staffs.isAreaManager(myStaff) || Staffs.isSalesOrderOfficer(myStaff))
            {
                basic = sales = true;
                return;
            }

            //Warehouse View
            if (Staffs.isSparePartsController(myStaff) || Staffs.isStoremen(myStaff))
            {
                basic = stock = true;
                return;
            }
        }

        private void ItemSearchingEngine_Load(object sender, EventArgs e)
        {
            SetView();
        }

        private void SetView()
        {
            if (!basic)
            {
                dgv_itemSearchList.Columns[0].Visible = false;      // ItemID
                dgv_itemSearchList.Columns[1].Visible = false;      // Item Name
                dgv_itemSearchList.Columns[2].Visible = false;      // Item Name Chinese
                dgv_itemSearchList.Columns[3].Visible = false;      // description
                dgv_itemSearchList.Columns[4].Visible = false;      // SupplierID
                dgv_itemSearchList.Columns[5].Visible = false;      // Supplier Name
            }

            if (!sales)
            {
                dgv_itemSearchList.Columns[6].Visible = false;      // Selling Price
                dgv_itemSearchList.Columns[9].Visible = false;      // Available Stock
                lbl_price.Hide();
                txt_minAmount.Hide();
                txt_maxAmount.Hide();
                label1.Hide();
                lbl_available.Hide();
                txt_availableMin.Hide();
                txt_availableMax.Hide();
                label2.Hide();
                bt_search.Location = new Point(755, 77);
                dgv_itemSearchList.Size = new Size(853, 429);
                dgv_itemSearchList.Location = new Point(44, 145);
            }
            if (!stock)
            {
                dgv_itemSearchList.Columns[8].Visible = false;      // Stock
                dgv_itemSearchList.Columns[10].Visible = false;     // Location
                dgv_itemSearchList.Columns[11].Visible = false;     // Weight
            }
            if (!restricted)
            {
                dgv_itemSearchList.Columns[7].Visible = false;      // Purchase Price
                flowLayoutPanel1.Visible = false;
            }
        }

        private void ItemSearchingEngine_Shown(object sender, EventArgs e)
        {
            DisplayItems(itemList);
        }

        private void DisplayItems(List<item> items)
        {
            dgv_itemSearchList.Rows.Clear();
            foreach(item i in items)
            {
                String itemID = i.itemID;
                String name = i.name;
                String name_ch = i.name_ch;
                String desc = i.description;
                String supplierID = i.supplierID;
                String supplierName = Suppliers.GetSupplier(supplierID).name;
                double sellingPrice = 0;
                double purchasePrice = 0;
                int stock = i.actualStock;
                int available = 0;
                String location = i.locatedShelf;
                double weight = i.weight;

                if (sales || restricted) 
                {
                    itemprice price = Items.GetItemPrice(itemID, DateTime.Today);
                    sellingPrice = price.sellingPrice;
                    purchasePrice = price.purchasePrice;
                }
                if (sales)
                    available = Items.GetAvailableAmount(itemID);

                dgv_itemSearchList.Rows.Add(itemID, name, name_ch, desc, supplierID, supplierName, sellingPrice, purchasePrice, 
                                            stock, available, location, weight, i.dangerLevel, i.reorderLevel);
            }

            if (restricted)
            {
                foreach (DataGridViewRow row in dgv_itemSearchList.Rows)
                {
                    if (Convert.ToInt32(row.Cells[9].Value) < Convert.ToInt32(row.Cells[12].Value))
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red;
                        row.DefaultCellStyle.Font = new Font(row.DataGridView.Font, FontStyle.Bold);
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt32(row.Cells[9].Value) < Convert.ToInt32(row.Cells[13].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }

        private void txt_minAmount_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_minAmount.Text, @"^([0-9]*)|([0-9]*[.][0-9]{1,2})$"))
                txt_minAmount.Text = "";
        }

        private void txt_maxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_maxAmount.Text, @"^([0-9]*)|([0-9]*[.][0-9]{1,2})$"))
                txt_maxAmount.Text = "";
        }

        private void txt_availableMin_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_availableMin.Text, @"^\d*$"))
                txt_availableMin.Text = "";
        }

        private void txt_availableMax_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_availableMax.Text, @"^\d*$"))
                txt_availableMax.Text = "";
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            List<item> searchList = itemList;

            String itemID = txt_itemID.Text;
            String name = txt_itemName.Text;
            String supplierID = txt_supplierID.Text;
            String supplierName = txt_supplierName.Text;
            double minPrice = txt_minAmount.Text.Equals("") ? 0 : Convert.ToDouble(txt_minAmount.Text);
            double maxPrice = txt_maxAmount.Text.Equals("") ? 999999 : Convert.ToDouble(txt_maxAmount.Text);
            int minAvailable = txt_availableMin.Text.Equals("") ? 0 : Convert.ToInt32(txt_availableMin.Text);
            int maxAvailable = txt_availableMax.Text.Equals("") ? 999999 : Convert.ToInt32(txt_availableMax.Text);

            // Filter by itemID
            if (!txt_itemID.Text.Equals(""))
                searchList = searchList.Where(i => i.itemID.Contains(itemID)).Select(i => i).ToList();

            // Filter by item name
            if (!txt_itemName.Text.Equals(""))
                searchList = searchList.Where(i => i.name.Contains(name) || i.name_ch.Contains(name)).Select(i => i).ToList();

            // Filter by supplierID
            if (!txt_supplierID.Text.Equals(""))
                searchList = searchList.Where(i => i.supplierID.Contains(supplierID)).Select(i => i).ToList();

            // Filter by supplier name
            if (!txt_supplierName.Text.Equals(""))
                searchList = searchList.Where(i => Suppliers.GetSupplier(i.supplierID).name.Contains(supplierName)).Select(i => i).ToList();

            // Filter by price
            if (!txt_minAmount.Text.Equals("")) 
                searchList = searchList.Where(i => Items.GetSellingPrice(i.itemID, DateTime.Today) >= minPrice).Select(i => i).ToList();
            if (!txt_maxAmount.Text.Equals("")) 
                searchList = searchList.Where(i => Items.GetSellingPrice(i.itemID, DateTime.Today) <= maxPrice).Select(i => i).ToList();

            // Filter by available stock
            if (!txt_availableMin.Text.Equals(""))
                searchList = searchList.Where(i => (i.actualStock - i.orderedAmt - Items.GetTotalReservedAmount(i.itemID)) >= minAvailable).Select(i => i).ToList();
            if (!txt_availableMax.Text.Equals(""))
                searchList = searchList.Where(i => (i.actualStock - i.orderedAmt - Items.GetTotalReservedAmount(i.itemID)) <= maxAvailable).Select(i => i).ToList();

            DisplayItems(searchList);

        }

        private void picBox_return_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void CloseThisPage()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is HomePage);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Close();
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
