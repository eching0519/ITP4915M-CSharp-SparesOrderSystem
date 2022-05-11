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
    public partial class PackingOrder : Form
    {
        user myUser;
        public PackingOrder(user myUser)
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

        private void PackingOrder_Load(object sender, EventArgs e)
        {
            var provinces = Provinces.GetProvinces();
            foreach(province p in provinces)
            {
                cbBox_pending_province.Items.Add(p.province1);
            }

            SetJobList();
            SetCompleteList();
            
        }

        private void PermissionCheck()
        {
            if (myUser.staffID == null)
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }

            staff myStaff = Users.GetStaff(myUser);
            if (!Staffs.isStoremen(myStaff))
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void ClearPendingDespatchNoteDetails()
        {
            gp_pending_details.Text = "Despatch Note Details";
            dgv_pending_orderList.Rows.Clear();
            lbl_pending_orderID_display.Text = "";
            dgv_pending_ItemList.Rows.Clear();
        }

        private void ClearCurrentJobsDespatchNoteDetails()
        {
            gp_currentJob_details.Text = "Despatch Note Details";
            dgv_currentJob_orderList.Rows.Clear();
            lbl_currentJob_orderID_display.Text = "";
            dgv_currentJob_ItemList.Rows.Clear();
        }

        private void ClearCompleteDespatchNoteDetails()
        {
            gp_complete_details.Text = "Despatch Note Details";
            dgv_complete_orderList.Rows.Clear();
            lbl_complete_orderID_display.Text = "";
            dgv_complete_ItemList.Rows.Clear();
        }

        private void cbBox_pending_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_pending_despatchNotes.Rows.Clear();

            ClearPendingDespatchNoteDetails();

            province prov = Provinces.GetProvince(cbBox_pending_province.Text);
            var despatchNoteList = DespatchNotes.GetPendingDespatchNotes(prov);
            foreach (despatchnote dn in despatchNoteList)
            {
                dgv_pending_despatchNotes.Rows.Add("ID:", dn.despatchID, dn.deliveryDate);
            }
        }

        private void dgv_pending_orderList_SelectionChanged(object sender, EventArgs e)
        {
            lbl_pending_orderID_display.Text = "";
            dgv_pending_ItemList.Rows.Clear();

            int index = dgv_pending_orderList.CurrentCell.RowIndex;

            int oID = Convert.ToInt32(dgv_pending_orderList.Rows[index].Cells[1].Value);
            lbl_pending_orderID_display.Text = oID.ToString();
            order o = Orders.GetOrder(oID);
            var orderItems = Orders.GetOrderItemList(o);

            foreach (orderitem details in orderItems)
            {
                item i = Items.GetItem(details.itemID);
                dgv_pending_ItemList.Rows.Add(details.itemID, details.qty, i.actualStock, i.locatedShelf);
            }
        }

        private void bt_pending_addJob_Click(object sender, EventArgs e)
        {
            ClearPendingDespatchNoteDetails();

            if (dgv_pending_despatchNotes.RowCount <= 0) 
                return;

            int dn_id = Convert.ToInt32(dgv_pending_despatchNotes.CurrentRow.Cells[1].Value);

            DespatchNotes.SetStoremen(dn_id, Users.GetStaff(myUser));


            dgv_pending_despatchNotes.Rows.Remove(dgv_pending_despatchNotes.CurrentRow);
            SetJobList();
        }

        private void SetJobList()
        {
            dgv_currentJob_despatchNotes.Rows.Clear();

            using (slmc db = new slmc())
            {
                // Fill the job list
                staff storemen = Users.GetStaff(myUser);
                var despatchNoteList = DespatchNotes.GetUnpackedDespatchNotes(storemen);
                foreach (despatchnote dn in despatchNoteList.ToList())
                {
                    dgv_currentJob_despatchNotes.Rows.Add("ID:", dn.despatchID, dn.deliveryDate);
                }
            }
        }

        private void SetCompleteList()
        {
            dgv_complete_despatchNotes.Rows.Clear();

            using (slmc db = new slmc())
            {
                // Fill the job list
                staff storemen = Users.GetStaff(myUser);
                var despatchNoteList = DespatchNotes.GetPackedDespatchNotes(storemen);
                foreach (despatchnote dn in despatchNoteList.ToList())
                {
                    dgv_complete_despatchNotes.Rows.Add("ID:", dn.despatchID, dn.deliveryDate);
                }
            }
        }

        private void dgv_currentJob_orderList_SelectionChanged(object sender, EventArgs e)
        {
            lbl_currentJob_orderID_display.Text = "";
            dgv_currentJob_ItemList.Rows.Clear();

            int index = dgv_currentJob_orderList.CurrentCell.RowIndex;

            int oID = Convert.ToInt32(dgv_currentJob_orderList.Rows[index].Cells[1].Value);
            lbl_currentJob_orderID_display.Text = oID.ToString();
            order o = Orders.GetOrder(oID);
            var orderItems = Orders.GetOrderItemList(o);

            foreach (orderitem details in orderItems)
            {
                item i = Items.GetItem(details.itemID);
                dgv_currentJob_ItemList.Rows.Add(details.itemID, details.qty, i.actualStock, i.locatedShelf);
            }
        }

        private void dgv_complete_orderList_SelectionChanged(object sender, EventArgs e)
        {
            lbl_complete_orderID_display.Text = "";
            dgv_complete_ItemList.Rows.Clear();

            int index = dgv_complete_orderList.CurrentCell.RowIndex;

            int oID = Convert.ToInt32(dgv_complete_orderList.Rows[index].Cells[1].Value);
            lbl_complete_orderID_display.Text = oID.ToString();
            order o = Orders.GetOrder(oID);
            var orderItems = Orders.GetOrderItemList(o);

            foreach (orderitem details in orderItems)
            {
                item i = Items.GetItem(details.itemID);
                dgv_complete_ItemList.Rows.Add(details.itemID, details.qty, i.actualStock, i.locatedShelf);
            }
        }

        private void bt_currentJob_packed_Click(object sender, EventArgs e)
        {
            if (dgv_currentJob_despatchNotes.RowCount <= 0)
                return;

            DialogResult result = MessageBox.Show("Are you sure this despatch note is packed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            ClearCurrentJobsDespatchNoteDetails();

            int dn_id = Convert.ToInt32(dgv_currentJob_despatchNotes.CurrentRow.Cells[1].Value);

            DespatchNotes.Packed(dn_id);

            dgv_currentJob_despatchNotes.Rows.Remove(dgv_currentJob_despatchNotes.CurrentRow);
            SetCompleteList();
        }

        private void listBox_complete_despatchNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgv_currentJob_despatchNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_currentJob_despatchNotes.RowCount <= 0)
                return;

            if (dgv_currentJob_despatchNotes.SelectedRows == null)
                return;

            ClearCurrentJobsDespatchNoteDetails();

            if (dgv_currentJob_despatchNotes.RowCount <= 0)
                return;

            int dn_id = Convert.ToInt32(dgv_currentJob_despatchNotes.CurrentRow.Cells[1].Value);

            gp_currentJob_details.Text = "Despatch Notes ID: " + dn_id;

            var dOrders = DespatchNotes.GetDespatchOrders(dn_id);

            foreach (order myOrder in dOrders)
            {
                dgv_currentJob_orderList.Rows.Add(myOrder.expDeliverTime, myOrder.orderID, myOrder.weight);
            }
        }

        private void dgv_pending_despatchNotes_SelectionChanged(object sender, EventArgs e)
        {
            ClearPendingDespatchNoteDetails();

            if (dgv_pending_despatchNotes.RowCount <= 0) 
                return;

            if (dgv_pending_despatchNotes.SelectedRows.Count <= 0) 
                return;

            int dn_id = Convert.ToInt32(dgv_pending_despatchNotes.SelectedRows[0].Cells[1].Value);

            gp_pending_details.Text = "Despatch Notes ID: " + dn_id;

            var dOrders = DespatchNotes.GetDespatchOrders(dn_id);

            foreach (order myOrder in dOrders)
            {
                dgv_pending_orderList.Rows.Add(myOrder.expDeliverTime, myOrder.orderID, myOrder.weight);
            }

            dgv_pending_orderList.Rows[0].Selected = true;
        }

        private void dgv_complete_despatchNotes_SelectionChanged(object sender, EventArgs e)
        {
            ClearCompleteDespatchNoteDetails();

            if (dgv_complete_despatchNotes.RowCount <= 0)
                return;

            if (dgv_complete_despatchNotes.SelectedRows == null)
                return;

            int dn_id = Convert.ToInt32(dgv_complete_despatchNotes.CurrentRow.Cells[1].Value);

            gp_complete_details.Text = "Despatch Notes ID: " + dn_id;

            var dOrders = DespatchNotes.GetDespatchOrders(dn_id);

            foreach (order myOrder in dOrders)
            {
                dgv_complete_orderList.Rows.Add(myOrder.expDeliverTime, myOrder.orderID, myOrder.weight);
            }
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

        private void dgv_currentJob_despatchNotes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (Convert.ToDateTime(dgv_currentJob_despatchNotes.Rows[e.RowIndex].Cells[2].Value) < DateTime.Today)
            {
                dgv_currentJob_despatchNotes.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                dgv_currentJob_despatchNotes.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv_currentJob_despatchNotes.Rows[e.RowIndex].DataGridView.Font, FontStyle.Bold);
                dgv_currentJob_despatchNotes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }

            dgv_currentJob_despatchNotes.Sort(dgv_currentJob_despatchNotes.Columns[2], ListSortDirection.Ascending);
        }

        private void dgv_pending_despatchNotes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (Convert.ToDateTime(dgv_pending_despatchNotes.Rows[e.RowIndex].Cells[2].Value) < DateTime.Today)
            {
                dgv_pending_despatchNotes.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                dgv_pending_despatchNotes.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv_pending_despatchNotes.Rows[e.RowIndex].DataGridView.Font, FontStyle.Bold);
                dgv_pending_despatchNotes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }

            dgv_pending_despatchNotes.Sort(dgv_pending_despatchNotes.Columns[2], ListSortDirection.Ascending);
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
