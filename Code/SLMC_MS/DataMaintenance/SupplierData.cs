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
    public partial class SupplierData : Form
    {
        user myUser;
        List<supplier> suppliers;

        public SupplierData(user myUser)
        {
            this.myUser = myUser;
            if (!myUser.username.Equals("admin"))
                throw new PermissionDeniedException();

            InitializeComponent();
            suppliers = Suppliers.GetSuppliers();
        }

        private void SupplierData_Load(object sender, EventArgs e)
        {
            SetSupplierData(suppliers);
        }

        private void SetSupplierData(List<supplier> suppliers)
        {
            dgv_supplierList.Rows.Clear();
            foreach(supplier s in suppliers)
            {
                dgv_supplierList.Rows.Add(s.supplierID, s.name, s.address);
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            String supplierID = txt_search_supplierID.Text;
            String name = txt_search_name.Text;
            List<supplier> searchList = suppliers.Where(i => i.supplierID.Contains(supplierID) && i.name.Contains(name)).Select(i => i).ToList();
            SetSupplierData(searchList);
        }

        private bool ValidSupplierID()
        {
            if (!Regex.IsMatch(txt_supplierID.Text, @"^\d{4}$"))
            {
                errorProvider.SetError(txt_supplierID, "Supplier ID should be 4-digit.");
                return false;
            }
            else
            {
                errorProvider.SetError(txt_supplierID, "");
                return true;
            }
        }

        private bool ValidSupplier()
        {
            if(txt_supplier.Text.Equals(""))
            {
                errorProvider.SetError(txt_supplier, "Supplier name is required.");
                return false;
            }
            else
            {
                errorProvider.SetError(txt_supplier, "");
                return true;
            }
        }

        private bool ValidAddress()
        {
            if (txt_supAdd.Text.Equals(""))
            {
                errorProvider.SetError(txt_supAdd, "Supplier address is required.");
                return false;
            }
            else
            {
                errorProvider.SetError(txt_supAdd, "");
                return true;
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txt_supplierID.Clear();
            txt_supplier.Clear();
            txt_supAdd.Clear();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (ValidSupplierID() & ValidSupplier() & ValidAddress()) 
            {
                String supplierID = txt_supplierID.Text;
                supplier supplier = Suppliers.GetSupplier(supplierID);
                if (supplier == null) 
                {
                    supplier s = new supplier
                    {
                        supplierID = supplierID,
                        name = txt_supplier.Text,
                        address = txt_supAdd.Text
                    };
                    Suppliers.Add(s);
                    MessageBox.Show("Supplier is added.", "Success");
                }
                else
                {
                    Suppliers.SetName(supplierID, txt_supplier.Text);
                    Suppliers.SetAddress(supplierID, txt_supAdd.Text);
                    MessageBox.Show("Supplier is modified.", "Success");
                }
                suppliers = Suppliers.GetSuppliers();
                SetSupplierData(suppliers);
            }
            else
            {
                MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_supplierID_TextChanged(object sender, EventArgs e)
        {
            supplier supplier = Suppliers.GetSupplier(txt_supplierID.Text);
            if (supplier != null) 
            {
                txt_supplier.Text = supplier.name;
                txt_supAdd.Text = supplier.address;
            }
        }

        private void dgv_supplierList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txt_supplierID.Text = dgv_supplierList.Rows[e.RowIndex].Cells[0].Value.ToString();
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
