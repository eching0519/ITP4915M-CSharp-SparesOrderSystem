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
    public partial class DespatchOrder : Form
    {
        user myUser;
        public DespatchOrder(user myUser)
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

        private void PermissionCheck()
        {
            if (myUser.staffID == null)
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }

            staff myStaff = Users.GetStaff(myUser);
            if (!Staffs.isDespatchClerk(myStaff) && !Staffs.isSparePartsController(myStaff))
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void DespatchOrder_Load(object sender, EventArgs e)
        {
            if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.SparePartsController.positionID))
                bt_confirm.Hide();

            var provinceList = Provinces.GetProvinces();
            foreach (var pro in provinceList)
            {
                cbBox_currentJobs_province.Items.Add(pro.province1);
                cbBox_complete_province.Items.Add(pro.province1);
            }

            AddCurrentJob();
            AddCompleteJobs();
        }

        private void AddCurrentJob()
        {
            dgv_currentJob_despatchNotes.Rows.Clear();
            var despatchNotes = DespatchNotes.GetPackedDespatchNotes();
            foreach (despatchnote note in despatchNotes)
            {
                province prov = Provinces.GetProvinceById(note.provinceID);
                dgv_currentJob_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
            }
        }

        private void AddCompleteJobs()
        {
            dgv_complete_despatchNotes.Rows.Clear();
            var despatchNotes = DespatchNotes.GetDeliveredDespatchNotes(Users.GetStaff(myUser));
            foreach (despatchnote note in despatchNotes)
            {
                province prov = Provinces.GetProvinceById(note.provinceID);
                dgv_complete_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
            }
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

        private void cbBox_currentJobs_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCurrentJob();
        }

        private void txt_despatchID_TextChanged(object sender, EventArgs e)
        {
            SearchCurrentJob();
        }

        private void SearchCurrentJob()
        {
            if (cbBox_currentJobs_province.Text.Equals("") && txt_despatchID.Text.Equals(""))
            {
                AddCurrentJob();
            }
            else if (!cbBox_currentJobs_province.Text.Equals("") && txt_despatchID.Text.Equals(""))
            {
                dgv_currentJob_despatchNotes.Rows.Clear();
                province prov = Provinces.GetProvince(cbBox_currentJobs_province.Text);
                var despatchNotes = DespatchNotes.FindPackedDespatchNotes(prov);
                foreach (despatchnote note in despatchNotes)
                {
                    dgv_currentJob_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
                }
            }
            else if (cbBox_currentJobs_province.Text.Equals("") && !txt_despatchID.Text.Equals(""))
            {
                dgv_currentJob_despatchNotes.Rows.Clear();
                var despatchNotes = DespatchNotes.FindPackedDespatchNotes(Convert.ToInt32(txt_despatchID.Text));
                foreach (despatchnote note in despatchNotes)
                {
                    province prov = Provinces.GetProvinceById(note.provinceID);
                    dgv_currentJob_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
                }
            }
            else
            {
                dgv_currentJob_despatchNotes.Rows.Clear();
                province prov = Provinces.GetProvince(cbBox_currentJobs_province.Text);
                var despatchNotes = DespatchNotes.FindPackedDespatchNotes(prov, Convert.ToInt32(txt_despatchID.Text));
                foreach (despatchnote note in despatchNotes)
                {
                    dgv_currentJob_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
                }
            }
        }

        private void SearchCompleteJob()
        {
            if (cbBox_complete_province.Text.Equals("") && txt_complete_despatchID.Text.Equals(""))
            {
                AddCompleteJobs();
            }
            else if (!cbBox_complete_province.Text.Equals("") && txt_complete_despatchID.Text.Equals(""))
            {
                dgv_complete_despatchNotes.Rows.Clear();
                province prov = Provinces.GetProvince(cbBox_complete_province.Text);
                var despatchNotes = DespatchNotes.FindCompletedDespatchNotes(prov);
                foreach (despatchnote note in despatchNotes)
                {
                    dgv_complete_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
                }
            }
            else if (cbBox_complete_province.Text.Equals("") && !txt_complete_despatchID.Text.Equals(""))
            {
                dgv_complete_despatchNotes.Rows.Clear();
                var despatchNotes = DespatchNotes.FindCompletedDespatchNotes(Convert.ToInt32(txt_complete_despatchID.Text));
                foreach (despatchnote note in despatchNotes)
                {
                    province prov = Provinces.GetProvinceById(note.provinceID);
                    dgv_complete_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
                }
            }
            else
            {
                dgv_complete_despatchNotes.Rows.Clear();
                province prov = Provinces.GetProvince(cbBox_currentJobs_province.Text);
                var despatchNotes = DespatchNotes.FindCompletedDespatchNotes(prov, Convert.ToInt32(txt_complete_despatchID.Text));
                foreach (despatchnote note in despatchNotes)
                {
                    dgv_complete_despatchNotes.Rows.Add(prov.province1, note.despatchID, note.deliveryDate);
                }
            }
        }

        private void ClearDespatchNoteDetails()
        {
            gp_currentJob_details.Text = "Despatch Note Details";
            dgv_currentJob_orderList.Rows.Clear();
            dgv_currentJob_ItemList.Rows.Clear();
            lbl_storemenID.Text = "";
            lbl_storemenName.Text = "";
            ClearCurrentOrderDetails();
        }

        private void ClearCompleteDespatchNoteDetails()
        {
            gp_complete_details.Text = "Despatch Note Details";
            dgv_complete_orderList.Rows.Clear();
            dgv_complete_ItemList.Rows.Clear();
            lbl_complete_storemenID.Text = "";
            lbl_complete_storemenName.Text = "";
            lbl_complete_clerkID.Text = "";
            lbl_complete_clerkName.Text = "";
            ClearCompletedOrderDetails();
        }

        private void dgv_currentJob_despatchNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_currentJob_despatchNotes.RowCount <= 0) 
                return;

            ClearDespatchNoteDetails();

            int dn_id = Convert.ToInt32(dgv_currentJob_despatchNotes.CurrentRow.Cells[1].Value);
            despatchnote dn = DespatchNotes.GetDespatchnote(dn_id);
            staff storemen = Staffs.GetStaff(dn.storemen);
            lbl_storemenID.Text = storemen.staffID;
            lbl_storemenName.Text = storemen.name;

            gp_currentJob_details.Text = "Despatch Notes ID: " + dn_id;

            var dOrders = DespatchNotes.GetDespatchOrders(dn_id);

            foreach (order myOrder in dOrders)
            {
                dgv_currentJob_orderList.Rows.Add(myOrder.expDeliverTime, myOrder.orderID, myOrder.weight);
            }
        }

        private void ClearCurrentOrderDetails()
        {
            lbl_currentJob_orderID_display.Text = "";
            dgv_currentJob_ItemList.Rows.Clear();
            txt_invName.Text = "";
            txt_invAdd.Text = "";
            cbBox_recAdd_province.Text = "";
            cbBox_recAdd_city.Text = "";
            txt_recAdd.Text = "";
            txt_dealerID.Text = "";
            txt_dealerName.Text = "";
        }

        private void ClearCompletedOrderDetails()
        {
            lbl_complete_orderID_display.Text = "";
            dgv_complete_ItemList.Rows.Clear();
            txt_complete_invName.Text = "";
            txt_complete_invAdd.Text = "";
            cbBox_complete_recAdd_province.Text = "";
            cbBox_complete_recAdd_city.Text = "";
            txt_complete_recAdd.Text = "";
            txt_complete_dealerID.Text = "";
            txt_complete_dealerName.Text = "";
        }

        private void dgv_currentJob_orderList_SelectionChanged(object sender, EventArgs e)
        {
            ClearCurrentOrderDetails();

            int index = dgv_currentJob_orderList.CurrentCell.RowIndex;

            int oID = Convert.ToInt32(dgv_currentJob_orderList.Rows[index].Cells[1].Value);
            lbl_currentJob_orderID_display.Text = oID.ToString();
            order o = Orders.GetOrder(oID);
            txt_invName.Text = o.invName;
            txt_invAdd.Text = o.invAddress;

            city myCity = Cities.GetCity(o.cityID);
            province myProvince = Cities.GetProvince(myCity);
            cbBox_recAdd_province.Text = myProvince.province1;
            cbBox_recAdd_city.Text = myCity.city1;
            txt_recAdd.Text = o.deliveryAddress;
            txt_dealerID.Text = o.dealerID;
            staff dealer = Staffs.GetStaff(o.dealerID);
            txt_dealerName.Text = dealer.name;

            var orderItems = Orders.GetOrderItemList(o);
            foreach (orderitem details in orderItems)
            {
                item i = Items.GetItem(details.itemID);
                dgv_currentJob_ItemList.Rows.Add(details.itemID, details.qty);
            }
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            if (dgv_currentJob_despatchNotes.RowCount <= 0)
                return;

            DialogResult result = MessageBox.Show("Are you going to deliver this despatch note?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            int dn_id = Convert.ToInt32(dgv_currentJob_despatchNotes.CurrentRow.Cells[1].Value);

            // set order in despatch note to "Delivering"
            DespatchNotes.SetOrdersToDelivering(dn_id, Users.GetStaff(myUser));

            ClearDespatchNoteDetails();

            dgv_currentJob_despatchNotes.Rows.Remove(dgv_currentJob_despatchNotes.CurrentRow);
            AddCompleteJobs();
        }

        private void cbBox_complete_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchCompleteJob();
        }

        private void txt_complete_despatchID_TextChanged(object sender, EventArgs e)
        {
            SearchCompleteJob();
        }

        private void dgv_complete_despatchNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_complete_despatchNotes.SelectedRows == null)
                return;

            ClearCompleteDespatchNoteDetails();

            int dn_id = Convert.ToInt32(dgv_complete_despatchNotes.CurrentRow.Cells[1].Value);
            despatchnote dn = DespatchNotes.GetDespatchnote(dn_id);
            staff storemen = Staffs.GetStaff(dn.storemen);
            lbl_complete_storemenID.Text = storemen.staffID;
            lbl_complete_storemenName.Text = storemen.name;
            staff clerk = Staffs.GetStaff(dn.clerk);
            lbl_complete_clerkID.Text = clerk.staffID;
            lbl_complete_clerkName.Text = clerk.name;

            gp_complete_details.Text = "Despatch Notes ID: " + dn_id;

            var dOrders = DespatchNotes.GetDespatchOrders(dn_id);

            foreach (order myOrder in dOrders)
            {
                dgv_complete_orderList.Rows.Add(myOrder.expDeliverTime, myOrder.orderID, myOrder.weight);
            }
        }

        private void dgv_complete_orderList_SelectionChanged(object sender, EventArgs e)
        {
            ClearCompletedOrderDetails();

            int index = dgv_complete_orderList.CurrentCell.RowIndex;

            int oID = Convert.ToInt32(dgv_complete_orderList.Rows[index].Cells[1].Value);
            lbl_complete_orderID_display.Text = oID.ToString();
            order o = Orders.GetOrder(oID);
            txt_complete_invName.Text = o.invName;
            txt_complete_invAdd.Text = o.invAddress;

            city myCity = Cities.GetCity(o.cityID);
            province myProvince = Cities.GetProvince(myCity);
            cbBox_complete_recAdd_province.Text = myProvince.province1;
            cbBox_complete_recAdd_city.Text = myCity.city1;
            txt_complete_recAdd.Text = o.deliveryAddress;
            txt_complete_dealerID.Text = o.dealerID;
            staff dealer = Staffs.GetStaff(o.dealerID);
            txt_complete_dealerName.Text = dealer.name;

            var orderItems = Orders.GetOrderItemList(o);
            foreach (orderitem details in orderItems)
            {
                item i = Items.GetItem(details.itemID);
                dgv_complete_ItemList.Rows.Add(details.itemID, details.qty);
            }
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

        private void CloseThisPage()
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is HomePage);
            if (formToShow != null)
            {
                formToShow.Show();
            }
            this.Hide();
        }

        
    }
}
