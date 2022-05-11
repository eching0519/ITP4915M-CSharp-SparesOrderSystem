using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLMC_MS
{
    public partial class loginC : Form
    {
        public loginC()
        {
            InitializeComponent();
        }

        private void bt_simpleChinese_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("立即转换?", "系统通知", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) { }
            this.Hide();
            Login loginSP = new Login();
            loginSP.Show();
        }

        private void lbl_forgetPW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("请联系IT部门", "系统消息");
        }
    }
    }

