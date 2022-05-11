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
    
    public partial class GoodsReceivingConfirmation : Form
    {
        user myUser;
        List<goodsreceivenote> goodsreceivenotesList;

        Point PanelMouseDownLocation;

        public GoodsReceivingConfirmation(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();
        }

        private void GoodsReceivingConfirmation_Load(object sender, EventArgs e)
        {
            goodsreceivenotesList = GoodsReceivedNotes.GetGRNs();

            UpdateGRNList();
        }

        private void UpdateGRNList()
        {
            dgv_GRNList.Rows.Clear();
            goodsreceivenotesList = goodsreceivenotesList.OrderByDescending(i => i.inwardDate).OrderByDescending(i => i.confirmed).ToList();

            foreach (goodsreceivenote grn in goodsreceivenotesList)
            {
                supplier s = Suppliers.GetSupplier(grn.supplierID);
                String status = "";
                if (grn.confirmed.Equals("Y"))
                    status = "Confirmed";
                else if (grn.confirmed.Equals("N"))
                    status = "Unconfirmed";
                else
                    status = "Rejected";

                dgv_GRNList.Rows.Add(grn.noteID, grn.inwardDate, grn.supplierID, s.name, status);
            }
        }

        private void dgv_GRNList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            panel_grnDetails.Visible = false;   // reset value in the panel

            panel_grnDetails.Visible = true;
            panel_grnDetails.Location = new Point(75, 38);
            int noteID = Convert.ToInt32(dgv_GRNList.Rows[e.RowIndex].Cells[0].Value);
            SetGRNDetails(noteID);
        }

        private void SetGRNDetails(int noteID)
        {
            lbl_noteID.Text = noteID.ToString();
            goodsreceivenote note = GoodsReceivedNotes.GetGRN(noteID);

            if(!note.confirmed.Equals("N"))
            {
                bt_reject.Visible = false;
                bt_confirm.Visible = false;
            }
            else
            {
                bt_reject.Visible = true;
                bt_confirm.Visible = true;
            }

            List<goodsreceiveitem> goodsreceiveitems = GoodsReceivedNotes.GetGRNitems(noteID);
            supplier s = Suppliers.GetSupplier(note.supplierID);

            txt_supplierID.Text = note.supplierID;
            txt_supplier.Text = s.name;
            txt_inwardDate.Text = note.inwardDate.ToLongDateString();

            foreach(goodsreceiveitem grnItem in goodsreceiveitems)
            {
                item i = Items.GetItem(grnItem.itemID);
                dgv_itemList.Rows.Add(grnItem.itemID, i.name, grnItem.qty);
            }
        }

        private void panel_grnDetails_VisibleChanged(object sender, EventArgs e)
        {
            txt_supplierID.Clear();
            txt_supplier.Clear();
            txt_inwardDate.Clear();
            dgv_itemList.Rows.Clear();
            lbl_noteID.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel_grnDetails.Visible = false;
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Is this GRN confirmed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.No))
                return;

            int noteID = Convert.ToInt32(lbl_noteID.Text);
            GoodsReceivedNotes.Confirm(noteID);

            panel_grnDetails.Visible = false;
            goodsreceivenotesList = GoodsReceivedNotes.GetGRNs();
            UpdateGRNList();
        }

        private void bt_reject_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reject this GRN?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.No))
                return;

            int noteID = Convert.ToInt32(lbl_noteID.Text);
            GoodsReceivedNotes.Reject(noteID);

            panel_grnDetails.Visible = false;
            goodsreceivenotesList = GoodsReceivedNotes.GetGRNs();
            UpdateGRNList();
        }

        private void panel_grnDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {
                panel_grnDetails.Left += e.X - PanelMouseDownLocation.X;
                panel_grnDetails.Top += e.Y - PanelMouseDownLocation.Y;
            }
        }

        private void panel_grnDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
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
