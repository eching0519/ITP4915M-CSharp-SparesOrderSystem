namespace SLMC_MS
{
    partial class GoodReceivedNote
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodReceivedNote));
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lbl_supplierID = new System.Windows.Forms.Label();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpBox_itemInfo = new System.Windows.Forms.GroupBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.dgv_itemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bt_create = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpBox_itemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_itemID.Location = new System.Drawing.Point(20, 33);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(48, 15);
            this.lbl_itemID.TabIndex = 0;
            this.lbl_itemID.Text = "ItemID";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_qty.Location = new System.Drawing.Point(20, 138);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(56, 15);
            this.lbl_qty.TabIndex = 1;
            this.lbl_qty.Text = "Quantity";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ItemID.Location = new System.Drawing.Point(94, 28);
            this.txt_ItemID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.ReadOnly = true;
            this.txt_ItemID.Size = new System.Drawing.Size(132, 25);
            this.txt_ItemID.TabIndex = 2;
            this.txt_ItemID.TextChanged += new System.EventHandler(this.txt_ItemID_TextChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_qty.Location = new System.Drawing.Point(94, 133);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.ReadOnly = true;
            this.txt_qty.Size = new System.Drawing.Size(132, 25);
            this.txt_qty.TabIndex = 3;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // bt_submit
            // 
            this.bt_submit.Enabled = false;
            this.bt_submit.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_submit.Location = new System.Drawing.Point(401, 489);
            this.bt_submit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(115, 35);
            this.bt_submit.TabIndex = 4;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(94, 63);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(132, 25);
            this.txt_Name.TabIndex = 7;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_name.Location = new System.Drawing.Point(20, 68);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 15);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Item Name";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_description.Location = new System.Drawing.Point(20, 103);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(72, 15);
            this.lbl_description.TabIndex = 9;
            this.lbl_description.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_description.Location = new System.Drawing.Point(94, 98);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(132, 25);
            this.txt_description.TabIndex = 10;
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_supplierID.Location = new System.Drawing.Point(46, 90);
            this.lbl_supplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(74, 15);
            this.lbl_supplierID.TabIndex = 13;
            this.lbl_supplierID.Text = "Supplier ID";
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_supplierID.Location = new System.Drawing.Point(140, 85);
            this.txt_supplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(132, 25);
            this.txt_supplierID.TabIndex = 14;
            this.txt_supplierID.TextChanged += new System.EventHandler(this.txt_supplierID_TextChanged);
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_supplier.Location = new System.Drawing.Point(46, 123);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(55, 15);
            this.lbl_supplier.TabIndex = 78;
            this.lbl_supplier.Text = "Supplier";
            // 
            // txt_supplier
            // 
            this.txt_supplier.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_supplier.Location = new System.Drawing.Point(140, 118);
            this.txt_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(132, 25);
            this.txt_supplier.TabIndex = 79;
            this.txt_supplier.TextChanged += new System.EventHandler(this.txt_supplier_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gpBox_itemInfo
            // 
            this.gpBox_itemInfo.Controls.Add(this.bt_add);
            this.gpBox_itemInfo.Controls.Add(this.txt_ItemID);
            this.gpBox_itemInfo.Controls.Add(this.lbl_itemID);
            this.gpBox_itemInfo.Controls.Add(this.lbl_qty);
            this.gpBox_itemInfo.Controls.Add(this.txt_qty);
            this.gpBox_itemInfo.Controls.Add(this.txt_Name);
            this.gpBox_itemInfo.Controls.Add(this.txt_description);
            this.gpBox_itemInfo.Controls.Add(this.lbl_name);
            this.gpBox_itemInfo.Controls.Add(this.lbl_description);
            this.gpBox_itemInfo.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_itemInfo.Location = new System.Drawing.Point(533, 151);
            this.gpBox_itemInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gpBox_itemInfo.Name = "gpBox_itemInfo";
            this.gpBox_itemInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gpBox_itemInfo.Size = new System.Drawing.Size(253, 209);
            this.gpBox_itemInfo.TabIndex = 80;
            this.gpBox_itemInfo.TabStop = false;
            // 
            // bt_add
            // 
            this.bt_add.Enabled = false;
            this.bt_add.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_add.Location = new System.Drawing.Point(126, 166);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(100, 29);
            this.bt_add.TabIndex = 81;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dgv_itemList
            // 
            this.dgv_itemList.AllowUserToAddRows = false;
            this.dgv_itemList.AllowUserToResizeColumns = false;
            this.dgv_itemList.AllowUserToResizeRows = false;
            this.dgv_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_itemList.Enabled = false;
            this.dgv_itemList.Location = new System.Drawing.Point(46, 151);
            this.dgv_itemList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_itemList.Name = "dgv_itemList";
            this.dgv_itemList.RowHeadersVisible = false;
            this.dgv_itemList.RowTemplate.Height = 24;
            this.dgv_itemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemList.Size = new System.Drawing.Size(470, 330);
            this.dgv_itemList.TabIndex = 81;
            this.dgv_itemList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_itemList_CellBeginEdit);
            this.dgv_itemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemList_CellContentClick);
            this.dgv_itemList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemList_CellValueChanged);
            this.dgv_itemList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_itemList_RowsAdded);
            this.dgv_itemList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_itemList_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Item Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            // 
            // bt_create
            // 
            this.bt_create.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_create.Location = new System.Drawing.Point(324, 83);
            this.bt_create.Margin = new System.Windows.Forms.Padding(4);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(100, 29);
            this.bt_create.TabIndex = 82;
            this.bt_create.Text = "Create Note";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_clear.Location = new System.Drawing.Point(324, 116);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(100, 29);
            this.bt_clear.TabIndex = 83;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 40);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(46, 489);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 94;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // GoodReceivedNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 562);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBox_itemInfo);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.lbl_supplierID);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.txt_supplierID);
            this.Controls.Add(this.dgv_itemList);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodReceivedNote";
            this.Text = "GoodReceivedNote";
            this.Load += new System.EventHandler(this.GoodReceivedNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpBox_itemInfo.ResumeLayout(false);
            this.gpBox_itemInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_supplierID;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.GroupBox gpBox_itemInfo;
        private System.Windows.Forms.DataGridView dgv_itemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
    }
}