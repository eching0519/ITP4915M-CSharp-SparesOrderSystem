namespace SLMC_MS
{
    partial class StaffData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffData));
            this.lbl_staffID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_name_ch = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_teamID = new System.Windows.Forms.Label();
            this.txt_staffID = new System.Windows.Forms.TextBox();
            this.cbBox_position = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_name_ch = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_teamID = new System.Windows.Forms.TextBox();
            this.cbBox_province = new System.Windows.Forms.ComboBox();
            this.cbBox_city = new System.Windows.Forms.ComboBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpBox_staffInfo = new System.Windows.Forms.GroupBox();
            this.linklbl_overview = new System.Windows.Forms.LinkLabel();
            this.lbl_name_eng = new System.Windows.Forms.Label();
            this.gpBox_staffList = new System.Windows.Forms.GroupBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.lbl_search_staffID = new System.Windows.Forms.Label();
            this.dgv_staffList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search_staffID = new System.Windows.Forms.TextBox();
            this.cbBox_search_position = new System.Windows.Forms.ComboBox();
            this.lbl_search_position = new System.Windows.Forms.Label();
            this.lbl_search_name = new System.Windows.Forms.Label();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.lbl_search_teamID = new System.Windows.Forms.Label();
            this.txt_search_teamID = new System.Windows.Forms.TextBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpBox_staffInfo.SuspendLayout();
            this.gpBox_staffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staffList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_staffID
            // 
            this.lbl_staffID.AutoSize = true;
            this.lbl_staffID.Location = new System.Drawing.Point(13, 28);
            this.lbl_staffID.Name = "lbl_staffID";
            this.lbl_staffID.Size = new System.Drawing.Size(58, 15);
            this.lbl_staffID.TabIndex = 0;
            this.lbl_staffID.Text = "Staff ID:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(13, 62);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(48, 15);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name: ";
            // 
            // lbl_name_ch
            // 
            this.lbl_name_ch.AutoSize = true;
            this.lbl_name_ch.Location = new System.Drawing.Point(183, 96);
            this.lbl_name_ch.Name = "lbl_name_ch";
            this.lbl_name_ch.Size = new System.Drawing.Size(41, 15);
            this.lbl_name_ch.TabIndex = 6;
            this.lbl_name_ch.Text = "(CHI)";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(13, 195);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(56, 15);
            this.lbl_address.TabIndex = 11;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(13, 129);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(57, 15);
            this.lbl_position.TabIndex = 7;
            this.lbl_position.Text = "Position:";
            // 
            // lbl_teamID
            // 
            this.lbl_teamID.AutoSize = true;
            this.lbl_teamID.Location = new System.Drawing.Point(13, 162);
            this.lbl_teamID.Name = "lbl_teamID";
            this.lbl_teamID.Size = new System.Drawing.Size(62, 15);
            this.lbl_teamID.TabIndex = 9;
            this.lbl_teamID.Text = "Team ID:";
            // 
            // txt_staffID
            // 
            this.txt_staffID.Location = new System.Drawing.Point(77, 23);
            this.txt_staffID.Name = "txt_staffID";
            this.txt_staffID.Size = new System.Drawing.Size(100, 25);
            this.txt_staffID.TabIndex = 1;
            this.txt_staffID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_staffID_Validating);
            // 
            // cbBox_position
            // 
            this.cbBox_position.FormattingEnabled = true;
            this.cbBox_position.Location = new System.Drawing.Point(77, 125);
            this.cbBox_position.Name = "cbBox_position";
            this.cbBox_position.Size = new System.Drawing.Size(176, 23);
            this.cbBox_position.Sorted = true;
            this.cbBox_position.TabIndex = 8;
            this.cbBox_position.SelectedIndexChanged += new System.EventHandler(this.cbBox_position_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(77, 57);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 25);
            this.txt_name.TabIndex = 3;
            // 
            // txt_name_ch
            // 
            this.txt_name_ch.Location = new System.Drawing.Point(77, 91);
            this.txt_name_ch.Name = "txt_name_ch";
            this.txt_name_ch.Size = new System.Drawing.Size(100, 25);
            this.txt_name_ch.TabIndex = 5;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(77, 223);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(288, 25);
            this.txt_address.TabIndex = 14;
            // 
            // txt_teamID
            // 
            this.txt_teamID.Location = new System.Drawing.Point(77, 157);
            this.txt_teamID.Name = "txt_teamID";
            this.txt_teamID.Size = new System.Drawing.Size(100, 25);
            this.txt_teamID.TabIndex = 10;
            this.txt_teamID.TextChanged += new System.EventHandler(this.txt_teamID_TextChanged);
            this.txt_teamID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_teamID_Validating);
            // 
            // cbBox_province
            // 
            this.cbBox_province.FormattingEnabled = true;
            this.cbBox_province.Location = new System.Drawing.Point(77, 191);
            this.cbBox_province.Name = "cbBox_province";
            this.cbBox_province.Size = new System.Drawing.Size(112, 23);
            this.cbBox_province.TabIndex = 12;
            this.cbBox_province.SelectedIndexChanged += new System.EventHandler(this.cbBox_province_SelectedIndexChanged);
            // 
            // cbBox_city
            // 
            this.cbBox_city.FormattingEnabled = true;
            this.cbBox_city.Location = new System.Drawing.Point(195, 191);
            this.cbBox_city.Name = "cbBox_city";
            this.cbBox_city.Size = new System.Drawing.Size(112, 23);
            this.cbBox_city.TabIndex = 13;
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(209, 256);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 15;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(290, 256);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 16;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gpBox_staffInfo
            // 
            this.gpBox_staffInfo.Controls.Add(this.linklbl_overview);
            this.gpBox_staffInfo.Controls.Add(this.lbl_name_eng);
            this.gpBox_staffInfo.Controls.Add(this.lbl_staffID);
            this.gpBox_staffInfo.Controls.Add(this.txt_staffID);
            this.gpBox_staffInfo.Controls.Add(this.bt_clear);
            this.gpBox_staffInfo.Controls.Add(this.bt_save);
            this.gpBox_staffInfo.Controls.Add(this.lbl_name);
            this.gpBox_staffInfo.Controls.Add(this.cbBox_city);
            this.gpBox_staffInfo.Controls.Add(this.lbl_name_ch);
            this.gpBox_staffInfo.Controls.Add(this.cbBox_province);
            this.gpBox_staffInfo.Controls.Add(this.txt_address);
            this.gpBox_staffInfo.Controls.Add(this.txt_name);
            this.gpBox_staffInfo.Controls.Add(this.lbl_address);
            this.gpBox_staffInfo.Controls.Add(this.txt_name_ch);
            this.gpBox_staffInfo.Controls.Add(this.lbl_position);
            this.gpBox_staffInfo.Controls.Add(this.txt_teamID);
            this.gpBox_staffInfo.Controls.Add(this.lbl_teamID);
            this.gpBox_staffInfo.Controls.Add(this.cbBox_position);
            this.gpBox_staffInfo.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_staffInfo.Location = new System.Drawing.Point(12, 58);
            this.gpBox_staffInfo.Name = "gpBox_staffInfo";
            this.gpBox_staffInfo.Size = new System.Drawing.Size(378, 290);
            this.gpBox_staffInfo.TabIndex = 24;
            this.gpBox_staffInfo.TabStop = false;
            this.gpBox_staffInfo.Text = "Staff Informations";
            // 
            // linklbl_overview
            // 
            this.linklbl_overview.AutoSize = true;
            this.linklbl_overview.Enabled = false;
            this.linklbl_overview.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linklbl_overview.Location = new System.Drawing.Point(179, 170);
            this.linklbl_overview.Name = "linklbl_overview";
            this.linklbl_overview.Size = new System.Drawing.Size(121, 12);
            this.linklbl_overview.TabIndex = 75;
            this.linklbl_overview.TabStop = true;
            this.linklbl_overview.Text = "Team Member Overview";
            this.linklbl_overview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_overview_LinkClicked);
            // 
            // lbl_name_eng
            // 
            this.lbl_name_eng.AutoSize = true;
            this.lbl_name_eng.Location = new System.Drawing.Point(183, 62);
            this.lbl_name_eng.Name = "lbl_name_eng";
            this.lbl_name_eng.Size = new System.Drawing.Size(46, 15);
            this.lbl_name_eng.TabIndex = 4;
            this.lbl_name_eng.Text = "(ENG)";
            // 
            // gpBox_staffList
            // 
            this.gpBox_staffList.Controls.Add(this.bt_search);
            this.gpBox_staffList.Controls.Add(this.lbl_search_staffID);
            this.gpBox_staffList.Controls.Add(this.dgv_staffList);
            this.gpBox_staffList.Controls.Add(this.txt_search_staffID);
            this.gpBox_staffList.Controls.Add(this.cbBox_search_position);
            this.gpBox_staffList.Controls.Add(this.lbl_search_position);
            this.gpBox_staffList.Controls.Add(this.lbl_search_name);
            this.gpBox_staffList.Controls.Add(this.txt_search_name);
            this.gpBox_staffList.Controls.Add(this.lbl_search_teamID);
            this.gpBox_staffList.Controls.Add(this.txt_search_teamID);
            this.gpBox_staffList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_staffList.Location = new System.Drawing.Point(396, 43);
            this.gpBox_staffList.Name = "gpBox_staffList";
            this.gpBox_staffList.Size = new System.Drawing.Size(552, 504);
            this.gpBox_staffList.TabIndex = 25;
            this.gpBox_staffList.TabStop = false;
            this.gpBox_staffList.Text = "Staff List";
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(456, 22);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(90, 55);
            this.bt_search.TabIndex = 8;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // lbl_search_staffID
            // 
            this.lbl_search_staffID.AutoSize = true;
            this.lbl_search_staffID.Location = new System.Drawing.Point(18, 27);
            this.lbl_search_staffID.Name = "lbl_search_staffID";
            this.lbl_search_staffID.Size = new System.Drawing.Size(58, 15);
            this.lbl_search_staffID.TabIndex = 0;
            this.lbl_search_staffID.Text = "Staff ID:";
            // 
            // dgv_staffList
            // 
            this.dgv_staffList.AllowUserToAddRows = false;
            this.dgv_staffList.AllowUserToDeleteRows = false;
            this.dgv_staffList.AllowUserToResizeColumns = false;
            this.dgv_staffList.AllowUserToResizeRows = false;
            this.dgv_staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_staffList.Location = new System.Drawing.Point(6, 89);
            this.dgv_staffList.Name = "dgv_staffList";
            this.dgv_staffList.RowHeadersVisible = false;
            this.dgv_staffList.RowTemplate.Height = 24;
            this.dgv_staffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_staffList.Size = new System.Drawing.Size(540, 409);
            this.dgv_staffList.TabIndex = 9;
            this.dgv_staffList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staffList_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Staff ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 130F;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Name(Chi)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 130F;
            this.Column4.HeaderText = "Position";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Team ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txt_search_staffID
            // 
            this.txt_search_staffID.Location = new System.Drawing.Point(82, 22);
            this.txt_search_staffID.Name = "txt_search_staffID";
            this.txt_search_staffID.Size = new System.Drawing.Size(111, 25);
            this.txt_search_staffID.TabIndex = 1;
            // 
            // cbBox_search_position
            // 
            this.cbBox_search_position.FormattingEnabled = true;
            this.cbBox_search_position.Location = new System.Drawing.Point(299, 23);
            this.cbBox_search_position.Name = "cbBox_search_position";
            this.cbBox_search_position.Size = new System.Drawing.Size(111, 23);
            this.cbBox_search_position.Sorted = true;
            this.cbBox_search_position.TabIndex = 3;
            // 
            // lbl_search_position
            // 
            this.lbl_search_position.AutoSize = true;
            this.lbl_search_position.Location = new System.Drawing.Point(227, 27);
            this.lbl_search_position.Name = "lbl_search_position";
            this.lbl_search_position.Size = new System.Drawing.Size(57, 15);
            this.lbl_search_position.TabIndex = 2;
            this.lbl_search_position.Text = "Position:";
            // 
            // lbl_search_name
            // 
            this.lbl_search_name.AutoSize = true;
            this.lbl_search_name.Location = new System.Drawing.Point(18, 57);
            this.lbl_search_name.Name = "lbl_search_name";
            this.lbl_search_name.Size = new System.Drawing.Size(48, 15);
            this.lbl_search_name.TabIndex = 4;
            this.lbl_search_name.Text = "Name: ";
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(82, 52);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(111, 25);
            this.txt_search_name.TabIndex = 5;
            // 
            // lbl_search_teamID
            // 
            this.lbl_search_teamID.AutoSize = true;
            this.lbl_search_teamID.Location = new System.Drawing.Point(227, 57);
            this.lbl_search_teamID.Name = "lbl_search_teamID";
            this.lbl_search_teamID.Size = new System.Drawing.Size(62, 15);
            this.lbl_search_teamID.TabIndex = 6;
            this.lbl_search_teamID.Text = "Team ID:";
            // 
            // txt_search_teamID
            // 
            this.txt_search_teamID.Location = new System.Drawing.Point(299, 52);
            this.txt_search_teamID.Name = "txt_search_teamID";
            this.txt_search_teamID.Size = new System.Drawing.Size(111, 25);
            this.txt_search_teamID.TabIndex = 7;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(12, 512);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 26;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 40);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // StaffData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 554);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.gpBox_staffList);
            this.Controls.Add(this.gpBox_staffInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffData";
            this.Text = "StaffData";
            this.Load += new System.EventHandler(this.StaffData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpBox_staffInfo.ResumeLayout(false);
            this.gpBox_staffInfo.PerformLayout();
            this.gpBox_staffList.ResumeLayout(false);
            this.gpBox_staffList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staffList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_staffID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_name_ch;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_teamID;
        private System.Windows.Forms.TextBox txt_staffID;
        private System.Windows.Forms.ComboBox cbBox_position;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_name_ch;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_teamID;
        private System.Windows.Forms.ComboBox cbBox_province;
        private System.Windows.Forms.ComboBox cbBox_city;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpBox_staffInfo;
        private System.Windows.Forms.Label lbl_name_eng;
        private System.Windows.Forms.GroupBox gpBox_staffList;
        private System.Windows.Forms.DataGridView dgv_staffList;
        private System.Windows.Forms.Label lbl_search_staffID;
        private System.Windows.Forms.TextBox txt_search_staffID;
        private System.Windows.Forms.ComboBox cbBox_search_position;
        private System.Windows.Forms.Label lbl_search_position;
        private System.Windows.Forms.Label lbl_search_name;
        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.Label lbl_search_teamID;
        private System.Windows.Forms.TextBox txt_search_teamID;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.LinkLabel linklbl_overview;
    }
}