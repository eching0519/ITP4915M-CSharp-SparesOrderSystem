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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            try
            {
                String correctPw = Users.GetPassword(txt_login.Text);
                if (correctPw == null)
                {
                    MessageBox.Show("Sorry. Invalid Login.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!correctPw.Equals(txt_passwd.Text))
                {
                    MessageBox.Show("Sorry. Incorrect username / password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();
                user myUser = Users.GetUser(txt_login.Text);

                HomePage hp = new HomePage(myUser);
                hp.Show();
            }
            catch (System.Data.EntityException exp)
            {
                MessageBox.Show("Database connection fail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_simpleChinese_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Change it now?", "System Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Hide();
                loginC loginSP = new loginC();
                loginSP.Show();

            }
        }

        private void lbl_forgetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please Contact IT Departmnet!","System Message");
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            
        }

        private void txt_login_Enter(object sender, EventArgs e)
        {
            txt_login.SelectAll();
        }

        private void txt_passwd_Enter(object sender, EventArgs e)
        {
            txt_passwd.SelectAll();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                var formToShow = Application.OpenForms;
                if (formToShow != null)
                {
                    foreach (Form f in formToShow)
                    {
                        f.Dispose();
                    }
                }
            } catch(Exception exp)
            {

            }
        }
    }
}
