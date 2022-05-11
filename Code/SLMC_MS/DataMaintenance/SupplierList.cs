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
    public partial class SupplierList : Form
    {
        List<supplier> suppliers;
        public SupplierList()
        {
            InitializeComponent();
            suppliers = Suppliers.GetSuppliers();
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            SetSupplierList(suppliers);
        }

        private void SetSupplierList(List<supplier> suppliers)
        {
            dgv_supplierList.Rows.Clear();
            foreach(supplier s in suppliers)
            {
                dgv_supplierList.Rows.Add(s.supplierID, s.name, s.address);
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            String supplierID = txt_supplierID.Text;
            String name = txt_name.Text;
            List<supplier> searchList = suppliers.Where(i => i.supplierID.Contains(supplierID) && i.name.Contains(name)).Select(i => i).ToList();
            SetSupplierList(searchList);
        }
    }
}
