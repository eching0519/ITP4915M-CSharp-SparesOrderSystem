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
    public partial class ItemData : Form
    {
        user myUser;
        List<item> itemList;

        public ItemData(user myUser)
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
            itemList = new List<item>();
        }

        private void PermissionCheck()
        {
            if (!myUser.username.Equals("admin") && Users.GetStaff(myUser) == null && !Staffs.isStockRecordsClerk(Users.GetStaff(myUser))) 
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void ItemData_Load(object sender, EventArgs e)
        {
            SetForm();
        }

        private void ItemData_Shown(object sender, EventArgs e)
        {
            itemList = Items.GetItems();
            SetItemList(itemList);
        }

        private void SetForm()
        {
            txt_itemID.Clear();
            txt_itemID.ReadOnly = false;
            txt_name.Clear();
            txt_name_ch.Clear();
            txt_desc.Clear();
            txt_selling.Clear();
            txt_purchase.Clear();
            txt_stock.Text = "0";
            ck_undefined.Checked = false;
            txt_location.Clear();
            txt_supplierID.Clear();
            txt_supplierID.ReadOnly = false;
            txt_supplier.Clear();
            txt_supAdd.Clear();
            txt_weight.Clear();
            errorProvider1.Clear();
        }

        private void SetItemList(List<item> items)
        {
            dgv_itemList.Rows.Clear();
            foreach(item item in items)
            {
                dgv_itemList.Rows.Add(item.itemID, item.name, item.actualStock, item.locatedShelf,
                    Items.GetSellingPrice(item.itemID, DateTime.Today), Items.GetPurchasePrice(item.itemID, DateTime.Today));
            }
        }

        private bool ModifyingData()
        {
            return txt_itemID.ReadOnly;
        }
        

        private void SetSupplier()
        {
            var mySupplier = Suppliers.GetSupplier(txt_supplierID.Text);
            if (mySupplier != null)
            {
                txt_supplier.ReadOnly = true;
                txt_supAdd.ReadOnly = true;
                txt_supplier.Clear();
                txt_supAdd.Clear();
                txt_supplier.Text = mySupplier.name;
                txt_supAdd.Text = mySupplier.address;
                errorProvider1.SetError(txt_supplierID, "");
                errorProvider1.SetError(txt_supplier, "");
                errorProvider1.SetError(txt_supAdd, "");
            }
            else
            {
                txt_supplier.ReadOnly = false;
                txt_supAdd.ReadOnly = false;
                txt_supplier.Clear();
                txt_supAdd.Clear();
            }
        }

        private bool CheckSupplierID()
        {
            if (txt_supplierID.Text.Equals(""))
            {
                errorProvider1.SetError(txt_supplierID, "It is a required field.");
                return false;
            }
            else if (txt_supplierID.Text.Length != 4)
            {
                errorProvider1.SetError(txt_supplierID, "The length of supplier ID should be 4.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_supplierID, "");
                return true;
            }
        }

        private bool CheckSupplierName()
        {
            if (txt_supplier.Text.Equals(""))
            {
                errorProvider1.SetError(txt_supplier, "It is a required field.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_supplier, "");
                return true;
            }
        }

        private bool CheckSupAdd()
        {
            if (txt_supAdd.Text.Equals(""))
            {
                errorProvider1.SetError(txt_supAdd, "It is a required field.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_supAdd, "");
                return true;
            }
        }

        private void txt_supplierID_TextChanged(object sender, EventArgs e)
        {
            SetSupplier();
        }

        private void txt_supplierID_Validating(object sender, CancelEventArgs e)
        {
            CheckSupplierID();
        }

        private void txt_supplier_Validating(object sender, CancelEventArgs e)
        {
            CheckSupplierName();
        }

        private void txt_supAdd_Validating(object sender, CancelEventArgs e)
        {
            CheckSupAdd();
        }

        private bool CheckItemID()
        {
            if(ModifyingData())
            {
                errorProvider1.SetError(txt_itemID, "");
                return true;
            }

            if (txt_itemID.Text.Equals(""))
            {
                errorProvider1.SetError(txt_itemID, "It is a required field.");
                return false;
            }

            if (!Regex.IsMatch(txt_itemID.Text, @"^[A-D][0-9]{5}$"))
            {
                errorProvider1.SetError(txt_itemID, "The item ID should consist of the category letter (A-D) plus a 5-digit number.");
                return false;
            }
            
            item myItem = Items.GetItem(txt_itemID.Text);
            if (myItem != null)
            {
                errorProvider1.SetError(txt_itemID, "This item ID have been used.");
                return false;
            }

            errorProvider1.SetError(txt_itemID, "");
            return true;
        }

        private void txt_itemID_Validating(object sender, CancelEventArgs e)
        {
            CheckItemID();
        }

        private bool CheckName()
        {
            if (txt_name.Text.Equals(""))
            {
                errorProvider1.SetError(txt_name, "It is a required field.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_name, "");
                return true;
            }
        }

        private void ck_undefined_CheckedChanged(object sender, EventArgs e)
        {
            if(ck_undefined.Checked)
            {
                txt_location.Clear();
                txt_location.ReadOnly = true;
                txt_location.Text = "UNDEF";
            } else
            {
                txt_location.Clear();
                txt_location.ReadOnly = false;
            }
        }

        private bool CheckActualStock()
        {
            if(!Regex.IsMatch(txt_stock.Text,@"^([0-9]{1,6})$"))
            {
                errorProvider1.SetError(txt_stock,"Please enter a valid number.");
                return false;
            }
            errorProvider1.SetError(txt_stock, "");
            return true;
        }

        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            CheckName();
        }

        private void txt_stock_Validating(object sender, CancelEventArgs e)
        {
            CheckActualStock();
        }

        private bool CheckWeight()
        {
            if (txt_weight.Text.Equals(""))
            {
                errorProvider1.SetError(txt_weight, "It is a required field.");
                return false;
            }
            else if (!Regex.IsMatch(txt_weight.Text, @"^(([0-9]{1,4})||([0-9]{1,4}[.][0-9]{1,2}))$"))
            {
                errorProvider1.SetError(txt_weight, "Please enter a valid item weight.");
                return false;
            }
            errorProvider1.SetError(txt_weight, "");
            return true;
        }

        private void txt_weight_Validating(object sender, CancelEventArgs e)
        {
            CheckWeight();
        }

        private bool CheckLocation()
        {
            if (txt_location.Text.Equals(""))
            {
                errorProvider1.SetError(txt_location, "It is a required field.");
                return false;
            }
            else if (!Regex.IsMatch(txt_location.Text, @"^(([ABCD][A-Z][0-9]{3})||UNDEF)$"))
            {
                errorProvider1.SetError(txt_location, "Please enter a valid location with 2 characters follow with 3 decimal numbers.");
                return false;
            }
            errorProvider1.SetError(txt_location, "");
            return true;
        }

        private void txt_location_Validating(object sender, CancelEventArgs e)
        {
            CheckLocation();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            SetForm();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (CheckItemID() & CheckName() & CheckActualStock() & CheckSupplierID() & CheckSupplierName() & CheckSupAdd() 
                & CheckWeight() & CheckPurchasePrice() & CheckSellingPrice() & CheckLocation()) 
            {
                if (ModifyingData())
                {
                    ModifyItem();
                    MessageBox.Show("Item is modified.", "Successful");
                }
                else
                {
                    // Add new item and supplier(if necessary)
                    if (txt_supplier.ReadOnly == false)
                        NewSupplier();
                    NewItem();
                    MessageBox.Show("Item is added.", "Successful");
                }
            }
            else
            {
                MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewSupplier()
        {
            String mySupplierID = txt_supplierID.Text;
            String mySupplierName = txt_supplier.Text;
            String mySupAdd = txt_supAdd.Text;

            supplier mySupplier = new supplier
            {
                supplierID = mySupplierID,
                name = mySupplierName,
                address = mySupAdd
            };
            Suppliers.Add(mySupplier);
        }

        private void ModifyItem()
        {
            String myItemID = txt_itemID.Text;
            String myName = txt_name.Text;
            String myName_ch = (txt_name_ch.Text.Equals("")) ? null : txt_name_ch.Text;
            String myDesc = (txt_desc.Text.Equals("")) ? null : txt_desc.Text;
            int myStock = Convert.ToInt32(txt_stock.Text);
            String myLocation = txt_location.Text;
            double myWeight = Convert.ToDouble(txt_weight.Text);
            double purPrice = Convert.ToDouble(txt_purchase.Text);
            double sellPrice = Convert.ToDouble(txt_selling.Text);

            item myItem = new item
            {
                itemID = myItemID,
                name = myName,
                name_ch = myName_ch,
                description = myDesc,
                actualStock = myStock,
                locatedShelf = myLocation,
                weight = myWeight
            };
            Items.ModifyItem(myItem);

            itemprice priceRecord = new itemprice()
            {
                itemID = myItemID,
                purchasePrice = purPrice,
                sellingPrice = sellPrice,
                issueDate = DateTime.Today
            };
            Items.AddPriceRecord(priceRecord);

            //Update item list data
            item updated = itemList.FirstOrDefault(i => i.itemID.Equals(myItemID));
            itemList.Remove(updated);
            itemList.Add(Items.GetItem(myItemID));
            itemList = itemList.OrderBy(i => i.itemID).Select(i => i).ToList();
        }

        private void NewItem()
        {
            String myItemID = txt_itemID.Text;
            String myName = txt_name.Text;
            String myName_ch = (txt_name_ch.Text.Equals("")) ? null : txt_name_ch.Text;
            String myDesc = (txt_desc.Text.Equals("")) ? null : txt_desc.Text;
            int myStock = Convert.ToInt32(txt_stock.Text);
            String myLocation = txt_location.Text;
            String mySupplierID = txt_supplierID.Text;
            double myWeight = Convert.ToDouble(txt_weight.Text);
            double purPrice = Convert.ToDouble(txt_purchase.Text);
            double sellPrice = Convert.ToDouble(txt_selling.Text);


            item myItem = new item
            {
                itemID = myItemID,
                name = myName,
                name_ch = myName_ch,
                description = myDesc,
                orderedAmt = 0,
                actualStock = myStock,
                locatedShelf = myLocation,
                dangerLevel = null,
                reorderLevel = null,
                supplierID = mySupplierID,
                weight = myWeight
            };

            itemprice priceRecord = new itemprice()
            {
                purchasePrice = purPrice,
                sellingPrice = sellPrice,
                issueDate = DateTime.Today
            };
            Items.Add(myItem, priceRecord);

            //Update item list data
            itemList.Add(Items.GetItem(myItemID));
        }

        private void txt_selling_Validating(object sender, CancelEventArgs e)
        {
            CheckSellingPrice();
        }

        private bool CheckSellingPrice()
        {
            if (txt_selling.Text.Equals(""))
            {
                errorProvider1.SetError(txt_selling, "It is a required field.");
                return false;
            }
            else if (!Regex.IsMatch(txt_selling.Text, @"^([0-9]*)|([0-9]*[.][0-9]{1,2})$"))
            {
                errorProvider1.SetError(txt_selling, "Not a valid price.");
                return false;
            }
            else if (!txt_purchase.Text.Equals("") && Convert.ToDouble(txt_purchase.Text) >= Convert.ToDouble(txt_selling.Text)) 
            {
                errorProvider1.SetError(txt_selling, "Selling price should not lower than purchase price.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_selling, "");
                return true;
            }
        }

        private void txt_purchase_Validating(object sender, CancelEventArgs e)
        {
            CheckPurchasePrice();
        }

        private bool CheckPurchasePrice()
        {
            if (txt_purchase.Text.Equals(""))
            {
                errorProvider1.SetError(txt_purchase, "It is a required field.");
                return false;
            }
            else if (!Regex.IsMatch(txt_purchase.Text, @"^([0-9]*)|([0-9]*[.][0-9]{1,2})$"))
            {
                errorProvider1.SetError(txt_purchase, "Not a valid price.");
                return false;
            }
            else 
            {
                errorProvider1.SetError(txt_purchase, "");
                return true;
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            dgv_itemList.DataSource = null;

            String itemID = txt_search_itemID.Text;
            String name = txt_search_Name.Text;

            List<item> result = itemList.Where(i => i.itemID.Contains(itemID) && (i.name.Contains(name) || (i.name_ch != null && i.name_ch.Contains(name)))).Select(i => i).ToList();
            SetItemList(result);
        }

        private void dgv_itemList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txt_itemID.ReadOnly = true;
            ck_undefined.Checked = false;
            txt_supplierID.ReadOnly = true;

            String itemID = dgv_itemList.Rows[e.RowIndex].Cells[0].Value.ToString();
            item modifyingItem = Items.GetItem(itemID);

            txt_itemID.Text = modifyingItem.itemID;
            txt_name.Text = modifyingItem.name;
            txt_name_ch.Text = modifyingItem.name_ch;
            txt_desc.Text = modifyingItem.description;
            txt_selling.Text = Items.GetSellingPrice(itemID, DateTime.Today).ToString();
            txt_purchase.Text = Items.GetPurchasePrice(itemID, DateTime.Today).ToString();
            txt_stock.Text = modifyingItem.actualStock.ToString();
            txt_location.Text = modifyingItem.locatedShelf;
            txt_supplierID.Text = modifyingItem.supplierID;
            txt_weight.Text = modifyingItem.weight.ToString();
        }

        private void link_supplierList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierList p = new SupplierList();
            p.Show();
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
