namespace SLMC_MS
{
    partial class loginC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginC));
            this.bt_simpleChinese = new System.Windows.Forms.Button();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_forgetPW = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_simpleChinese
            // 
            this.bt_simpleChinese.Location = new System.Drawing.Point(12, 458);
            this.bt_simpleChinese.Name = "bt_simpleChinese";
            this.bt_simpleChinese.Size = new System.Drawing.Size(113, 65);
            this.bt_simpleChinese.TabIndex = 13;
            this.bt_simpleChinese.Text = "English";
            this.bt_simpleChinese.UseVisualStyleBackColor = true;
            this.bt_simpleChinese.Click += new System.EventHandler(this.bt_simpleChinese_Click);
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.Location = new System.Drawing.Point(367, 371);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(32, 12);
            this.lbl_passwd.TabIndex = 12;
            this.lbl_passwd.Text = "密码:";
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.Location = new System.Drawing.Point(358, 339);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(56, 12);
            this.lbl_userID.TabIndex = 11;
            this.lbl_userID.Text = "用户身份:";
            // 
            // txt_passwd
            // 
            this.txt_passwd.Location = new System.Drawing.Point(463, 366);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PasswordChar = '*';
            this.txt_passwd.Size = new System.Drawing.Size(131, 22);
            this.txt_passwd.TabIndex = 9;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(463, 329);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(131, 22);
            this.txt_login.TabIndex = 8;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_login.Location = new System.Drawing.Point(505, 394);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(89, 40);
            this.bt_login.TabIndex = 10;
            this.bt_login.Text = "登录";
            this.bt_login.UseMnemonic = false;
            this.bt_login.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SLMC_MS.Properties.Resources.Logo_Black;
            this.pictureBox1.Location = new System.Drawing.Point(299, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_forgetPW
            // 
            this.lbl_forgetPW.AutoSize = true;
            this.lbl_forgetPW.Location = new System.Drawing.Point(335, 408);
            this.lbl_forgetPW.Name = "lbl_forgetPW";
            this.lbl_forgetPW.Size = new System.Drawing.Size(53, 12);
            this.lbl_forgetPW.TabIndex = 14;
            this.lbl_forgetPW.TabStop = true;
            this.lbl_forgetPW.Text = "忘记密码";
            this.lbl_forgetPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_forgetPW_LinkClicked);
            // 
            // loginC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLMC_MS.Properties.Resources.bricks_brickwall_brickwork_1092364;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 535);
            this.Controls.Add(this.lbl_forgetPW);
            this.Controls.Add(this.bt_simpleChinese);
            this.Controls.Add(this.lbl_passwd);
            this.Controls.Add(this.lbl_userID);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginC";
            this.RightToLeftLayout = true;
            this.Text = "登录页面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_simpleChinese;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.Label lbl_userID;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lbl_forgetPW;
    }
}