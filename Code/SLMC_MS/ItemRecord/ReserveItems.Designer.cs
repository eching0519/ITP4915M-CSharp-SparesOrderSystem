namespace SLMC_MS
{
    partial class ReserveItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveItems));
            this.gpBox_Inprogress = new System.Windows.Forms.GroupBox();
            this.dgv_inProgress = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_available = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_name_ch = new System.Windows.Forms.TextBox();
            this.lbl_name_ch = new System.Windows.Forms.Label();
            this.gpBox_reserve = new System.Windows.Forms.GroupBox();
            this.lbl_available = new System.Windows.Forms.Label();
            this.txt_available = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpBox_Inprogress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inProgress)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_available)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpBox_reserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBox_Inprogress
            // 
            this.gpBox_Inprogress.Controls.Add(this.dgv_inProgress);
            this.gpBox_Inprogress.Location = new System.Drawing.Point(418, 43);
            this.gpBox_Inprogress.Margin = new System.Windows.Forms.Padding(4);
            this.gpBox_Inprogress.Name = "gpBox_Inprogress";
            this.gpBox_Inprogress.Padding = new System.Windows.Forms.Padding(4);
            this.gpBox_Inprogress.Size = new System.Drawing.Size(508, 234);
            this.gpBox_Inprogress.TabIndex = 0;
            this.gpBox_Inprogress.TabStop = false;
            this.gpBox_Inprogress.Text = "In progress";
            // 
            // dgv_inProgress
            // 
            this.dgv_inProgress.AllowUserToAddRows = false;
            this.dgv_inProgress.AllowUserToDeleteRows = false;
            this.dgv_inProgress.AllowUserToResizeColumns = false;
            this.dgv_inProgress.AllowUserToResizeRows = false;
            this.dgv_inProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_inProgress.Location = new System.Drawing.Point(12, 22);
            this.dgv_inProgress.MultiSelect = false;
            this.dgv_inProgress.Name = "dgv_inProgress";
            this.dgv_inProgress.RowHeadersVisible = false;
            this.dgv_inProgress.RowTemplate.Height = 24;
            this.dgv_inProgress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_inProgress.Size = new System.Drawing.Size(486, 202);
            this.dgv_inProgress.TabIndex = 69;
            this.dgv_inProgress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inProgress_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ReserveID";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 130F;
            this.Column6.HeaderText = "Item Name";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "QTY";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_available);
            this.groupBox1.Location = new System.Drawing.Point(418, 285);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(508, 234);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Available";
            // 
            // dgv_available
            // 
            this.dgv_available.AllowUserToAddRows = false;
            this.dgv_available.AllowUserToDeleteRows = false;
            this.dgv_available.AllowUserToResizeColumns = false;
            this.dgv_available.AllowUserToResizeRows = false;
            this.dgv_available.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_available.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewButtonColumn1});
            this.dgv_available.Location = new System.Drawing.Point(12, 22);
            this.dgv_available.MultiSelect = false;
            this.dgv_available.Name = "dgv_available";
            this.dgv_available.RowHeadersVisible = false;
            this.dgv_available.RowTemplate.Height = 24;
            this.dgv_available.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_available.Size = new System.Drawing.Size(486, 202);
            this.dgv_available.TabIndex = 77;
            this.dgv_available.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_available_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ReserveID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 130F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 80F;
            this.dataGridViewTextBoxColumn8.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(414, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reserve Record";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(403, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 500);
            this.label2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 40);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Location = new System.Drawing.Point(16, 32);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(52, 15);
            this.lbl_itemID.TabIndex = 69;
            this.lbl_itemID.Text = "Item ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(16, 68);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(83, 15);
            this.lbl_name.TabIndex = 71;
            this.lbl_name.Text = "Name (ENG)";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(111, 27);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(122, 25);
            this.txt_ItemID.TabIndex = 70;
            this.txt_ItemID.TextChanged += new System.EventHandler(this.txt_ItemID_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(111, 63);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(122, 25);
            this.txt_name.TabIndex = 72;
            // 
            // txt_name_ch
            // 
            this.txt_name_ch.Location = new System.Drawing.Point(111, 99);
            this.txt_name_ch.Name = "txt_name_ch";
            this.txt_name_ch.ReadOnly = true;
            this.txt_name_ch.Size = new System.Drawing.Size(122, 25);
            this.txt_name_ch.TabIndex = 74;
            // 
            // lbl_name_ch
            // 
            this.lbl_name_ch.AutoSize = true;
            this.lbl_name_ch.Location = new System.Drawing.Point(54, 104);
            this.lbl_name_ch.Name = "lbl_name_ch";
            this.lbl_name_ch.Size = new System.Drawing.Size(41, 15);
            this.lbl_name_ch.TabIndex = 73;
            this.lbl_name_ch.Text = "(CHI)";
            // 
            // gpBox_reserve
            // 
            this.gpBox_reserve.Controls.Add(this.lbl_available);
            this.gpBox_reserve.Controls.Add(this.txt_available);
            this.gpBox_reserve.Controls.Add(this.bt_clear);
            this.gpBox_reserve.Controls.Add(this.bt_save);
            this.gpBox_reserve.Controls.Add(this.lbl_qty);
            this.gpBox_reserve.Controls.Add(this.txt_qty);
            this.gpBox_reserve.Controls.Add(this.lbl_description);
            this.gpBox_reserve.Controls.Add(this.txt_description);
            this.gpBox_reserve.Controls.Add(this.lbl_name);
            this.gpBox_reserve.Controls.Add(this.lbl_itemID);
            this.gpBox_reserve.Controls.Add(this.lbl_name_ch);
            this.gpBox_reserve.Controls.Add(this.txt_name_ch);
            this.gpBox_reserve.Controls.Add(this.txt_ItemID);
            this.gpBox_reserve.Controls.Add(this.txt_name);
            this.gpBox_reserve.Location = new System.Drawing.Point(33, 77);
            this.gpBox_reserve.Name = "gpBox_reserve";
            this.gpBox_reserve.Size = new System.Drawing.Size(358, 282);
            this.gpBox_reserve.TabIndex = 75;
            this.gpBox_reserve.TabStop = false;
            this.gpBox_reserve.Text = "Reserve Items";
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.Location = new System.Drawing.Point(16, 176);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(61, 15);
            this.lbl_available.TabIndex = 81;
            this.lbl_available.Text = "Available";
            // 
            // txt_available
            // 
            this.txt_available.Location = new System.Drawing.Point(111, 171);
            this.txt_available.Name = "txt_available";
            this.txt_available.ReadOnly = true;
            this.txt_available.Size = new System.Drawing.Size(122, 25);
            this.txt_available.TabIndex = 82;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(266, 243);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 80;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(185, 243);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 79;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(16, 212);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(56, 15);
            this.lbl_qty.TabIndex = 78;
            this.lbl_qty.Text = "Quantity";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(111, 207);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(122, 25);
            this.txt_qty.TabIndex = 77;
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(16, 140);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(72, 15);
            this.lbl_description.TabIndex = 76;
            this.lbl_description.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(111, 135);
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(230, 25);
            this.txt_description.TabIndex = 75;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(33, 484);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 76;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ReserveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 540);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.gpBox_reserve);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBox_Inprogress);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReserveItems";
            this.Text = "ReserveItems";
            this.Load += new System.EventHandler(this.ReserveItems_Load);
            this.gpBox_Inprogress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inProgress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_available)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpBox_reserve.ResumeLayout(false);
            this.gpBox_reserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBox_Inprogress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_inProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_name_ch;
        private System.Windows.Forms.Label lbl_name_ch;
        private System.Windows.Forms.GroupBox gpBox_reserve;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.DataGridView dgv_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.TextBox txt_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}