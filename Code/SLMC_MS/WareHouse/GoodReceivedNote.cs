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

    public partial class GoodReceivedNote : Form
    {
        List<supplier> suppliers;
        List<item> supplierItems;
        int noteID;

        AutoCompleteStringCollection supplierIDs;
        AutoCompleteStringCollection supplierNames;
        AutoCompleteStringCollection itemIDs;

        int editValue;

        public GoodReceivedNote()
        {
            InitializeComponent();
            suppliers = Suppliers.GetSuppliers();
            supplierItems = null;
            noteID = 0;

            supplierIDs = new AutoCompleteStringCollection();
            supplierNames = new AutoCompleteStringCollection();
            
            itemIDs = new AutoCompleteStringCollection();
        }

        public GoodReceivedNote(int noteID)
        {
            InitializeComponent();
            suppliers = Suppliers.GetSuppliers();
            supplierItems = null;
            this.noteID = noteID;

            supplierIDs = new AutoCompleteStringCollection();
            supplierNames = new AutoCompleteStringCollection();
            itemIDs = new AutoCompleteStringCollection();

            bt_create.Visible = false;
            bt_clear.Visible = false;

            goodsreceivenote note = GoodsReceivedNotes.GetGRN(noteID);
            txt_supplierID.Text = note.supplierID;
            StartNewNotes();


            InsertItemList(GoodsReceivedNotes.GetGRNitems(note.noteID));
        }

        private void GoodReceivedNote_Load(object sender, EventArgs e)
        {
            foreach(supplier s in suppliers)
            {
                supplierIDs.Add(s.supplierID);
                supplierNames.Add(s.name);
            }

            txt_supplierID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_supplierID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_supplierID.AutoCompleteCustomSource = supplierIDs;

            txt_supplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_supplier.AutoCompleteCustomSource = supplierNames;

            txt_ItemID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_ItemID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_ItemID.AutoCompleteCustomSource = itemIDs;
        }

        public bool ValidQty()
        {
            if (Regex.IsMatch(txt_qty.Text, @"^\d+$"))
            {
                return true;
            }
            return false;
        }

        private void txt_supplierID_TextChanged(object sender, EventArgs e)
        {
            supplier s = suppliers.FirstOrDefault(i => i.supplierID.Equals(txt_supplierID.Text));
            if (s == null)
            {
                errorProvider1.SetError(txt_supplierID, "Invalid supplier ID.");
            }
            else
            {
                errorProvider1.Clear();
                if (txt_supplierID.ReadOnly != true)
                    txt_supplier.ReadOnly = true;
                txt_supplier.Text = s.name;
            }
        }

        private void txt_supplier_TextChanged(object sender, EventArgs e)
        {
            supplier s = suppliers.FirstOrDefault(i => i.name.Equals(txt_supplier.Text));
            if (s == null)
            {
                errorProvider1.SetError(txt_supplier, "Invalid supplier.");
            }
            else
            {
                errorProvider1.Clear();
                if (txt_supplier.ReadOnly != true)
                    txt_supplierID.ReadOnly = true;
                txt_supplierID.Text = s.supplierID;
            }
        }

        private void DisableControl()
        {
            dgv_itemList.Enabled = false;
            bt_submit.Enabled = false;
            bt_add.Enabled = false;
            txt_ItemID.ReadOnly = true;
            txt_qty.ReadOnly = true;
        }

        private void EnableControl()
        {
            dgv_itemList.Enabled = true;
            bt_submit.Enabled = false;
            txt_ItemID.ReadOnly = false;
            txt_qty.ReadOnly = false;
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            StartNewNotes();
        }

        private void StartNewNotes()
        {
            if (!txt_supplierID.Text.Equals("") && !txt_supplier.Text.Equals("") &&
                  errorProvider1.GetError(txt_supplierID).Equals("") && errorProvider1.GetError(txt_supplier).Equals(""))
            {
                EnableControl();
                txt_supplierID.ReadOnly = true;
                txt_supplier.ReadOnly = true;
                bt_create.Enabled = false;

                // Set up auto String
                if (supplierItems != null)
                    supplierItems.Clear();
                itemIDs.Clear();

                supplierItems = Suppliers.GetItems(txt_supplierID.Text);
                foreach (item i in supplierItems)
                {
                    itemIDs.Add(i.itemID);
                }
            }
            else
            {
                DisableControl();
                MessageBox.Show("Invalid supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertItemList(List<goodsreceiveitem> goodsreceiveitems)
        {
            foreach (goodsreceiveitem i in goodsreceiveitems)
            {
                item item = Items.GetItem(i.itemID);
                dgv_itemList.Rows.Add(i.itemID, item.name, i.qty, "Delete");
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_supplier.ReadOnly = false;
            txt_supplier.Clear();
            txt_supplierID.ReadOnly = false;
            txt_supplierID.Clear();
            bt_create.Enabled = true;
            DisableControl();
            dgv_itemList.Rows.Clear();
            txt_ItemID.Clear();
            txt_qty.Clear();
            errorProvider1.Clear();
        }

        private void txt_ItemID_TextChanged(object sender, EventArgs e)
        {
            String itemID = txt_ItemID.Text;
            item i = supplierItems.FirstOrDefault(n => n.itemID.Equals(itemID));
            if(i==null)
            {
                txt_Name.Clear();
                txt_description.Clear();
                bt_add.Enabled = false;
                errorProvider1.SetError(txt_ItemID, "Invalid item ID.");
            }
            else
            {
                txt_Name.Text = i.name;
                txt_description.Text = i.description;
                if (!txt_qty.Text.Equals("") && errorProvider1.GetError(txt_qty).Equals(""))
                    bt_add.Enabled = true;
                else
                    bt_add.Enabled = false;
                errorProvider1.SetError(txt_ItemID, "");
            }
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_qty.Text, @"^\d+$"))
            {
                errorProvider1.SetError(txt_qty, "Invalid quantity.");
                bt_add.Enabled = false;
            }
            else if(Convert.ToInt32(txt_qty.Text)<=0)
            {
                errorProvider1.SetError(txt_qty, "Invalid quantity.");
                bt_add.Enabled = false;
            }
            else
            {
                if (!txt_ItemID.Text.Equals("") && errorProvider1.GetError(txt_ItemID).Equals(""))
                    bt_add.Enabled = true;
                else
                    bt_add.Enabled = false;
                errorProvider1.SetError(txt_qty, "");
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            String itemID = txt_ItemID.Text;
            String itemName = txt_Name.Text;
            int qty = Convert.ToInt32(txt_qty.Text);

            bool isExist = false;
            foreach (DataGridViewRow row in dgv_itemList.Rows)
            {
                if(row.Cells[0].Value.ToString().Equals(itemID))
                {
                    row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + qty;
                    isExist = true;
                }
            }
            if (!isExist)
                dgv_itemList.Rows.Add(itemID, itemName, qty, "Delete");

            txt_ItemID.Clear();
            txt_qty.Clear();
            errorProvider1.Clear();
        }

        private void dgv_itemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 3)
                return;

            dgv_itemList.Rows.RemoveAt(e.RowIndex);
        }

        private void dgv_itemList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (!Regex.IsMatch(dgv_itemList.Rows[e.RowIndex].Cells[2].Value.ToString(), @"^\d+$"))
            {
                dgv_itemList.Rows[e.RowIndex].Cells[2].Value = editValue;
            }
            else if (Convert.ToInt32(dgv_itemList.Rows[e.RowIndex].Cells[2].Value) <= 0)
            {
                dgv_itemList.Rows[e.RowIndex].Cells[2].Value = editValue;
            }
        }

        private void dgv_itemList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgv_itemList.Rows.Count <= 0)
                bt_submit.Enabled = false;
            else
                bt_submit.Enabled = true;
        }

        private void dgv_itemList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgv_itemList.Rows.Count <= 0)
                bt_submit.Enabled = false;
            else
                bt_submit.Enabled = true;
        }

        private void dgv_itemList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            editValue = Convert.ToInt32(dgv_itemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (dgv_itemList.Rows.Count <= 0)
                return;

            List<goodsreceiveitem> goodsreceiveitems = new List<goodsreceiveitem>();
            foreach(DataGridViewRow row in dgv_itemList.Rows)
            {
                String itemID = row.Cells[0].Value.ToString();
                int qty = Convert.ToInt32(row.Cells[2].Value);
                goodsreceiveitem g = new goodsreceiveitem
                {
                    itemID = itemID,
                    qty = qty
                };
                goodsreceiveitems.Add(g);
            }

            goodsreceivenote n = new goodsreceivenote
            {
                supplierID = txt_supplierID.Text,
                inwardDate = DateTime.Today,
                confirmed = "N"
            };

            if (bt_create.Visible == true)
            {
                GoodsReceivedNotes.Add(n, goodsreceiveitems);
                MessageBox.Show("GRN is created", "Success");
                ClearForm();
            }
            else
            {
                GoodsReceivedNotes.Update(noteID, goodsreceiveitems);
                MessageBox.Show("GRN is updated", "Success");
                CloseThisPage();
            }

            
        }

        private void picBox_return_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void CloseThisPage()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is GoodsReceivedNoteHandling);
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
