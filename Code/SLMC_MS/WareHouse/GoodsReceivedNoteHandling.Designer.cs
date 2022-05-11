namespace SLMC_MS
{
    partial class GoodsReceivedNoteHandling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsReceivedNoteHandling));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_GRNList = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_grnDetails = new System.Windows.Forms.Panel();
            this.lbl_noteID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.lbl_inwardDate = new System.Windows.Forms.Label();
            this.dgv_itemList = new System.Windows.Forms.DataGridView();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            this.txt_inwardDate = new System.Windows.Forms.TextBox();
            this.lbl_supplierID = new System.Windows.Forms.Label();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.bt_create = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GRNList)).BeginInit();
            this.panel_grnDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_GRNList
            // 
            this.dgv_GRNList.AllowUserToAddRows = false;
            this.dgv_GRNList.AllowUserToDeleteRows = false;
            this.dgv_GRNList.AllowUserToResizeColumns = false;
            this.dgv_GRNList.AllowUserToResizeRows = false;
            this.dgv_GRNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GRNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_GRNList.Location = new System.Drawing.Point(62, 105);
            this.dgv_GRNList.Name = "dgv_GRNList";
            this.dgv_GRNList.RowHeadersVisible = false;
            this.dgv_GRNList.RowTemplate.Height = 24;
            this.dgv_GRNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GRNList.Size = new System.Drawing.Size(510, 336);
            this.dgv_GRNList.TabIndex = 0;
            this.dgv_GRNList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GRNList_CellDoubleClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "noteID";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Inward Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Supplier ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Supplier";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 66;
            // 
            // panel_grnDetails
            // 
            this.panel_grnDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_grnDetails.Controls.Add(this.lbl_noteID);
            this.panel_grnDetails.Controls.Add(this.label1);
            this.panel_grnDetails.Controls.Add(this.bt_update);
            this.panel_grnDetails.Controls.Add(this.lbl_inwardDate);
            this.panel_grnDetails.Controls.Add(this.dgv_itemList);
            this.panel_grnDetails.Controls.Add(this.txt_supplierID);
            this.panel_grnDetails.Controls.Add(this.txt_inwardDate);
            this.panel_grnDetails.Controls.Add(this.lbl_supplierID);
            this.panel_grnDetails.Controls.Add(this.txt_supplier);
            this.panel_grnDetails.Controls.Add(this.lbl_supplier);
            this.panel_grnDetails.Location = new System.Drawing.Point(75, 38);
            this.panel_grnDetails.Name = "panel_grnDetails";
            this.panel_grnDetails.Size = new System.Drawing.Size(484, 465);
            this.panel_grnDetails.TabIndex = 1;
            this.panel_grnDetails.Visible = false;
            this.panel_grnDetails.VisibleChanged += new System.EventHandler(this.panel_grnDetails_VisibleChanged);
            this.panel_grnDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_grnDetails_MouseDown);
            this.panel_grnDetails.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_grnDetails_MouseMove);
            // 
            // lbl_noteID
            // 
            this.lbl_noteID.AutoSize = true;
            this.lbl_noteID.Location = new System.Drawing.Point(0, 0);
            this.lbl_noteID.Name = "lbl_noteID";
            this.lbl_noteID.Size = new System.Drawing.Size(46, 15);
            this.lbl_noteID.TabIndex = 92;
            this.lbl_noteID.Text = "noteID";
            this.lbl_noteID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 91;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(310, 404);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(110, 23);
            this.bt_update.TabIndex = 89;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // lbl_inwardDate
            // 
            this.lbl_inwardDate.AutoSize = true;
            this.lbl_inwardDate.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_inwardDate.Location = new System.Drawing.Point(63, 99);
            this.lbl_inwardDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inwardDate.Name = "lbl_inwardDate";
            this.lbl_inwardDate.Size = new System.Drawing.Size(33, 15);
            this.lbl_inwardDate.TabIndex = 87;
            this.lbl_inwardDate.Text = "Date";
            // 
            // dgv_itemList
            // 
            this.dgv_itemList.AllowUserToAddRows = false;
            this.dgv_itemList.AllowUserToResizeColumns = false;
            this.dgv_itemList.AllowUserToResizeRows = false;
            this.dgv_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_itemList.Location = new System.Drawing.Point(63, 127);
            this.dgv_itemList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_itemList.Name = "dgv_itemList";
            this.dgv_itemList.RowHeadersVisible = false;
            this.dgv_itemList.RowTemplate.Height = 24;
            this.dgv_itemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemList.Size = new System.Drawing.Size(357, 270);
            this.dgv_itemList.TabIndex = 82;
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_supplierID.Location = new System.Drawing.Point(178, 28);
            this.txt_supplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.ReadOnly = true;
            this.txt_supplierID.Size = new System.Drawing.Size(132, 25);
            this.txt_supplierID.TabIndex = 84;
            // 
            // txt_inwardDate
            // 
            this.txt_inwardDate.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_inwardDate.Location = new System.Drawing.Point(178, 94);
            this.txt_inwardDate.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inwardDate.Name = "txt_inwardDate";
            this.txt_inwardDate.ReadOnly = true;
            this.txt_inwardDate.Size = new System.Drawing.Size(132, 25);
            this.txt_inwardDate.TabIndex = 88;
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_supplierID.Location = new System.Drawing.Point(63, 33);
            this.lbl_supplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(74, 15);
            this.lbl_supplierID.TabIndex = 83;
            this.lbl_supplierID.Text = "Supplier ID";
            // 
            // txt_supplier
            // 
            this.txt_supplier.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_supplier.Location = new System.Drawing.Point(178, 61);
            this.txt_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.ReadOnly = true;
            this.txt_supplier.Size = new System.Drawing.Size(132, 25);
            this.txt_supplier.TabIndex = 86;
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_supplier.Location = new System.Drawing.Point(63, 66);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(55, 15);
            this.lbl_supplier.TabIndex = 85;
            this.lbl_supplier.Text = "Supplier";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 40);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(62, 447);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 93;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(422, 59);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(150, 40);
            this.bt_create.TabIndex = 94;
            this.bt_create.Text = "Create GRN";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // GoodsReceivedNoteHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 541);
            this.Controls.Add(this.panel_grnDetails);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.dgv_GRNList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBox_return);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodsReceivedNoteHandling";
            this.Text = "Goods Receiving Confirmation";
            this.Load += new System.EventHandler(this.GoodsReceivedNoteHandling_Load);
            this.VisibleChanged += new System.EventHandler(this.GoodsReceivedNoteHandling_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GRNList)).EndInit();
            this.panel_grnDetails.ResumeLayout(false);
            this.panel_grnDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_GRNList;
        private System.Windows.Forms.Panel panel_grnDetails;
        private System.Windows.Forms.DataGridView dgv_itemList;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.Label lbl_supplierID;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label lbl_inwardDate;
        private System.Windows.Forms.TextBox txt_inwardDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbl_noteID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}