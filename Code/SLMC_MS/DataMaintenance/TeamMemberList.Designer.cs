namespace SLMC_MS
{
    partial class TeamMemberList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamMemberList));
            this.dgv_memberList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_teamID = new System.Windows.Forms.TextBox();
            this.txt_managerName = new System.Windows.Forms.TextBox();
            this.lbl_teamID = new System.Windows.Forms.Label();
            this.lbl_team = new System.Windows.Forms.Label();
            this.lbl_supAdd = new System.Windows.Forms.Label();
            this.txt_managerID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_memberList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_memberList
            // 
            this.dgv_memberList.AllowUserToAddRows = false;
            this.dgv_memberList.AllowUserToDeleteRows = false;
            this.dgv_memberList.AllowUserToResizeColumns = false;
            this.dgv_memberList.AllowUserToResizeRows = false;
            this.dgv_memberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_memberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_memberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_memberList.Location = new System.Drawing.Point(23, 100);
            this.dgv_memberList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_memberList.Name = "dgv_memberList";
            this.dgv_memberList.ReadOnly = true;
            this.dgv_memberList.RowHeadersVisible = false;
            this.dgv_memberList.RowTemplate.Height = 24;
            this.dgv_memberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_memberList.Size = new System.Drawing.Size(664, 400);
            this.dgv_memberList.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Staff ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Position";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "City";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 200F;
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txt_teamID
            // 
            this.txt_teamID.Location = new System.Drawing.Point(139, 12);
            this.txt_teamID.Name = "txt_teamID";
            this.txt_teamID.Size = new System.Drawing.Size(137, 34);
            this.txt_teamID.TabIndex = 79;
            this.txt_teamID.TextChanged += new System.EventHandler(this.txt_teamID_TextChanged);
            // 
            // txt_managerName
            // 
            this.txt_managerName.Location = new System.Drawing.Point(139, 68);
            this.txt_managerName.Name = "txt_managerName";
            this.txt_managerName.ReadOnly = true;
            this.txt_managerName.Size = new System.Drawing.Size(137, 34);
            this.txt_managerName.TabIndex = 83;
            // 
            // lbl_teamID
            // 
            this.lbl_teamID.AutoSize = true;
            this.lbl_teamID.Location = new System.Drawing.Point(23, 17);
            this.lbl_teamID.Name = "lbl_teamID";
            this.lbl_teamID.Size = new System.Drawing.Size(95, 23);
            this.lbl_teamID.TabIndex = 78;
            this.lbl_teamID.Text = "Team ID:";
            // 
            // lbl_team
            // 
            this.lbl_team.AutoSize = true;
            this.lbl_team.Location = new System.Drawing.Point(23, 45);
            this.lbl_team.Name = "lbl_team";
            this.lbl_team.Size = new System.Drawing.Size(123, 23);
            this.lbl_team.TabIndex = 80;
            this.lbl_team.Text = "Manager ID:";
            // 
            // lbl_supAdd
            // 
            this.lbl_supAdd.AutoSize = true;
            this.lbl_supAdd.Location = new System.Drawing.Point(23, 73);
            this.lbl_supAdd.Name = "lbl_supAdd";
            this.lbl_supAdd.Size = new System.Drawing.Size(153, 23);
            this.lbl_supAdd.TabIndex = 82;
            this.lbl_supAdd.Text = "Manager Name:";
            // 
            // txt_managerID
            // 
            this.txt_managerID.Location = new System.Drawing.Point(139, 40);
            this.txt_managerID.Name = "txt_managerID";
            this.txt_managerID.ReadOnly = true;
            this.txt_managerID.Size = new System.Drawing.Size(137, 34);
            this.txt_managerID.TabIndex = 81;
            // 
            // TeamMemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 513);
            this.Controls.Add(this.txt_teamID);
            this.Controls.Add(this.txt_managerName);
            this.Controls.Add(this.lbl_teamID);
            this.Controls.Add(this.lbl_team);
            this.Controls.Add(this.lbl_supAdd);
            this.Controls.Add(this.txt_managerID);
            this.Controls.Add(this.dgv_memberList);
            this.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeamMemberList";
            this.Text = "Team Member List";
            this.Load += new System.EventHandler(this.TeamMemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_memberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_memberList;
        private System.Windows.Forms.TextBox txt_teamID;
        private System.Windows.Forms.TextBox txt_managerName;
        private System.Windows.Forms.Label lbl_teamID;
        private System.Windows.Forms.Label lbl_team;
        private System.Windows.Forms.Label lbl_supAdd;
        private System.Windows.Forms.TextBox txt_managerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}