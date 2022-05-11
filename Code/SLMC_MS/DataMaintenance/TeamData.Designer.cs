namespace SLMC_MS
{
    partial class TeamData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamData));
            this.lbl_search_name = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.lbl_search_teamID = new System.Windows.Forms.Label();
            this.dgv_teamList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search_teamID = new System.Windows.Forms.TextBox();
            this.gpBox_teamList = new System.Windows.Forms.GroupBox();
            this.gpBox_teamInformation = new System.Windows.Forms.GroupBox();
            this.txt_teamID = new System.Windows.Forms.TextBox();
            this.linklbl_overview = new System.Windows.Forms.LinkLabel();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.lbl_position = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.txt_managerName = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.lbl_teamID = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_supAdd = new System.Windows.Forms.Label();
            this.txt_managerID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamList)).BeginInit();
            this.gpBox_teamList.SuspendLayout();
            this.gpBox_teamInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_search_name
            // 
            this.lbl_search_name.AutoSize = true;
            this.lbl_search_name.Location = new System.Drawing.Point(13, 62);
            this.lbl_search_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_name.Name = "lbl_search_name";
            this.lbl_search_name.Size = new System.Drawing.Size(153, 23);
            this.lbl_search_name.TabIndex = 2;
            this.lbl_search_name.Text = "Manager Name:";
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(305, 57);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(120, 25);
            this.bt_search.TabIndex = 4;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(137, 57);
            this.txt_search_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(160, 34);
            this.txt_search_name.TabIndex = 3;
            // 
            // lbl_search_teamID
            // 
            this.lbl_search_teamID.AutoSize = true;
            this.lbl_search_teamID.Location = new System.Drawing.Point(13, 34);
            this.lbl_search_teamID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_teamID.Name = "lbl_search_teamID";
            this.lbl_search_teamID.Size = new System.Drawing.Size(95, 23);
            this.lbl_search_teamID.TabIndex = 0;
            this.lbl_search_teamID.Text = "Team ID:";
            // 
            // dgv_teamList
            // 
            this.dgv_teamList.AllowUserToAddRows = false;
            this.dgv_teamList.AllowUserToDeleteRows = false;
            this.dgv_teamList.AllowUserToResizeColumns = false;
            this.dgv_teamList.AllowUserToResizeRows = false;
            this.dgv_teamList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_teamList.Location = new System.Drawing.Point(16, 86);
            this.dgv_teamList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_teamList.Name = "dgv_teamList";
            this.dgv_teamList.ReadOnly = true;
            this.dgv_teamList.RowHeadersVisible = false;
            this.dgv_teamList.RowTemplate.Height = 24;
            this.dgv_teamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_teamList.Size = new System.Drawing.Size(409, 298);
            this.dgv_teamList.TabIndex = 5;
            this.dgv_teamList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teamList_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Team ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Manager ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "Manager Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txt_search_teamID
            // 
            this.txt_search_teamID.Location = new System.Drawing.Point(137, 29);
            this.txt_search_teamID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search_teamID.Name = "txt_search_teamID";
            this.txt_search_teamID.Size = new System.Drawing.Size(160, 34);
            this.txt_search_teamID.TabIndex = 1;
            // 
            // gpBox_teamList
            // 
            this.gpBox_teamList.Controls.Add(this.dgv_teamList);
            this.gpBox_teamList.Controls.Add(this.lbl_search_name);
            this.gpBox_teamList.Controls.Add(this.txt_search_teamID);
            this.gpBox_teamList.Controls.Add(this.bt_search);
            this.gpBox_teamList.Controls.Add(this.txt_search_name);
            this.gpBox_teamList.Controls.Add(this.lbl_search_teamID);
            this.gpBox_teamList.Location = new System.Drawing.Point(336, 40);
            this.gpBox_teamList.Name = "gpBox_teamList";
            this.gpBox_teamList.Size = new System.Drawing.Size(440, 399);
            this.gpBox_teamList.TabIndex = 70;
            this.gpBox_teamList.TabStop = false;
            this.gpBox_teamList.Text = "Team List";
            // 
            // gpBox_teamInformation
            // 
            this.gpBox_teamInformation.Controls.Add(this.txt_teamID);
            this.gpBox_teamInformation.Controls.Add(this.linklbl_overview);
            this.gpBox_teamInformation.Controls.Add(this.txt_position);
            this.gpBox_teamInformation.Controls.Add(this.lbl_position);
            this.gpBox_teamInformation.Controls.Add(this.bt_clear);
            this.gpBox_teamInformation.Controls.Add(this.txt_managerName);
            this.gpBox_teamInformation.Controls.Add(this.bt_submit);
            this.gpBox_teamInformation.Controls.Add(this.lbl_teamID);
            this.gpBox_teamInformation.Controls.Add(this.lbl_team);
            this.gpBox_teamInformation.Controls.Add(this.lbl_supAdd);
            this.gpBox_teamInformation.Controls.Add(this.txt_managerID);
            this.gpBox_teamInformation.Location = new System.Drawing.Point(40, 87);
            this.gpBox_teamInformation.Name = "gpBox_teamInformation";
            this.gpBox_teamInformation.Size = new System.Drawing.Size(280, 255);
            this.gpBox_teamInformation.TabIndex = 71;
            this.gpBox_teamInformation.TabStop = false;
            this.gpBox_teamInformation.Text = "Team Information";
            // 
            // txt_teamID
            // 
            this.txt_teamID.Location = new System.Drawing.Point(122, 28);
            this.txt_teamID.Name = "txt_teamID";
            this.txt_teamID.Size = new System.Drawing.Size(137, 34);
            this.txt_teamID.TabIndex = 1;
            this.txt_teamID.TextChanged += new System.EventHandler(this.txt_teamID_TextChanged);
            // 
            // linklbl_overview
            // 
            this.linklbl_overview.AutoSize = true;
            this.linklbl_overview.Enabled = false;
            this.linklbl_overview.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linklbl_overview.Location = new System.Drawing.Point(122, 55);
            this.linklbl_overview.Name = "linklbl_overview";
            this.linklbl_overview.Size = new System.Drawing.Size(182, 18);
            this.linklbl_overview.TabIndex = 2;
            this.linklbl_overview.TabStop = true;
            this.linklbl_overview.Text = "Team Member Overview";
            this.linklbl_overview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_overview_LinkClicked);
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(122, 159);
            this.txt_position.Name = "txt_position";
            this.txt_position.ReadOnly = true;
            this.txt_position.Size = new System.Drawing.Size(137, 34);
            this.txt_position.TabIndex = 8;
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(9, 164);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(171, 23);
            this.lbl_position.TabIndex = 7;
            this.lbl_position.Text = "Manager Position:";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(184, 200);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 10;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // txt_managerName
            // 
            this.txt_managerName.Location = new System.Drawing.Point(122, 118);
            this.txt_managerName.Name = "txt_managerName";
            this.txt_managerName.ReadOnly = true;
            this.txt_managerName.Size = new System.Drawing.Size(137, 34);
            this.txt_managerName.TabIndex = 6;
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(107, 200);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 9;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // lbl_teamID
            // 
            this.lbl_teamID.AutoSize = true;
            this.lbl_teamID.Location = new System.Drawing.Point(9, 33);
            this.lbl_teamID.Name = "lbl_teamID";
            this.lbl_teamID.Size = new System.Drawing.Size(95, 23);
            this.lbl_teamID.TabIndex = 0;
            this.lbl_teamID.Text = "Team ID:";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(9, 82);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(123, 23);
            this.lbl_team.TabIndex = 3;
            this.lbl_team.Text = "Manager ID:";
            // 
            // lbl_supAdd
            // 
            this.lbl_supAdd.AutoSize = true;
            this.lbl_supAdd.Location = new System.Drawing.Point(9, 123);
            this.lbl_supAdd.Name = "lbl_supAdd";
            this.lbl_supAdd.Size = new System.Drawing.Size(153, 23);
            this.lbl_supAdd.TabIndex = 5;
            this.lbl_supAdd.Text = "Manager Name:";
            // 
            // txt_managerID
            // 
            this.txt_managerID.Location = new System.Drawing.Point(122, 77);
            this.txt_managerID.Name = "txt_managerID";
            this.txt_managerID.Size = new System.Drawing.Size(137, 34);
            this.txt_managerID.TabIndex = 4;
            this.txt_managerID.TextChanged += new System.EventHandler(this.txt_managerID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 40);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(40, 404);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 73;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TeamData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 466);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBox_teamInformation);
            this.Controls.Add(this.gpBox_teamList);
            this.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamData";
            this.Text = "Team Data";
            this.Load += new System.EventHandler(this.TeamData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamList)).EndInit();
            this.gpBox_teamList.ResumeLayout(false);
            this.gpBox_teamList.PerformLayout();
            this.gpBox_teamInformation.ResumeLayout(false);
            this.gpBox_teamInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_search_name;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.Label lbl_search_teamID;
        private System.Windows.Forms.DataGridView dgv_teamList;
        private System.Windows.Forms.TextBox txt_search_teamID;
        private System.Windows.Forms.GroupBox gpBox_teamList;
        private System.Windows.Forms.GroupBox gpBox_teamInformation;
        private System.Windows.Forms.TextBox txt_managerName;
        private System.Windows.Forms.TextBox txt_teamID;
        private System.Windows.Forms.Label lbl_teamID;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_supAdd;
        private System.Windows.Forms.TextBox txt_managerID;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.LinkLabel linklbl_overview;
    }
}