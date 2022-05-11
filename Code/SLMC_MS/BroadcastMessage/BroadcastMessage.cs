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
    public partial class BroadcastMessage : Form
    {
        user myUser;
        team myTeam;
        List<broadcastmsg> msgs;

        String[] month_str = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        Point PanelMouseDownLocation;

        public BroadcastMessage(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();

            myTeam = Teams.GetTeamByManagerID(myUser.staffID);
            msgs = BroadcastMsgs.GetBroadcastMsgsBySenderID(myUser.staffID);
        }

        private bool isSalesManager()
        {
            return Staffs.isSalesManager(Staffs.GetStaff(myUser.staffID));
        }

        private void BroadcastMessage_Load(object sender, EventArgs e)
        {
            UpdateHistory();

            var teams = Teams.GetTeams();
            foreach(team t in teams)
            {
                ckList_receiver.Items.Add(t.teamID);
            }

            if(isSalesManager())
            {
                panel_receiver.Visible = true;
            }

            // set target panel
            staff manager = Users.GetStaff(myUser);
            if (Staffs.isAreaManager(manager) || Staffs.isSalesManager(manager))
            {
                btn_setTarget.Visible = true;

                for (int year = 2017; year <= DateTime.Today.Year; year++)
                {
                    cbBox_year.Items.Add(year);
                }

                cbBox_year.SelectedItem = DateTime.Today.Year;
                cbBox_month.SelectedIndex = DateTime.Today.Month - 1;
            }
        }

        private void UpdateHistory()
        {
            dgv_history.Rows.Clear();
            foreach(broadcastmsg msg in msgs)
            {
                dgv_history.Rows.Add(msg.msgID, msg.saveDate, msg.title, msg.deliveryDate);
            }
            dgv_history.Sort(dgv_history.Columns[0], ListSortDirection.Descending);

            if (dgv_history.Rows.Count > 0)
                dgv_history.CurrentCell = dgv_history.Rows[0].Cells[1];
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (lbl_msgID.Text.Equals(""))
            {
                CreateMessage();
                ClearMsgForm();
            }
            else
                EditMessage();

            msgs = BroadcastMsgs.GetBroadcastMsgsBySenderID(myUser.staffID);
            UpdateHistory();
            lbl_msgID.Text = "";
        }

        private void ClearMsgForm()
        {
            // reset form
            txt_title.Clear();
            txt_content.Clear();
            txt_title.ReadOnly = false;
            btn_del.Visible = true;
            foreach (int i in ckList_receiver.CheckedIndices)
            {
                ckList_receiver.SetItemChecked(i, false);
            }

            dtPicker__deliveryDate.Value = DateTime.Today;
            btn_del.Visible = false;
        }

        private void CreateMessage()
        {
            String title = txt_title.Text;
            DateTime deliveryDate = dtPicker__deliveryDate.Value;
            DateTime saveDate = DateTime.Today;
            List<staff> receivers = new List<staff>();
            String content = "";

            if (!isSalesManager())
            {
                receivers = Teams.GetTeamMembers(myTeam.teamID);
            }
            else
            {
                foreach (int index in ckList_receiver.CheckedIndices)
                {
                    receivers.AddRange(Teams.GetTeamMembers(ckList_receiver.Items[index].ToString()));
                }
            }

            foreach (String line in txt_content.Lines)
            {
                content += line;
                if (line != txt_content.Lines.Last())
                    content += "\n";
            }

            try
            {
                using (slmc db = new slmc())
                {
                    broadcastmsg msg = new broadcastmsg
                    {
                        senderID = myUser.staffID,
                        title = title,
                        content = content,
                        saveDate = saveDate,
                        deliveryDate = deliveryDate
                    };
                    db.broadcastmsg.Add(msg);

                    db.SaveChanges();

                    foreach (staff rec in receivers)
                    {
                        msgreceiver receiver = new msgreceiver
                        {
                            receiverID = rec.staffID,
                            readed = "N"
                        };
                        msg.msgreceiver.Add(receiver);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception exp) { }
        }

        private void EditMessage()
        {
            int msgID = Convert.ToInt32(lbl_msgID.Text);
            DateTime deliveryDate = dtPicker__deliveryDate.Value;
            List<staff> receivers = new List<staff>();
            String content = "";

            if (!isSalesManager())
            {
                receivers = Teams.GetTeamMembers(myTeam.teamID);
            }
            else
            {
                foreach (int index in ckList_receiver.CheckedIndices)
                {
                    receivers.AddRange(Teams.GetTeamMembers(ckList_receiver.Items[index].ToString()));
                }
            }

            foreach (String line in txt_content.Lines)
            {
                content += line + "\n";
            }
            content += "(Last edit: " + DateTime.Now + ")";

            try
            {
                using (slmc db = new slmc())
                {
                    broadcastmsg msg = db.broadcastmsg.FirstOrDefault(i => i.msgID == msgID);
                    msg.deliveryDate = deliveryDate;
                    msg.content = content;
                    msg.msgreceiver.Clear();
                    db.SaveChanges();

                    foreach (staff rec in receivers)
                    {
                        msgreceiver receiver = new msgreceiver
                        {
                            receiverID = rec.staffID,
                            readed = "N"
                        };
                        msg.msgreceiver.Add(receiver);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception exp) { }
        }

        private void dgv_history_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            lbl_msgID.Text = dgv_history.Rows[e.RowIndex].Cells[0].Value.ToString();
            panel_msg.Visible = true;
        }

        private void lbl_msgID_TextChanged(object sender, EventArgs e)
        {
            // reset form
            panel_msg.Location = new Point(56, 38);
            txt_title.Clear();
            txt_content.Clear();
            txt_title.ReadOnly = false;
            btn_del.Visible = true;
            foreach (int i in ckList_receiver.CheckedIndices)
            {
                ckList_receiver.SetItemChecked(i, false);
            }

            if (lbl_msgID.Text.Equals(""))  // Create new msg
            {
                dtPicker__deliveryDate.Value = DateTime.Today;
                btn_del.Visible = false;

            } else
            {                              // Edit msg
                txt_title.ReadOnly = true;
                int msgID = Convert.ToInt32(lbl_msgID.Text);
                broadcastmsg msg = msgs.FirstOrDefault(i => i.msgID == msgID);

                txt_title.Text = msg.title;
                dtPicker__deliveryDate.Value = msg.deliveryDate;

                if (isSalesManager())
                {
                    List<team> teams = BroadcastMsgs.GetReceiverTeams(msgID);
                    foreach (team t in teams)
                    {
                        ckList_receiver.SetItemChecked(ckList_receiver.Items.IndexOf(t.teamID), true);
                    }
                }

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

        private void btn_newMsg_Click(object sender, EventArgs e)
        {
            lbl_msgID.Text = "";
            panel_msg.Visible = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deleted message cannot be restored. Do you want to delete this message?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.No))
                return;

            int msgID = Convert.ToInt32(lbl_msgID.Text);
            BroadcastMsgs.DeleteMessage(msgID);

            msgs = BroadcastMsgs.GetBroadcastMsgsBySenderID(myUser.staffID);
            UpdateHistory();
            lbl_msgID.Text = "";
        }

        private void dtPicker__deliveryDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime deliveryDate = dtPicker__deliveryDate.Value;
            if (deliveryDate < DateTime.Today)
                dtPicker__deliveryDate.Value = DateTime.Today;
        }

        private void panel_msg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel_msg.Left += e.X - PanelMouseDownLocation.X;

                panel_msg.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }

        private void panel_msg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel_msg.Visible = false;
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

        private void lbl_msgID_VisibleChanged(object sender, EventArgs e)
        {
            panel_msg.Location = new Point(56, 38);
        }

        private void cbBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_year.Text.Equals("") || cbBox_month.Text.Equals(""))
                return;

            int month = cbBox_month.SelectedIndex + 1;
            int year = Convert.ToInt32(cbBox_year.Text);

            ShowTargetValue(month, year);
        }

        private void cbBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_year.Text.Equals("") || cbBox_month.Text.Equals(""))
                return;

            int month = cbBox_month.SelectedIndex + 1;
            int year = Convert.ToInt32(cbBox_year.Text);

            ShowTargetValue(month, year);
        }

        private void ShowTargetValue(int month, int year)
        {
            DateTime viewMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            if(viewMonth <= DateTime.Today)
            {
                txt_targetValue.ReadOnly = true;
                btn_setTargetValue.Enabled = false;
            }
            else
            {
                txt_targetValue.ReadOnly = false;
                btn_setTargetValue.Enabled = true;
            }

            team t = Teams.GetTeamByManagerID(myUser.staffID);
            double targetValue = Teams.GetTeamTarget(t.teamID, month, year);
            txt_targetValue.Text = targetValue.ToString();
        }

        private void btn_setTargetValue_Click(object sender, EventArgs e)
        {
            try
            {
                int month = cbBox_month.SelectedIndex + 1;
                int year = Convert.ToInt32(cbBox_year.Text);
                double targetValue = Convert.ToDouble(txt_targetValue.Text);

                team t = Teams.GetTeamByManagerID(myUser.staffID);
                Teams.SetTeamTarget(t.teamID, month, year, targetValue);
                panel_target.Visible = false;
            }
            catch (Exception exp) { }
        }

        private void btn_setTarget_Click(object sender, EventArgs e)
        {
            cbBox_year.SelectedItem = DateTime.Today.Year;
            cbBox_month.SelectedIndex = DateTime.Today.Month - 1;
            panel_target.Visible = true;
        }

        private void panel_target_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                panel_target.Left += e.X - PanelMouseDownLocation.X;

                panel_target.Top += e.Y - PanelMouseDownLocation.Y;

            }
        }

        private void panel_target_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel_target.Visible = false;
        }
    }
}
