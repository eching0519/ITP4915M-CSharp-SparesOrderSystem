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

    public partial class HomePage : Form
    {
        user myUser;

        Point PanelMouseDownLocation;

        public HomePage(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();

            if(myUser.username.Equals("admin"))
            {
                SetAdmin();
            }
            else if(myUser.username.Equals("hr"))
            {
                SetHR();
            }
            else if(Users.GetStaff(myUser).positionID.Equals(StaffPosition.SalesManager.positionID))
            {
                SetSalesMan();
            }
            else if(Users.GetStaff(myUser).positionID.Equals(StaffPosition.AreaManager.positionID))
            {
                SetAreaMan();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.SalesOrderOfficeManager.positionID))
            {
                SetSalesOrderMan();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.Dealer.positionID))
            {
                SetDealer();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.SalesOrderOfficer.positionID))
            {
                SetSalesOrderOfficer();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.SparePartsController.positionID))
            {
                SetSparePartsController();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.DespatchClerk.positionID))
            {
                SetDespatchClerk();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.Storemen.positionID))
            {
                SetStoremen();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.StockRecordsClerk.positionID))
            {
                SetStockRecords();
            }
            else if (Users.GetStaff(myUser).positionID.Equals(StaffPosition.GoodsInwardsClerk.positionID))
            {
                SetGoodsInwardsClerk();
            }

            if(lblLink_repenishStock.Visible)
            {
                if (Items.hasReorderItem())
                {
                    ErrorProvider errorProvider = new ErrorProvider();
                    errorProvider.SetError(lblLink_repenishStock,"Insufficient Stock");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void UpdateMsgs()
        {
            dgv_msg.Rows.Clear();
            List<broadcastmsg> msgs = BroadcastMsgs.GetUnreadedMsgs(myUser.staffID).OrderByDescending(i => i.deliveryDate).ToList();

            foreach(broadcastmsg msg in msgs)
            {
                dgv_msg.Rows.Add(msg.msgID, Staffs.GetStaffName(msg.senderID), msg.title, msg.deliveryDate);
            }
            foreach(DataGridViewRow row in dgv_msg.Rows)
            {
                row.DefaultCellStyle.Font = new Font(row.DataGridView.Font, FontStyle.Bold);
            }

            msgs = BroadcastMsgs.GetReadedMsgs(myUser.staffID);
            foreach (broadcastmsg msg in msgs)
            {
                dgv_msg.Rows.Add(msg.msgID, Staffs.GetStaffName(msg.senderID), msg.title, msg.deliveryDate);
            }
        }

        private void SetSalesMan()
        {
            picBox_msg.Show();
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_saleOverview.Show();
            flowLayoutPanel_saleOverview.Size = new Size(180, 426);
            lblLink_overview_salesArea.Show();
            lblLink_overview_item.Show();

            panel_msg.Show();
        }

        private void SetAreaMan()
        {
            picBox_msg.Show();
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_saleOverview.Show();
            flowLayoutPanel_saleOverview.Size = new Size(180, 426);
            lblLink_overview_item.Show();

            panel_msg.Show();
        }

        private void SetSalesOrderMan()
        {
            picBox_msg.Show();
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_saleOverview.Show();
            flowLayoutPanel_saleOverview.Size = new Size(180, 426);
            lblLink_overview_salesArea.Show();
            lblLink_overview_item.Show();

            flowLayoutPanel_goods.Show();
            flowLayoutPanel_goods.Size = new Size(180, 426);
            lblLink_repenishStock.Show();

            panel_msg.Show();
        }

        private void SetDealer()
        {
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_order.Show();
            flowLayoutPanel_order.Size = new Size(180, 426);
            lblLink_newOrder.Show();
            lblLink_orderHistory.Show();

            flowLayoutPanel_itemRecord.Show();
            flowLayoutPanel_itemRecord.Size = new Size(180, 426);
            lblLink_reserveItem.Show();

            panel_msg.Show();
        }

        private void SetSalesOrderOfficer()
        {
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_order.Show();
            flowLayoutPanel_order.Size = new Size(180, 426);
            lblLink_newOrder.Show();
            lblLink_orderAssembly.Show();

            panel_msg.Show();
        }

        private void SetSparePartsController()
        {
            picBox_msg.Show();
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_itemRecord.Show();
            lblLink_partsControl.Show();

            flowLayoutPanel_goods.Show();
            lblLink_repenishStock.Show();

            flowLayoutPanel_order.Show();
            lblLink_despatchJobs.Show();

            flowLayoutPanel_saleOverview.Show();
            lblLink_overview_item.Show();

            panel_msg.Show();
        }

        private void SetDespatchClerk()
        {
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_order.Show();
            flowLayoutPanel_order.Size = new Size(180, 426);
            lblLink_despatchJobs.Show();

            panel_msg.Show();
        }

        private void SetStoremen()
        {
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_order.Show();
            flowLayoutPanel_order.Size = new Size(180, 426);
            lblLink_orderPacking.Show();

            flowLayoutPanel_goods.Show();
            flowLayoutPanel_goods.Size = new Size(180, 426);
            lblLink_viewGRN.Show();

            panel_msg.Show();
        }

        private void SetStockRecords()
        {
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_itemRecord.Show();
            flowLayoutPanel_itemRecord.Size = new Size(180, 426);
            lblLink_modifyItem.Show();

            flowLayoutPanel_goods.Show();
            flowLayoutPanel_goods.Size = new Size(180, 426);

            panel_msg.Show();
        }

        private void SetGoodsInwardsClerk()
        {
            picBox_itemSearch.Show();
            picBox_passwordReset.Show();
            picBox_infoUpdate.Show();

            flowLayoutPanel_goods.Show();
            flowLayoutPanel_goods.Size = new Size(180, 426);
            lblLink_createGRN.Show();

            this.Size = new Size(623, 491);
        }

        private void SetHR()
        {
            picBox_passwordReset.Show();

            flowLayoutPanel_DataMaintenance.Show();
            flowLayoutPanel_DataMaintenance.Size = new Size(180, 426);
            lblLink_data_staff.Show();
            lblLink_data_team.Show();

            this.Size = new Size(623, 491);
        }

        private void SetAdmin()
        {
            picBox_itemSearch.Show();
            picBox_orderSearch.Show();
            //picBox_passwordReset.Show();
            flowLayoutPanel_itemRecord.Show();
            flowLayoutPanel_itemRecord.Size = new Size(180, 426);
            lblLink_modifyItem.Show();
            lblLink_partsControl.Show();

            flowLayoutPanel_DataMaintenance.Show();
            flowLayoutPanel_DataMaintenance.Size = new Size(180, 426);
            lblLink_data_user.Show();
            lblLink_data_staff.Show();
            lblLink_data_supplier.Show();
            lblLink_data_team.Show();

            this.Size = new Size(623, 491);
        }

        private void lblLink_newOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CreateOrder co = new CreateOrder(myUser);
                co.Show();
                this.Hide();
            } catch(PermissionDeniedException exc) { }
        }

        private void lblLink_orderHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OrderHistory oh = new OrderHistory(myUser);
                oh.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_assembleOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ProcessOrder po = new ProcessOrder(myUser);
                po.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_data_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                UserData p = new UserData(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_data_staff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                StaffData p = new StaffData(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void picBox_passwordReset_Click(object sender, EventArgs e)
        {
            try
            {
                UserData p = new UserData(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void picBox_infoUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                StaffData p = new StaffData(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void picBox_logout_Click(object sender, EventArgs e)
        {
            LoginController l = new LoginController();
            l.ShowForm();
            this.Close();
        }

        private void lblLink_despatchJobs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DespatchOrder d = new DespatchOrder(myUser);
                d.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void HomePage_Shown(object sender, EventArgs e)
        {
        }

        private void lblLink_orderPacking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                PackingOrder p = new PackingOrder(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_modifyItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ItemData p = new ItemData(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_partsControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SparePartsControl p = new SparePartsControl(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void picBox_orderSearch_Click(object sender, EventArgs e)
        {
            try
            {
                OrderSearchEngine p = new OrderSearchEngine(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void picBox_itemSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ItemSearchingEngine p = new ItemSearchingEngine(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_data_supplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SupplierData p = new SupplierData(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_data_team_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                TeamData p = new TeamData(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_reserveItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ReserveItems p = new ReserveItems(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_createGRN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                GoodsReceivedNoteHandling p = new GoodsReceivedNoteHandling(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_viewGRN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                GoodsReceivingConfirmation p = new GoodsReceivingConfirmation(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_repenishStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ReplenishStock p = new ReplenishStock();
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_overview_salesArea_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                AreaRevenue p = new AreaRevenue();
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void lblLink_overview_item_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ItemSalesFigure p = new ItemSalesFigure();
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void picBox_msg_Click(object sender, EventArgs e)
        {
            try
            {
                BroadcastMessage p = new BroadcastMessage(myUser);
                p.Show();
                this.Hide();
            }
            catch (PermissionDeniedException exc) { }
        }

        private void dgv_msg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            panel_msgContent.Visible = true;
            panel_msgContent.Location = new Point(278, 62);
            int msgID = Convert.ToInt32(dgv_msg.Rows[e.RowIndex].Cells[0].Value.ToString());
            lbl_msgID.Text = msgID.ToString();
            BroadcastMsgs.SetReadedMsg(msgID, myUser.staffID);
            dgv_msg.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(dgv_msg.Rows[e.RowIndex].DataGridView.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel_msgContent.Visible = false;
            lbl_msgID.Text = "";
        }

        private void panel_msgContent_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel_msgContent.Left += e.X - PanelMouseDownLocation.X;

                panel_msgContent.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }

        private void panel_msgContent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void lbl_msgID_TextChanged(object sender, EventArgs e)
        {
            // reset form
            txt_title.Clear();
            txt_sender.Clear();
            txt_content.Clear();

            if (lbl_msgID.Text.Equals(""))
            {
                dtPicker__deliveryDate.Value = DateTime.Today;
            }
            else
            {
                int msgID = Convert.ToInt32(lbl_msgID.Text);
                broadcastmsg msg = BroadcastMsgs.GetBroadcastmsg(msgID);

                txt_title.Text = msg.title;
                dtPicker__deliveryDate.Value = msg.deliveryDate;
                txt_sender.Text = Staffs.GetStaffName(msg.senderID);
                char newLine = '\u000A';
                String[] lines = msg.content.Split(newLine);
                for (int i = 0; i < lines.Length; i++)
                {
                    txt_content.Text += lines[i];
                    if (lines[i] != lines.Last())
                        txt_content.Text += Environment.NewLine;
                }
            }
        }

        private void HomePage_VisibleChanged(object sender, EventArgs e)
        {
            if (panel_msg.Visible == true)
            {
                UpdateMsgs();

                int month = DateTime.Today.Month;
                int year = DateTime.Today.Year;
                double target = Teams.GetTeamTarget(Users.GetStaff(myUser).teamID, month, year);
                if (target > 0)
                {
                    panel_target.Visible = true;
                    lbl_phase.Text = month + "/" + year;
                    lbl_teamBelong.Text = Users.GetStaff(myUser).teamID;
                    lbl_targetValue.Text = target.ToString("0.00");
                    lbl_completedValue.Text = Teams.GetTeamRevenue(Users.GetStaff(myUser).teamID, month, year).ToString("0.00");
                }

                team t = Teams.GetTeamByManagerID(myUser.staffID);
                if (t != null)
                {
                    double target_manage = Teams.GetTeamTarget(t.teamID, month, year);
                    if (target_manage > 0)
                    {
                        lbl_teamManage.Visible = true;
                        lbl_teamManage.Text = t.teamID;
                        lbl_targetValue_manage.Text = target_manage.ToString("0.00");
                        lbl_completed_manage.Text = Teams.GetTeamRevenue(t.teamID, month, year).ToString("0.00");
                    }
                }
            }
        }
    }
}
