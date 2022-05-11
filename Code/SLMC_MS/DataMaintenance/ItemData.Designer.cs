namespace SLMC_MS
{
    partial class ItemData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemData));
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_name_ch = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_supplierID = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_name_ch = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.txt_supAdd = new System.Windows.Forms.TextBox();
            this.lbl_supAdd = new System.Windows.Forms.Label();
            this.lbl_selling = new System.Windows.Forms.Label();
            this.lbl_purchase = new System.Windows.Forms.Label();
            this.txt_selling = new System.Windows.Forms.TextBox();
            this.txt_purchase = new System.Windows.Forms.TextBox();
            this.gpBox_itemInfo = new System.Windows.Forms.GroupBox();
            this.link_supplierList = new System.Windows.Forms.LinkLabel();
            this.ck_undefined = new System.Windows.Forms.CheckBox();
            this.gpBox_ItemList = new System.Windows.Forms.GroupBox();
            this.lbl_search_name = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.txt_search_Name = new System.Windows.Forms.TextBox();
            this.lbl_search_itemID = new System.Windows.Forms.Label();
            this.dgv_itemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search_itemID = new System.Windows.Forms.TextBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gpBox_itemInfo.SuspendLayout();
            this.gpBox_ItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Location = new System.Drawing.Point(18, 35);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(56, 15);
            this.lbl_itemID.TabIndex = 0;
            this.lbl_itemID.Text = "Item ID:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(18, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(87, 15);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name: (ENG)";
            // 
            // lbl_name_ch
            // 
            this.lbl_name_ch.AutoSize = true;
            this.lbl_name_ch.Location = new System.Drawing.Point(277, 71);
            this.lbl_name_ch.Name = "lbl_name_ch";
            this.lbl_name_ch.Size = new System.Drawing.Size(41, 15);
            this.lbl_name_ch.TabIndex = 4;
            this.lbl_name_ch.Text = "(CHI)";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(18, 107);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(76, 15);
            this.lbl_desc.TabIndex = 6;
            this.lbl_desc.Text = "Description:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(18, 179);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(84, 15);
            this.lbl_stock.TabIndex = 12;
            this.lbl_stock.Text = "Actual Stock:";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(18, 212);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(90, 15);
            this.lbl_location.TabIndex = 14;
            this.lbl_location.Text = "Located Shelf:";
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Location = new System.Drawing.Point(18, 245);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(74, 15);
            this.lbl_supplierID.TabIndex = 17;
            this.lbl_supplierID.Text = "SupplierID:";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Location = new System.Drawing.Point(18, 353);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(80, 15);
            this.lbl_weight.TabIndex = 23;
            this.lbl_weight.Text = "Weight (kg):";
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(131, 30);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(100, 25);
            this.txt_itemID.TabIndex = 1;
            this.txt_itemID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_itemID_Validating);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(131, 66);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 25);
            this.txt_name.TabIndex = 3;
            this.txt_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_name_Validating);
            // 
            // txt_name_ch
            // 
            this.txt_name_ch.Location = new System.Drawing.Point(316, 66);
            this.txt_name_ch.Name = "txt_name_ch";
            this.txt_name_ch.Size = new System.Drawing.Size(100, 25);
            this.txt_name_ch.TabIndex = 5;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(131, 102);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(314, 25);
            this.txt_desc.TabIndex = 7;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(131, 174);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(71, 25);
            this.txt_stock.TabIndex = 13;
            this.txt_stock.Validating += new System.ComponentModel.CancelEventHandler(this.txt_stock_Validating);
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(213, 207);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(100, 25);
            this.txt_location.TabIndex = 16;
            this.txt_location.Validating += new System.ComponentModel.CancelEventHandler(this.txt_location_Validating);
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.Location = new System.Drawing.Point(131, 240);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(100, 25);
            this.txt_supplierID.TabIndex = 18;
            this.txt_supplierID.TextChanged += new System.EventHandler(this.txt_supplierID_TextChanged);
            this.txt_supplierID.Validating += new System.ComponentModel.CancelEventHandler(this.txt_supplierID_Validating);
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(131, 348);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(100, 25);
            this.txt_weight.TabIndex = 24;
            this.txt_weight.Validating += new System.ComponentModel.CancelEventHandler(this.txt_weight_Validating);
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(18, 281);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(59, 15);
            this.lbl_supplier.TabIndex = 19;
            this.lbl_supplier.Text = "Supplier:";
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(294, 384);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 25;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(370, 384);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 26;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_supplier
            // 
            this.txt_supplier.Location = new System.Drawing.Point(131, 276);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(100, 25);
            this.txt_supplier.TabIndex = 20;
            this.txt_supplier.Validating += new System.ComponentModel.CancelEventHandler(this.txt_supplier_Validating);
            // 
            // txt_supAdd
            // 
            this.txt_supAdd.Location = new System.Drawing.Point(131, 312);
            this.txt_supAdd.Name = "txt_supAdd";
            this.txt_supAdd.Size = new System.Drawing.Size(238, 25);
            this.txt_supAdd.TabIndex = 22;
            this.txt_supAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txt_supAdd_Validating);
            // 
            // lbl_supAdd
            // 
            this.lbl_supAdd.AutoSize = true;
            this.lbl_supAdd.Location = new System.Drawing.Point(18, 317);
            this.lbl_supAdd.Name = "lbl_supAdd";
            this.lbl_supAdd.Size = new System.Drawing.Size(108, 15);
            this.lbl_supAdd.TabIndex = 21;
            this.lbl_supAdd.Text = "Supplier Address:";
            // 
            // lbl_selling
            // 
            this.lbl_selling.AutoSize = true;
            this.lbl_selling.Location = new System.Drawing.Point(18, 143);
            this.lbl_selling.Name = "lbl_selling";
            this.lbl_selling.Size = new System.Drawing.Size(84, 15);
            this.lbl_selling.TabIndex = 8;
            this.lbl_selling.Text = "Selling Price:";
            // 
            // lbl_purchase
            // 
            this.lbl_purchase.AutoSize = true;
            this.lbl_purchase.Location = new System.Drawing.Point(248, 143);
            this.lbl_purchase.Name = "lbl_purchase";
            this.lbl_purchase.Size = new System.Drawing.Size(94, 15);
            this.lbl_purchase.TabIndex = 10;
            this.lbl_purchase.Text = "Purchase Price:";
            // 
            // txt_selling
            // 
            this.txt_selling.Location = new System.Drawing.Point(131, 138);
            this.txt_selling.Name = "txt_selling";
            this.txt_selling.Size = new System.Drawing.Size(100, 25);
            this.txt_selling.TabIndex = 9;
            this.txt_selling.Validating += new System.ComponentModel.CancelEventHandler(this.txt_selling_Validating);
            // 
            // txt_purchase
            // 
            this.txt_purchase.Location = new System.Drawing.Point(345, 138);
            this.txt_purchase.Name = "txt_purchase";
            this.txt_purchase.Size = new System.Drawing.Size(100, 25);
            this.txt_purchase.TabIndex = 11;
            this.txt_purchase.Validating += new System.ComponentModel.CancelEventHandler(this.txt_purchase_Validating);
            // 
            // gpBox_itemInfo
            // 
            this.gpBox_itemInfo.Controls.Add(this.link_supplierList);
            this.gpBox_itemInfo.Controls.Add(this.lbl_itemID);
            this.gpBox_itemInfo.Controls.Add(this.lbl_name);
            this.gpBox_itemInfo.Controls.Add(this.txt_purchase);
            this.gpBox_itemInfo.Controls.Add(this.txt_selling);
            this.gpBox_itemInfo.Controls.Add(this.lbl_desc);
            this.gpBox_itemInfo.Controls.Add(this.lbl_purchase);
            this.gpBox_itemInfo.Controls.Add(this.lbl_stock);
            this.gpBox_itemInfo.Controls.Add(this.lbl_selling);
            this.gpBox_itemInfo.Controls.Add(this.lbl_location);
            this.gpBox_itemInfo.Controls.Add(this.txt_supAdd);
            this.gpBox_itemInfo.Controls.Add(this.lbl_supplierID);
            this.gpBox_itemInfo.Controls.Add(this.lbl_supAdd);
            this.gpBox_itemInfo.Controls.Add(this.lbl_weight);
            this.gpBox_itemInfo.Controls.Add(this.txt_supplier);
            this.gpBox_itemInfo.Controls.Add(this.txt_itemID);
            this.gpBox_itemInfo.Controls.Add(this.bt_clear);
            this.gpBox_itemInfo.Controls.Add(this.txt_name);
            this.gpBox_itemInfo.Controls.Add(this.bt_submit);
            this.gpBox_itemInfo.Controls.Add(this.txt_name_ch);
            this.gpBox_itemInfo.Controls.Add(this.lbl_supplier);
            this.gpBox_itemInfo.Controls.Add(this.txt_desc);
            this.gpBox_itemInfo.Controls.Add(this.txt_weight);
            this.gpBox_itemInfo.Controls.Add(this.txt_stock);
            this.gpBox_itemInfo.Controls.Add(this.txt_supplierID);
            this.gpBox_itemInfo.Controls.Add(this.txt_location);
            this.gpBox_itemInfo.Controls.Add(this.ck_undefined);
            this.gpBox_itemInfo.Controls.Add(this.lbl_name_ch);
            this.gpBox_itemInfo.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_itemInfo.Location = new System.Drawing.Point(54, 85);
            this.gpBox_itemInfo.Name = "gpBox_itemInfo";
            this.gpBox_itemInfo.Size = new System.Drawing.Size(465, 421);
            this.gpBox_itemInfo.TabIndex = 29;
            this.gpBox_itemInfo.TabStop = false;
            this.gpBox_itemInfo.Text = "Item Information";
            // 
            // link_supplierList
            // 
            this.link_supplierList.AutoSize = true;
            this.link_supplierList.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.link_supplierList.Location = new System.Drawing.Point(234, 253);
            this.link_supplierList.Name = "link_supplierList";
            this.link_supplierList.Size = new System.Drawing.Size(103, 12);
            this.link_supplierList.TabIndex = 27;
            this.link_supplierList.TabStop = true;
            this.link_supplierList.Text = "Current Supplier List";
            this.link_supplierList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_supplierList_LinkClicked);
            // 
            // ck_undefined
            // 
            this.ck_undefined.AutoSize = true;
            this.ck_undefined.Location = new System.Drawing.Point(131, 210);
            this.ck_undefined.Name = "ck_undefined";
            this.ck_undefined.Size = new System.Drawing.Size(82, 19);
            this.ck_undefined.TabIndex = 15;
            this.ck_undefined.Text = "undefined";
            this.ck_undefined.UseVisualStyleBackColor = true;
            this.ck_undefined.CheckedChanged += new System.EventHandler(this.ck_undefined_CheckedChanged);
            // 
            // gpBox_ItemList
            // 
            this.gpBox_ItemList.Controls.Add(this.lbl_search_name);
            this.gpBox_ItemList.Controls.Add(this.bt_search);
            this.gpBox_ItemList.Controls.Add(this.txt_search_Name);
            this.gpBox_ItemList.Controls.Add(this.lbl_search_itemID);
            this.gpBox_ItemList.Controls.Add(this.dgv_itemList);
            this.gpBox_ItemList.Controls.Add(this.txt_search_itemID);
            this.gpBox_ItemList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_ItemList.Location = new System.Drawing.Point(542, 39);
            this.gpBox_ItemList.Name = "gpBox_ItemList";
            this.gpBox_ItemList.Size = new System.Drawing.Size(562, 518);
            this.gpBox_ItemList.TabIndex = 31;
            this.gpBox_ItemList.TabStop = false;
            this.gpBox_ItemList.Text = "Item List";
            // 
            // lbl_search_name
            // 
            this.lbl_search_name.AutoSize = true;
            this.lbl_search_name.Location = new System.Drawing.Point(242, 29);
            this.lbl_search_name.Name = "lbl_search_name";
            this.lbl_search_name.Size = new System.Drawing.Size(74, 15);
            this.lbl_search_name.TabIndex = 68;
            this.lbl_search_name.Text = "Item Name:";
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(461, 24);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(90, 25);
            this.bt_search.TabIndex = 8;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // txt_search_Name
            // 
            this.txt_search_Name.Location = new System.Drawing.Point(322, 24);
            this.txt_search_Name.Name = "txt_search_Name";
            this.txt_search_Name.Size = new System.Drawing.Size(112, 25);
            this.txt_search_Name.TabIndex = 69;
            // 
            // lbl_search_itemID
            // 
            this.lbl_search_itemID.AutoSize = true;
            this.lbl_search_itemID.Location = new System.Drawing.Point(11, 29);
            this.lbl_search_itemID.Name = "lbl_search_itemID";
            this.lbl_search_itemID.Size = new System.Drawing.Size(56, 15);
            this.lbl_search_itemID.TabIndex = 0;
            this.lbl_search_itemID.Text = "Item ID:";
            // 
            // dgv_itemList
            // 
            this.dgv_itemList.AllowUserToAddRows = false;
            this.dgv_itemList.AllowUserToDeleteRows = false;
            this.dgv_itemList.AllowUserToResizeColumns = false;
            this.dgv_itemList.AllowUserToResizeRows = false;
            this.dgv_itemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_itemList.Location = new System.Drawing.Point(11, 55);
            this.dgv_itemList.Name = "dgv_itemList";
            this.dgv_itemList.ReadOnly = true;
            this.dgv_itemList.RowHeadersVisible = false;
            this.dgv_itemList.RowTemplate.Height = 24;
            this.dgv_itemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemList.Size = new System.Drawing.Size(540, 453);
            this.dgv_itemList.TabIndex = 9;
            this.dgv_itemList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemList_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item ID";
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
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Location";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Selling Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Purchase Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txt_search_itemID
            // 
            this.txt_search_itemID.Location = new System.Drawing.Point(78, 24);
            this.txt_search_itemID.Name = "txt_search_itemID";
            this.txt_search_itemID.Size = new System.Drawing.Size(121, 25);
            this.txt_search_itemID.TabIndex = 1;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(54, 522);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 67;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 40);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // ItemData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 565);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.gpBox_ItemList);
            this.Controls.Add(this.gpBox_itemInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemData";
            this.Text = "ItemData";
            this.Load += new System.EventHandler(this.ItemData_Load);
            this.Shown += new System.EventHandler(this.ItemData_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gpBox_itemInfo.ResumeLayout(false);
            this.gpBox_itemInfo.PerformLayout();
            this.gpBox_ItemList.ResumeLayout(false);
            this.gpBox_ItemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_name_ch;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_supplierID;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_name_ch;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_supAdd;
        private System.Windows.Forms.Label lbl_supAdd;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.TextBox txt_purchase;
        private System.Windows.Forms.TextBox txt_selling;
        private System.Windows.Forms.Label lbl_purchase;
        private System.Windows.Forms.Label lbl_selling;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpBox_itemInfo;
        private System.Windows.Forms.CheckBox ck_undefined;
        private System.Windows.Forms.GroupBox gpBox_ItemList;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label lbl_search_itemID;
        private System.Windows.Forms.DataGridView dgv_itemList;
        private System.Windows.Forms.TextBox txt_search_itemID;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lbl_search_name;
        private System.Windows.Forms.TextBox txt_search_Name;
        private System.Windows.Forms.LinkLabel link_supplierList;
    }
}