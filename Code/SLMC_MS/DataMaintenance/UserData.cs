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
    public partial class UserData : Form
    {
        user myUser;
        List<user> userList;

        public UserData(user myUser)
        {
            this.myUser = myUser;
            InitializeComponent();
        }

        private void UserData_Load(object sender, EventArgs e)
        {
            SetForm();
            userList = Users.GetUsers();
            SetUserList(userList);
        }

        private void SetForm()
        {
            cbBox_category.SelectedItem = "staff";
            cbBox_status.SelectedItem = "Enable";
            txt_staffID.Clear();
            txt_username.Clear();
            txt_password.Clear();
            errorProvider1.Clear();
            cbBox_category.Enabled = true;
            txt_staffID.ReadOnly = false;
            txt_username.ReadOnly = false;

            if (!myUser.username.Equals("admin"))
            {
                EnterUserInfo(myUser.username);
                gpBox_userList.Visible = false;
                bt_clear.Visible = false;
                cbBox_status.Enabled = false;
                cbBox_category.Enabled = false;
                txt_username.ReadOnly = true;
                txt_staffID.ReadOnly = true;
                txt_password.Select();
                pictureBox2.Location = new Point(68, 356);
                bt_submit.Location = new Point(139, 220);
                this.Size = new Size(419, 434);
            }
        }

        private void SetUserList(List<user> userList)
        {
            dgv_userList.Rows.Clear();
            foreach(user u in userList)
            {
                String status = (u.disabled.Equals("Y")) ? "Disable" : "Enable";
                dgv_userList.Rows.Add(u.category,u.username, status);
            }
        }
        
        private void SearchUser()
        {
            String disable = "";

            if (cbBox_search_status.Text.Equals("Disable"))
                disable = "Y";

            if (cbBox_search_status.Text.Equals("Enable"))
                disable = "N";

            String category = cbBox_search_catagory.Text;
            String username = txt_search_username.Text;

            List<user> users = userList.Where(i => i.category.Contains(category) && i.username.Contains(username) &&
                                                   i.disabled.Contains(disable)).Select(i => i).ToList();

            SetUserList(users);

            //var userList = Users.FindUser(cbBox_search_catagory.Text, txt_search_username.Text, disable);
            //foreach (user u in userList)
            //{
            //    String status = (u.disabled.Equals("Y")) ? "Disable" : "Enable";
            //    dgv_userList.Rows.Add(u.category, u.username, status);
            //}
        }

        private void ModifyUser()
        {
            Users.SetPassword(txt_username.Text, txt_password.Text);
            if (cbBox_status.SelectedItem.ToString() == "Disable")
                Users.Disable(txt_username.Text);
            else
                Users.Enable(txt_username.Text);
        }

        private void EnterUserInfo(String username)
        {
            user u = Users.GetUser(username);
            cbBox_category.SelectedItem = u.category;
            txt_staffID.Text = u.staffID;
            txt_username.Text = username;
            txt_password.Text = u.password;
            if (u.disabled.Equals("N"))
                cbBox_status.SelectedItem = "Enable";
            else
                cbBox_status.SelectedItem = "Disable";
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CloseThisPage();
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_category.Text.Equals("admin"))
            {
                txt_staffID.Clear();
                txt_staffID.Enabled = false;
                errorProvider1.SetError(txt_staffID, "");
                txt_username.ReadOnly = false;
                errorProvider1.Clear();
            }
            else
            {
                txt_staffID.Enabled = true;
                txt_username.ReadOnly = true;
                errorProvider1.Clear();
            }
        }

        private bool CheckCategory()
        {
            if (cbBox_category.Text.Equals(""))
            {
                errorProvider1.SetError(cbBox_category, "Please select the user category.");
                return false;
            }
            else
            {
                errorProvider1.SetError(cbBox_category, "");
                return true;
            }
        }

        private bool CheckStaffID()
        {
            if(!cbBox_category.Enabled)
            {
                errorProvider1.SetError(txt_staffID, "");
                return true;
            }

            if (!cbBox_category.Text.Equals("staff"))
            {
                errorProvider1.SetError(txt_staffID, "");
                return true;
            }

            using (slmc content = new slmc())
            {
                var myStaff = content.staff.FirstOrDefault(i => i.staffID.Equals(txt_staffID.Text));
                var myUser = content.user.FirstOrDefault(i => i.staffID.Equals(txt_staffID.Text));
                if (myUser != null)
                {
                    errorProvider1.SetError(txt_staffID, "This staff already has an account.");
                    return false;
                }
                else if (myStaff == null)
                {
                    errorProvider1.SetError(txt_staffID, "The above staff ID does not exist.");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(txt_staffID, "");
                    return true;
                }
            }
        }

        private bool CheckUsername()
        {
            if (!cbBox_category.Enabled)
            {
                errorProvider1.SetError(txt_username, "");
                return true;
            }
            using (slmc content = new slmc())
            {
                var myUser = content.user.FirstOrDefault(i => i.username.Equals(txt_username.Text));
                if (myUser != null)
                {
                    errorProvider1.SetError(txt_username, "The above username is in used.");
                    return false;
                }
                else
                {
                    errorProvider1.SetError(txt_username, "");
                    return true;
                }
            }
        }

        private bool CheckPassword()
        {
            if (txt_password.Text.Equals(""))
            {
                errorProvider1.SetError(txt_password, "This field is required.");
                return false;
            }
            else
            {
                errorProvider1.SetError(txt_password, "");
                return true;
            }
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (CheckPassword() && cbBox_category.Enabled == false)
            {
                ModifyUser();
                MessageBox.Show("Account is modified.", "Successful");
                SetForm();
            }
            else if (cbBox_category.Enabled == true && CheckCategory() & CheckStaffID() & CheckUsername() & CheckPassword()) 
            {
                String cat = cbBox_category.Text;
                String sID = (txt_staffID.Text == "") ? null : txt_staffID.Text;
                String un = txt_username.Text;
                String pw = txt_password.Text;
                String status = (cbBox_status.Equals("Disable")) ? "Y" : "N";
                using (slmc content = new slmc())
                {
                    user u = new user
                    {
                        category = cat,
                        staffID = sID,
                        username = un,
                        password = pw,
                        disabled = status
                    };
                    content.user.Add(u);
                    content.SaveChanges();
                }
                MessageBox.Show("Account is created.", "Successful");
                SetForm();
            }
            else
                MessageBox.Show("Please complete and correct the form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bt_clear_Click_1(object sender, EventArgs e)
        {
            SetForm();
        }

        private void txt_staffID_Validating(object sender, CancelEventArgs e)
        {
            CheckStaffID();
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            CheckUsername();
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

        private void dgv_userList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            SetForm();
            cbBox_category.Enabled = false;
            txt_staffID.ReadOnly = true;
            txt_username.ReadOnly = true;

            String username = dgv_userList.Rows[e.RowIndex].Cells[1].Value.ToString();
            EnterUserInfo(username);
        }

        private void txt_staffID_TextChanged(object sender, EventArgs e)
        {
            txt_username.Text = txt_staffID.Text;
        }
    }
}
