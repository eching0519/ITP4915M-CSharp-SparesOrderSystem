namespace SLMC_MS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.lbl_userID = new System.Windows.Forms.Label();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.bt_simpleChinese = new System.Windows.Forms.Button();
            this.lbl_forgetPW = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SLMC_MS.Properties.Resources.Logo_Black;
            this.pictureBox1.Location = new System.Drawing.Point(282, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_login.Location = new System.Drawing.Point(409, 355);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(131, 25);
            this.txt_login.TabIndex = 1;
            this.txt_login.Enter += new System.EventHandler(this.txt_login_Enter);
            // 
            // txt_passwd
            // 
            this.txt_passwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_passwd.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_passwd.Location = new System.Drawing.Point(409, 392);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PasswordChar = '*';
            this.txt_passwd.Size = new System.Drawing.Size(131, 25);
            this.txt_passwd.TabIndex = 2;
            this.txt_passwd.Enter += new System.EventHandler(this.txt_passwd_Enter);
            // 
            // bt_login
            // 
            this.bt_login.BackgroundImage = global::SLMC_MS.Properties.Resources.button_login;
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_login.Location = new System.Drawing.Point(451, 420);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(89, 40);
            this.bt_login.TabIndex = 3;
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lbl_userID
            // 
            this.lbl_userID.AutoSize = true;
            this.lbl_userID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_userID.Location = new System.Drawing.Point(304, 358);
            this.lbl_userID.Name = "lbl_userID";
            this.lbl_userID.Size = new System.Drawing.Size(56, 15);
            this.lbl_userID.TabIndex = 4;
            this.lbl_userID.Text = "User ID:";
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_passwd.Location = new System.Drawing.Point(297, 392);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(64, 15);
            this.lbl_passwd.TabIndex = 5;
            this.lbl_passwd.Text = "Password:";
            // 
            // bt_simpleChinese
            // 
            this.bt_simpleChinese.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_simpleChinese.Location = new System.Drawing.Point(12, 494);
            this.bt_simpleChinese.Name = "bt_simpleChinese";
            this.bt_simpleChinese.Size = new System.Drawing.Size(113, 65);
            this.bt_simpleChinese.TabIndex = 6;
            this.bt_simpleChinese.TabStop = false;
            this.bt_simpleChinese.Text = "简体中文";
            this.bt_simpleChinese.UseVisualStyleBackColor = true;
            this.bt_simpleChinese.Click += new System.EventHandler(this.bt_simpleChinese_Click);
            // 
            // lbl_forgetPW
            // 
            this.lbl_forgetPW.AutoSize = true;
            this.lbl_forgetPW.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_forgetPW.Location = new System.Drawing.Point(303, 434);
            this.lbl_forgetPW.Name = "lbl_forgetPW";
            this.lbl_forgetPW.Size = new System.Drawing.Size(105, 15);
            this.lbl_forgetPW.TabIndex = 7;
            this.lbl_forgetPW.TabStop = true;
            this.lbl_forgetPW.Text = "Forget Password.";
            this.lbl_forgetPW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_forgetPW_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SLMC_MS.Properties.Resources.bricks_brickwall_brickwork_1092364;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 587);
            this.Controls.Add(this.lbl_forgetPW);
            this.Controls.Add(this.bt_simpleChinese);
            this.Controls.Add(this.lbl_passwd);
            this.Controls.Add(this.lbl_userID);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lbl_userID;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.Button bt_simpleChinese;
        private System.Windows.Forms.LinkLabel lbl_forgetPW;
    }
}