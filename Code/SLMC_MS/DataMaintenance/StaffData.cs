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
    public partial class StaffData : Form
    {
        user myUser;
        List<staff> staffList;

        public StaffData(user myUser)
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
            staffList = Staffs.GetStaffs();
        }

        private void PermissionCheck()
        {
            if (!myUser.username.Equals("admin") && !myUser.username.Equals("hr") && Users.GetStaff(myUser) == null)
            {
                MessageBox.Show("Sorry. Unauthorized access.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new PermissionDeniedException();
            }
        }

        private void SetStaffAccessibility()
        {
            gpBox_staffList.Hide();
            bt_clear.Hide();
            txt_staffID.ReadOnly = true;
            cbBox_position.Enabled = false;
            txt_teamID.ReadOnly = true;
            FillStaffData(Users.GetStaff(myUser));
            txt_name.Select();
            bt_save.Location = new Point(290, 256);
            picBox_return.Location = new Point(12, 354);
            this.Size = new Size(401, 408);

        }

        private void StaffData_Load(object sender, EventArgs e)
        {
            SetForm();

            if (Users.GetStaff(myUser) != null)
            {
                SetStaffAccessibility();
                return;
            }

            SetStaffList(staffList);
            var positions = (StaffPosition.GetStaffpositions()).Select(i => i.position);
            foreach (String p in positions)
            {
                cbBox_search_position.Items.Add(p);
            }
        }

        private void SetForm()
        {
            staffList = Staffs.GetStaffs();

            txt_staffID.Clear();
            txt_staffID.ReadOnly = false;
            txt_name.Clear();
            txt_name_ch.Clear();
            cbBox_position.ResetText();
            cbBox_position.Items.Clear();
            txt_teamID.Clear();
            txt_teamID.ReadOnly = true;
            cbBox_province.ResetText();
            cbBox_province.Items.Clear();
            cbBox_province.Enabled = false;

            var provinceList = Provinces.GetProvinces();
            foreach (var pro in provinceList)
                cbBox_province.Items.Add(pro.province1);

            var positionList = (StaffPosition.GetStaffpositions()).Select(i=>i.position);
            foreach (String position in positionList)
                cbBox_position.Items.Add(position);

            cbBox_city.ResetText();
            cbBox_city.Items.Clear();
            cbBox_city.Enabled = false;
            txt_address.Clear();
            txt_address.Enabled = false;
            errorProvider1.Clear();
        }

        private void SetStaffList(List<staff> staffList)
        {
            dgv_staffList.Rows.Clear();
            foreach(staff s in staffList)
            {
                dgv_staffList.Rows.Add(s.staffID, s.name, s.name_ch, StaffPosition.GetStaffposition(s.positionID).position, s.teamID);
                
            }
        }

        private void cbBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_position.Text.Equals(StaffPosition.AreaManager.position)
                || cbBox_position.Text.Equals(StaffPosition.SparePartsController.position)
                || cbBox_position.Text.Equals(StaffPosition.SalesOrderOfficeManager.position)) 
            {
                txt_teamID.ReadOnly = true;
                txt_teamID.Text = "MANGE";
            }
            else if (cbBox_position.Text.Equals(StaffPosition.Dealer.position)) 
            {
                txt_teamID.ReadOnly = false;
                txt_teamID.Text = "SS";
                cbBox_province.Enabled = true;
                cbBox_city.Enabled = true;
                txt_address.Enabled = true;
            } else
            {
                txt_teamID.ReadOnly = true;
                cbBox_province.Enabled = false;
                cbBox_city.Enabled = false;
                txt_address.Enabled = false;
                if (cbBox_position.Text.Equals(StaffPosition.DespatchClerk.position) 
                    || cbBox_position.Text.Equals(StaffPosition.Storemen.position)) 
                {
                    txt_teamID.ReadOnly = false;
                    txt_teamID.Text = "WH";
                }
                else
                if (cbBox_position.Text.Equals(StaffPosition.SalesOrderOfficer.position))
                    txt_teamID.Text = "OFFIC";
                else
                    txt_teamID.Text = "";
            }
            CheckPosition();

            if (Users.GetStaff(myUser) != null)
                txt_teamID.ReadOnly = true;
        }

        private bool ValidateStaffID()
        {
            if (Users.GetStaff(myUser) != null)
                return true;

            if(txt_staffID.ReadOnly == true)
            {
                errorProvider1.SetError(txt_staffID, "");
                return true;
            }

            String sID = txt_staffID.Text;
            staff myStaff = Staffs.GetStaff(sID);
            if (myStaff != null)
            {
                errorProvider1.SetError(txt_staffID, "This staff ID is not unique.");
                return false;
            }
            else
            if (!Regex.IsMatch(sID, @"^\d{5}$"))
            {
                errorProvider1.SetError(txt_staffID, "Staff ID should be 5-digit.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_staffID, "");
                return true;
            }
        }

        private bool CheckName()
        {
            if (txt_name.Text.Equals(""))
            {
                errorProvider1.SetError(txt_name,"English name is required.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_name, "");
                return true;
            }
        }

        private bool CheckPosition()
        {
            if (Users.GetStaff(myUser) != null)
                return true;

            if (cbBox_position.Text.Equals(""))
            {
                errorProvider1.SetError(cbBox_position,"Position is required.");
                return false;
            }
            else
            {
                errorProvider1.SetError(cbBox_position, "");
                return true;
            }
        }

        private bool CheckTeamID()
        {
            if (Users.GetStaff(myUser) != null)
                return true;

            if (txt_teamID.Text.Equals(""))
            {
                errorProvider1.SetError(txt_teamID, "");
                return true;
            }

            var team = Teams.GetTeam(txt_teamID.Text);
            if (team == null)
            {
                errorProvider1.SetError(txt_teamID, "This team is not existed");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_teamID, "");
                return true;
            }
        }

        private void cbBox_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBox_city.Items.Clear();
            province prov = Provinces.GetProvince(cbBox_province.Text);
            var cityList = Cities.GetCities(prov);
            foreach (var city in cityList.ToList())
            {
                cbBox_city.Items.Add(city.city1);
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            SetForm();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (txt_staffID.ReadOnly == true)
            {
                if (CheckName() & CheckPosition() & CheckTeamID())
                {
                    ModifyStaff();
                    MessageBox.Show("Staff record is updated.", "Successful");
                    if (Users.GetStaff(myUser) == null)
                        SetForm();
                    else
                        CloseThisPage();
                } else
                {
                    MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(ValidateStaffID() & CheckName() & CheckPosition() & CheckTeamID())
            {

                String myStaffID = txt_staffID.Text;
                String myName = txt_name.Text;
                String myName_ch = (txt_name_ch.Text.Equals("")) ? null : txt_name_ch.Text;
                String myPositionID = StaffPosition.GetStaffposition(cbBox_position.Text).positionID;
                String myTeamID = (txt_teamID.Text.Equals("")) ? null : txt_teamID.Text;
                String myAddress = (txt_address.Text.Equals("")) ? null : txt_address.Text;
                String myCityID = (cbBox_city.Text.Equals("")) ? null : Cities.GetCityID(cbBox_city.Text);

                staff s = new staff
                {
                    staffID = myStaffID,
                    name = myName,
                    name_ch = myName_ch,
                    positionID = myPositionID,
                    teamID = myTeamID,
                    address = myAddress,
                    cityID = myCityID
                };
                Staffs.Add(s);

                MessageBox.Show("Staff record is created.", "Successful");
                SetForm();
            } else
            {
                MessageBox.Show("Please complete and correct the form.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txt_staffID_Validating(object sender, CancelEventArgs e)
        {
            ValidateStaffID();
        }

        private void txt_teamID_Validating(object sender, CancelEventArgs e)
        {
            CheckTeamID();
        }

        private void SearchStaff()
        {
            String staffID = txt_search_staffID.Text;
            String positionID = cbBox_search_position.Text.Equals("") ? "" : StaffPosition.GetStaffposition(cbBox_search_position.Text).positionID;
            String name = txt_search_name.Text;
            String teamID = txt_search_teamID.Text;

            List<staff> searchList = staffList;

            if (!staffID.Equals(""))
                searchList = searchList.Where(i => i.staffID.Contains(staffID)).Select(i => i).ToList();

            if(!positionID.Equals(""))
                searchList = searchList.Where(i => i.positionID.Contains(positionID)).Select(i => i).ToList();

            if (!name.Equals(""))
                searchList = searchList.Where(i => i.name.Contains(name) || i.name_ch.Contains(name)).Select(i => i).ToList();

            if (!teamID.Equals(""))
                searchList = searchList.Where(i => i.teamID != null && i.teamID.Contains(teamID)).Select(i => i).ToList();

            SetStaffList(searchList);
        }

        private void ModifyStaff()
        {
            String staffID = txt_staffID.Text;
            Staffs.SetName(staffID, txt_name.Text);
            Staffs.SetName_ch(staffID, txt_name_ch.Text);
            Staffs.SetPosition(staffID, cbBox_position.Text);
            Staffs.SetTeam(staffID, txt_teamID.Text);
            Staffs.SetAddress(staffID, cbBox_city.Text, txt_address.Text);
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            SearchStaff();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void dgv_staffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SetForm();
            txt_staffID.ReadOnly = true;
            String myStaffID = dgv_staffList.Rows[e.RowIndex].Cells[0].Value.ToString();
            staff myStaff = Staffs.GetStaff(myStaffID);

            FillStaffData(myStaff);
        }

        private void FillStaffData(staff myStaff)
        {
            txt_staffID.Text = myStaff.staffID;
            txt_name.Text = myStaff.name;
            txt_name_ch.Text = myStaff.name_ch;
            cbBox_position.SelectedItem = StaffPosition.GetStaffposition(myStaff).position;
            txt_teamID.Text = myStaff.teamID;
            if (myStaff.cityID != null)
            {
                city myCity = Cities.GetCity(myStaff.cityID);
                province myProv = Provinces.GetProvince(myCity);
                cbBox_province.SelectedItem = myProv.province1;
                cbBox_city.SelectedItem = myCity.city1;
                txt_address.Text = myStaff.address;
            }
        }

        private void txt_teamID_TextChanged(object sender, EventArgs e)
        {
            team team = Teams.GetTeam(txt_teamID.Text);
            if (team != null)
            {
                linklbl_overview.Enabled = true;
            }
            else
            {
                linklbl_overview.Enabled = false;
            }
        }

        private void linklbl_overview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamMemberList p = new TeamMemberList(txt_teamID.Text);
            p.Show();
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
