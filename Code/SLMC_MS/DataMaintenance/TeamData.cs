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
    public partial class TeamData : Form
    {
        user myUser;
        List<team> teams;

        public TeamData(user myUser)
        {
            this.myUser = myUser;
            if (!myUser.username.Equals("admin"))
                throw new PermissionDeniedException();

            InitializeComponent();
            teams = Teams.GetTeams();
        }

        private void TeamData_Load(object sender, EventArgs e)
        {
            SetTeamData(teams);
        }

        private void SetTeamData(List<team> teams)
        {
            dgv_teamList.Rows.Clear();
            foreach(team t in teams)
            {
                String managerName = (t.managerID == null) ? "" : Staffs.GetStaffName(t.managerID);
                dgv_teamList.Rows.Add(t.teamID, t.managerID, managerName);
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            String teamID = txt_search_teamID.Text;
            String name = txt_search_name.Text;
            List<team> searchList = teams;

            if (!txt_search_teamID.Text.Equals(""))
                searchList = searchList.Where(i => i.teamID.Contains(txt_search_teamID.Text)).Select(i => i).ToList();

            if (!txt_search_name.Text.Equals(""))
                searchList = searchList.Where(i => Staffs.GetStaffName(i.managerID).Contains(txt_search_name.Text)).Select(i => i).ToList();

            SetTeamData(searchList);
        }

        private bool ValidTeamID()
        {
            if (!Regex.IsMatch(txt_teamID.Text, @"^((SS||WH)\d{3})||OFFIC||MANGE$")) 
            {
                errorProvider.SetError(txt_teamID, "Team ID should be SS or WH follow with 3-digit.");
                return false;
            }
            else
            {
                errorProvider.SetError(txt_teamID, "");
                return true;
            }
        }

        private bool ValidManager()
        {
            return !txt_managerName.Text.Equals("");
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            txt_teamID.Clear();
            txt_managerID.Clear();
            txt_managerName.Clear();
            txt_position.Clear();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (ValidTeamID() & ValidManager()) 
            {
                String teamID = txt_teamID.Text;
                team team = Teams.GetTeam(teamID);
                if (team == null) 
                {
                    team t = new team
                    {
                        teamID = teamID,
                        managerID = txt_managerID.Text
                    };
                    Teams.Add(t);
                    MessageBox.Show("Team is added.", "Success");
                }
                else
                {
                    Teams.Set(teamID, txt_managerID.Text);
                    MessageBox.Show("Team is modified.", "Success");
                }
                teams = Teams.GetTeams();
                SetTeamData(teams);
            }
            else
            {
                MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_teamID_TextChanged(object sender, EventArgs e)
        {
            team team = Teams.GetTeam(txt_teamID.Text);
            if (team != null) 
            {
                txt_managerID.Text = team.managerID;
                txt_managerName.Text = (team.managerID == null) ? "" : Staffs.GetStaffName(team.managerID);
                linklbl_overview.Enabled = true;
            }
            else
            {
                linklbl_overview.Enabled = false;
            }
        }

        private void txt_managerID_TextChanged(object sender, EventArgs e)
        {
            String managerID = txt_managerID.Text;
            staff manager = Staffs.GetStaff(managerID);
            if (manager != null) 
            {
                txt_managerName.Text = manager.name;
                txt_position.Text = StaffPosition.GetStaffposition(manager.positionID).position;
                errorProvider.SetError(txt_managerID, "");
            }
            else
            {
                txt_managerName.Clear();
                txt_position.Clear();
                errorProvider.SetError(txt_managerID, "Invalid staff ID.");
            }
        }

        private void dgv_teamList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txt_teamID.Text = dgv_teamList.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void linklbl_overview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamMemberList p = new TeamMemberList(txt_teamID.Text);
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
