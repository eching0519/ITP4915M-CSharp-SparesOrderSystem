namespace SLMC_MS
{
    partial class UserData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserData));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpBox_userInfo = new System.Windows.Forms.GroupBox();
            this.cbBox_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.lbl_staffID = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_staffID = new System.Windows.Forms.TextBox();
            this.cbBox_category = new System.Windows.Forms.ComboBox();
            this.gpBox_userList = new System.Windows.Forms.GroupBox();
            this.cbBox_search_status = new System.Windows.Forms.ComboBox();
            this.cbBox_search_catagory = new System.Windows.Forms.ComboBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.lbl_search_username = new System.Windows.Forms.Label();
            this.dgv_userList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search_username = new System.Windows.Forms.TextBox();
            this.lbl_search_catagory = new System.Windows.Forms.Label();
            this.lbl_search_status = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpBox_userInfo.SuspendLayout();
            this.gpBox_userList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gpBox_userInfo
            // 
            this.gpBox_userInfo.Controls.Add(this.cbBox_status);
            this.gpBox_userInfo.Controls.Add(this.lbl_status);
            this.gpBox_userInfo.Controls.Add(this.bt_clear);
            this.gpBox_userInfo.Controls.Add(this.lbl_category);
            this.gpBox_userInfo.Controls.Add(this.bt_submit);
            this.gpBox_userInfo.Controls.Add(this.lbl_staffID);
            this.gpBox_userInfo.Controls.Add(this.txt_password);
            this.gpBox_userInfo.Controls.Add(this.lbl_username);
            this.gpBox_userInfo.Controls.Add(this.txt_username);
            this.gpBox_userInfo.Controls.Add(this.lbl_password);
            this.gpBox_userInfo.Controls.Add(this.txt_staffID);
            this.gpBox_userInfo.Controls.Add(this.cbBox_category);
            this.gpBox_userInfo.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_userInfo.Location = new System.Drawing.Point(102, 135);
            this.gpBox_userInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_userInfo.Name = "gpBox_userInfo";
            this.gpBox_userInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_userInfo.Size = new System.Drawing.Size(428, 423);
            this.gpBox_userInfo.TabIndex = 24;
            this.gpBox_userInfo.TabStop = false;
            this.gpBox_userInfo.Text = "User Informations";
            // 
            // cbBox_status
            // 
            this.cbBox_status.FormattingEnabled = true;
            this.cbBox_status.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cbBox_status.Location = new System.Drawing.Point(148, 287);
            this.cbBox_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBox_status.Name = "cbBox_status";
            this.cbBox_status.Size = new System.Drawing.Size(170, 31);
            this.cbBox_status.TabIndex = 9;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(18, 293);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(69, 23);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Status:";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(306, 367);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(112, 38);
            this.bt_clear.TabIndex = 11;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click_1);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(18, 50);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(96, 23);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category:";
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(184, 367);
            this.bt_submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(112, 38);
            this.bt_submit.TabIndex = 10;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // lbl_staffID
            // 
            this.lbl_staffID.AutoSize = true;
            this.lbl_staffID.Location = new System.Drawing.Point(18, 110);
            this.lbl_staffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_staffID.Name = "lbl_staffID";
            this.lbl_staffID.Size = new System.Drawing.Size(87, 23);
            this.lbl_staffID.TabIndex = 2;
            this.lbl_staffID.Text = "Staff ID:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(148, 225);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(170, 34);
            this.txt_password.TabIndex = 7;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(18, 172);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(116, 23);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "User Name:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(148, 163);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(170, 34);
            this.txt_username.TabIndex = 5;
            this.txt_username.Validating += new System.ComponentModel.CancelEventHandler(this.txt_username_Validating);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(18, 233);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(99, 23);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password:";
            // 
            // txt_staffID
            // 
            this.txt_staffID.Location = new System.Drawing.Point(148, 102);
            this.txt_staffID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_staffID.Name = "txt_staffID";
            this.txt_staffID.Size = new System.Drawing.Size(170, 34);
            this.txt_staffID.TabIndex = 3;
            this.txt_staffID.TextChanged += new System.EventHandler(this.txt_staffID_TextChanged);
            this.txt_staffID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staffID_Validating);
            // 
            // cbBox_category
            // 
            this.cbBox_category.FormattingEnabled = true;
            this.cbBox_category.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.cbBox_category.Location = new System.Drawing.Point(148, 43);
            this.cbBox_category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBox_category.Name = "cbBox_category";
            this.cbBox_category.Size = new System.Drawing.Size(170, 31);
            this.cbBox_category.TabIndex = 1;
            this.cbBox_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            // 
            // gpBox_userList
            // 
            this.gpBox_userList.Controls.Add(this.cbBox_search_status);
            this.gpBox_userList.Controls.Add(this.cbBox_search_catagory);
            this.gpBox_userList.Controls.Add(this.bt_search);
            this.gpBox_userList.Controls.Add(this.lbl_search_username);
            this.gpBox_userList.Controls.Add(this.dgv_userList);
            this.gpBox_userList.Controls.Add(this.txt_search_username);
            this.gpBox_userList.Controls.Add(this.lbl_search_catagory);
            this.gpBox_userList.Controls.Add(this.lbl_search_status);
            this.gpBox_userList.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_userList.Location = new System.Drawing.Point(555, 58);
            this.gpBox_userList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_userList.Name = "gpBox_userList";
            this.gpBox_userList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_userList.Size = new System.Drawing.Size(574, 713);
            this.gpBox_userList.TabIndex = 25;
            this.gpBox_userList.TabStop = false;
            this.gpBox_userList.Text = "User List";
            // 
            // cbBox_search_status
            // 
            this.cbBox_search_status.FormattingEnabled = true;
            this.cbBox_search_status.Items.AddRange(new object[] {
            "Disable",
            "Enable"});
            this.cbBox_search_status.Location = new System.Drawing.Point(418, 38);
            this.cbBox_search_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBox_search_status.Name = "cbBox_search_status";
            this.cbBox_search_status.Size = new System.Drawing.Size(132, 31);
            this.cbBox_search_status.TabIndex = 3;
            // 
            // cbBox_search_catagory
            // 
            this.cbBox_search_catagory.FormattingEnabled = true;
            this.cbBox_search_catagory.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.cbBox_search_catagory.Location = new System.Drawing.Point(138, 38);
            this.cbBox_search_catagory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBox_search_catagory.Name = "cbBox_search_catagory";
            this.cbBox_search_catagory.Size = new System.Drawing.Size(138, 31);
            this.cbBox_search_catagory.TabIndex = 1;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(346, 88);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(206, 42);
            this.bt_search.TabIndex = 6;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // lbl_search_username
            // 
            this.lbl_search_username.AutoSize = true;
            this.lbl_search_username.Location = new System.Drawing.Point(21, 97);
            this.lbl_search_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_username.Name = "lbl_search_username";
            this.lbl_search_username.Size = new System.Drawing.Size(105, 23);
            this.lbl_search_username.TabIndex = 4;
            this.lbl_search_username.Text = "Username:";
            // 
            // dgv_userList
            // 
            this.dgv_userList.AllowUserToAddRows = false;
            this.dgv_userList.AllowUserToDeleteRows = false;
            this.dgv_userList.AllowUserToResizeColumns = false;
            this.dgv_userList.AllowUserToResizeRows = false;
            this.dgv_userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_userList.Location = new System.Drawing.Point(21, 148);
            this.dgv_userList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_userList.Name = "dgv_userList";
            this.dgv_userList.RowHeadersVisible = false;
            this.dgv_userList.RowTemplate.Height = 24;
            this.dgv_userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_userList.Size = new System.Drawing.Size(531, 555);
            this.dgv_userList.TabIndex = 7;
            this.dgv_userList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_userList_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Catagory";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 130F;
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Disabled";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txt_search_username
            // 
            this.txt_search_username.Location = new System.Drawing.Point(138, 88);
            this.txt_search_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search_username.Name = "txt_search_username";
            this.txt_search_username.Size = new System.Drawing.Size(138, 34);
            this.txt_search_username.TabIndex = 5;
            // 
            // lbl_search_catagory
            // 
            this.lbl_search_catagory.AutoSize = true;
            this.lbl_search_catagory.Location = new System.Drawing.Point(21, 45);
            this.lbl_search_catagory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_catagory.Name = "lbl_search_catagory";
            this.lbl_search_catagory.Size = new System.Drawing.Size(96, 23);
            this.lbl_search_catagory.TabIndex = 0;
            this.lbl_search_catagory.Text = "Catagory:";
            // 
            // lbl_search_status
            // 
            this.lbl_search_status.AutoSize = true;
            this.lbl_search_status.Location = new System.Drawing.Point(342, 45);
            this.lbl_search_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_status.Name = "lbl_search_status";
            this.lbl_search_status.Size = new System.Drawing.Size(69, 23);
            this.lbl_search_status.TabIndex = 2;
            this.lbl_search_status.Text = "Status:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.pictureBox2.Location = new System.Drawing.Point(102, 713);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 58);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SLMC_MS.Properties.Resources.header_data_maintenance_user;
            this.pictureBox1.Location = new System.Drawing.Point(102, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 67);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 817);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gpBox_userList);
            this.Controls.Add(this.gpBox_userInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserData";
            this.Text = "UserData";
            this.Load += new System.EventHandler(this.UserData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpBox_userInfo.ResumeLayout(false);
            this.gpBox_userInfo.PerformLayout();
            this.gpBox_userList.ResumeLayout(false);
            this.gpBox_userList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpBox_userInfo;
        private System.Windows.Forms.GroupBox gpBox_userList;
        private System.Windows.Forms.DataGridView dgv_userList;
        private System.Windows.Forms.Label lbl_search_username;
        private System.Windows.Forms.TextBox txt_search_username;
        private System.Windows.Forms.Label lbl_search_catagory;
        private System.Windows.Forms.Label lbl_search_status;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label lbl_staffID;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_staffID;
        private System.Windows.Forms.ComboBox cbBox_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cbBox_search_status;
        private System.Windows.Forms.ComboBox cbBox_search_catagory;
        private System.Windows.Forms.ComboBox cbBox_status;
        private System.Windows.Forms.Label lbl_status;
    }
}