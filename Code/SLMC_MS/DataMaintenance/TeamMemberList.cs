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
    public partial class TeamMemberList : Form
    {
        List<staff> members;
        public TeamMemberList()
        {
            InitializeComponent();
            members = null;
        }

        public TeamMemberList(String teamID)
        {
            InitializeComponent();
            txt_teamID.ReadOnly = true;
            txt_teamID.Text = teamID;
            members = Teams.GetTeamMembers(teamID);
        }

        private void TeamMemberList_Load(object sender, EventArgs e)
        {
            
        }

        private void SetTeamMemberList(List<staff> members)
        {
            dgv_memberList.Rows.Clear();
            foreach(staff member in members)
            {
                String position = Staffs.GetPosition(member).position;
                String city = (member.cityID == null) ? "" : Cities.GetCity(member.cityID).city1;
                dgv_memberList.Rows.Add(member.staffID, member.name, position, city, member.address);
            }
        }
        

        private void txt_teamID_TextChanged(object sender, EventArgs e)
        {
            String teamID = txt_teamID.Text;
            team team = Teams.GetTeam(teamID);
            if(team==null)
            {
                txt_managerID.Clear();
                txt_managerName.Clear();
                dgv_memberList.Rows.Clear();
            }
            else
            {
                txt_managerID.Text = team.managerID;
                txt_managerName.Text = team.managerID == null ? "" : Staffs.GetStaffName(team.managerID);
                members = Teams.GetTeamMembers(teamID);
                SetTeamMemberList(members);
            }
        }

    }
}
