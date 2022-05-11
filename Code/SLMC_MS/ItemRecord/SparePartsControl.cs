using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;
using SLMC_MS.model;
using System.Collections.Generic;

namespace SLMC_MS
{
    
    public partial class SparePartsControl : Form
    {
        user myUser;
        List<item> itemList;

        public SparePartsControl(user myUser)
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
            if (!myUser.username.Equals("admin") && Users.GetStaff(myUser) == null && !Staffs.isSparePartsController(Users.GetStaff(myUser)))
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void SparePartsControl_Load(object sender, EventArgs e)
        {
            itemList = Items.GetItems();
            FillDataGrid();
            ckBox_undefinedLine.Checked = true;
            bt_submit.Enabled = false;
        }

        public void FillDataGrid()
        {
            dgv_SearchingList.Rows.Clear();
            foreach(item note in itemList)
            {
                dgv_SearchingList.Rows.Add(note.itemID, note.name, note.dangerLevel, note.reorderLevel, note.locatedShelf, note.locatedShelf);
            }
        }


        /*search part*/
        private void txt_search_ItemID_TextChanged(object sender, EventArgs e)
        {
            ItemSearch();
        }

        private void txt_search_Name_TextChanged(object sender, EventArgs e)
        {
            ItemSearch();
        }

        private void ckBox_undefinedLine_CheckedChanged(object sender, EventArgs e)
        {
            ItemSearch();
        }

        private void ckBox_undefinedLocation_CheckedChanged(object sender, EventArgs e)
        {
            ItemSearch();
        }

        private void ItemSearch()
        {
            dgv_SearchingList.Rows.Clear();

            String itemID = txt_search_ItemID.Text;
            String itemName = txt_search_Name.Text;
            List<item> searchList = itemList;
            if (ckBox_undefinedLine.Checked)
                searchList = searchList.Where(i => i.dangerLevel == null || i.reorderLevel == null).Select(i => i).ToList();

            if (ckBox_undefinedLocation.Checked)
                searchList = searchList.Where(i => i.locatedShelf.Equals("UNDEF")).Select(i => i).ToList();

            searchList = searchList.Where(i => i.itemID.Contains(itemID) && (i.name.Contains(itemName) || (i.name_ch != null && i.name_ch.Contains(itemName)))).Select(i => i).ToList();
            foreach (item items in searchList)
            {
                dgv_SearchingList.Rows.Add(items.itemID, items.name, items.dangerLevel, items.reorderLevel, items.locatedShelf);
            }
        }

        public Boolean ValidDangerLine()
        {
            if (Regex.IsMatch(txt_DangerLine.Text, @"^\d+$") || txt_DangerLine.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        public Boolean ValidReorderLine()
        {
            if (Regex.IsMatch(txt_ReorderLine.Text, @"^\d+$") || txt_ReorderLine.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private void txt_ItemID_TextChanged(object sender, EventArgs e)
        {
            String itemID = txt_ItemID.Text;
            item item = Items.GetItem(itemID);
            if (item != null)
            {
                txt_name.Text = item.name;
                txt_name_ch.Text = item.name_ch;
                txt_DangerLine.Text = item.dangerLevel.ToString();
                txt_ReorderLine.Text = item.reorderLevel.ToString();
                txt_location.Text = item.locatedShelf.Equals("UNDEF") ? null : item.locatedShelf;
                bt_submit.Enabled = true;
            }
            else
            {
                txt_name.Clear();
                txt_name_ch.Clear();
                txt_DangerLine.Clear();
                txt_ReorderLine.Clear();
                txt_location.Clear();
                bt_submit.Enabled = false;
            }
        }

        private bool ValidDangerLineAndReorderLine()
        {
            if (txt_DangerLine.Text.Equals("") || txt_ReorderLine.Text.Equals(""))
            {
                if (txt_DangerLine.Text.Equals(""))
                    errorProvider.SetError(txt_DangerLine, "Danger line should not be null.");

                if (txt_ReorderLine.Text.Equals(""))
                    errorProvider.SetError(txt_ReorderLine, "Reorder line should not be null.");

                return false;
            }
            else if (!Regex.IsMatch(txt_DangerLine.Text, @"^\d+$") || !Regex.IsMatch(txt_ReorderLine.Text, @"^\d+$"))
            {
                if (!Regex.IsMatch(txt_DangerLine.Text, @"^\d+$"))
                    errorProvider.SetError(txt_DangerLine, "Invalid number.");

                if (!Regex.IsMatch(txt_ReorderLine.Text, @"^\d+$"))
                    errorProvider.SetError(txt_ReorderLine, "Invalid number.");

                return false;
            }
            else if (Convert.ToInt32(txt_DangerLine.Text) > Convert.ToInt32(txt_ReorderLine.Text))
            {
                errorProvider.SetError(txt_DangerLine, "Danger line should not greater than reorder line.");
                return false;
            }
            else
            {
                errorProvider.SetError(txt_DangerLine, "");
                errorProvider.SetError(txt_ReorderLine, "");
                return true;
            }
        }

        private bool ValidLocation()
        {
            if (txt_location.Text.Equals(""))
            {
                errorProvider.SetError(txt_location, "It is a required field.");
                return false;
            }
            else if (!Regex.IsMatch(txt_location.Text, @"^([ABCD][A-Z][0-9]{3})$")) 
            {
                errorProvider.SetError(txt_location, "Please enter a valid location with 2 characters follow with 3 decimal numbers.");
                return false;
            }
            errorProvider.SetError(txt_location, "");
            return true;
        }

        private void dgv_SearchingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txt_ItemID.Text = dgv_SearchingList.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (ValidDangerLineAndReorderLine() & ValidLocation())
            {
                int dangerQty = Convert.ToInt32(txt_DangerLine.Text);
                int reorderQty = Convert.ToInt32(txt_ReorderLine.Text);
                String location = txt_location.Text;
                String itemID = txt_ItemID.Text.ToString();
                Items.SetDangerLine(itemID, dangerQty);
                Items.SetReorderLine(itemID, reorderQty);
                Items.SetLocatedShelf(itemID, location);
                MessageBox.Show("Information is saved.", "Success");

                item updated = itemList.FirstOrDefault(i => i.itemID.Equals(itemID));
                itemList.Remove(updated);
                itemList.Add(Items.GetItem(itemID));
                itemList = itemList.OrderBy(i => i.itemID).Select(i => i).ToList();
                ItemSearch();
            }
            else
            {
                MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txt_ItemID.Clear();
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
