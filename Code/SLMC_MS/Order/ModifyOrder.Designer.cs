namespace SLMC_MS
{
    partial class ModifyOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyOrder));
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_orderDate = new System.Windows.Forms.Label();
            this.gpBox_itemList = new System.Windows.Forms.GroupBox();
            this.dataGridView_itemList = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_itemDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.lbl_availableQty = new System.Windows.Forms.Label();
            this.lbl_weightAmt = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_totalAmt = new System.Windows.Forms.Label();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.bt_addItem = new System.Windows.Forms.Button();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_available = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.dtp_orderDate = new System.Windows.Forms.DateTimePicker();
            this.gpBox_dealer = new System.Windows.Forms.GroupBox();
            this.lbl_dealerID = new System.Windows.Forms.Label();
            this.lbl_dealerName = new System.Windows.Forms.Label();
            this.txt_dealerID = new System.Windows.Forms.TextBox();
            this.txt_dealerName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_recAdd = new System.Windows.Forms.TextBox();
            this.cbBox_recAdd_city = new System.Windows.Forms.ComboBox();
            this.lbl_invName = new System.Windows.Forms.Label();
            this.cbBox_recAdd_province = new System.Windows.Forms.ComboBox();
            this.lbl_expectDate = new System.Windows.Forms.Label();
            this.lbl_recAdd = new System.Windows.Forms.Label();
            this.lbl_invAdd = new System.Windows.Forms.Label();
            this.txt_invName = new System.Windows.Forms.TextBox();
            this.txt_invAdd = new System.Windows.Forms.TextBox();
            this.dtp_expectDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_orderID_No = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_orderStatus = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpBox_itemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itemList)).BeginInit();
            this.gpBox_dealer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_orderID.Location = new System.Drawing.Point(56, 90);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(63, 15);
            this.lbl_orderID.TabIndex = 0;
            this.lbl_orderID.Text = "Order ID:";
            // 
            // lbl_orderDate
            // 
            this.lbl_orderDate.AutoSize = true;
            this.lbl_orderDate.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_orderDate.Location = new System.Drawing.Point(464, 90);
            this.lbl_orderDate.Name = "lbl_orderDate";
            this.lbl_orderDate.Size = new System.Drawing.Size(74, 15);
            this.lbl_orderDate.TabIndex = 4;
            this.lbl_orderDate.Text = "Order Date:";
            // 
            // gpBox_itemList
            // 
            this.gpBox_itemList.Controls.Add(this.dataGridView_itemList);
            this.gpBox_itemList.Controls.Add(this.txt_item);
            this.gpBox_itemList.Controls.Add(this.lbl_availableQty);
            this.gpBox_itemList.Controls.Add(this.lbl_weightAmt);
            this.gpBox_itemList.Controls.Add(this.lbl_price);
            this.gpBox_itemList.Controls.Add(this.lbl_kg);
            this.gpBox_itemList.Controls.Add(this.lbl_weight);
            this.gpBox_itemList.Controls.Add(this.txt_qty);
            this.gpBox_itemList.Controls.Add(this.lbl_totalAmt);
            this.gpBox_itemList.Controls.Add(this.txt_itemID);
            this.gpBox_itemList.Controls.Add(this.lbl_total);
            this.gpBox_itemList.Controls.Add(this.bt_addItem);
            this.gpBox_itemList.Controls.Add(this.lbl_qty);
            this.gpBox_itemList.Controls.Add(this.lbl_available);
            this.gpBox_itemList.Controls.Add(this.lbl_itemid);
            this.gpBox_itemList.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_itemList.Location = new System.Drawing.Point(56, 338);
            this.gpBox_itemList.Name = "gpBox_itemList";
            this.gpBox_itemList.Size = new System.Drawing.Size(653, 255);
            this.gpBox_itemList.TabIndex = 8;
            this.gpBox_itemList.TabStop = false;
            this.gpBox_itemList.Text = "Item List";
            // 
            // dataGridView_itemList
            // 
            this.dataGridView_itemList.AllowUserToAddRows = false;
            this.dataGridView_itemList.AllowUserToDeleteRows = false;
            this.dataGridView_itemList.AllowUserToResizeColumns = false;
            this.dataGridView_itemList.AllowUserToResizeRows = false;
            this.dataGridView_itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.Available,
            this.QTY,
            this.price,
            this.Subtotal,
            this.bt_itemDel,
            this.weight});
            this.dataGridView_itemList.Enabled = false;
            this.dataGridView_itemList.Location = new System.Drawing.Point(12, 53);
            this.dataGridView_itemList.Name = "dataGridView_itemList";
            this.dataGridView_itemList.RowHeadersVisible = false;
            this.dataGridView_itemList.RowTemplate.Height = 24;
            this.dataGridView_itemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_itemList.Size = new System.Drawing.Size(619, 173);
            this.dataGridView_itemList.TabIndex = 9;
            this.dataGridView_itemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_itemList_CellContentClick);
            this.dataGridView_itemList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_itemList_CellValueChanged);
            this.dataGridView_itemList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_itemList_RowsAdded);
            this.dataGridView_itemList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_itemList_RowsRemoved);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "itemID";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // Available
            // 
            this.Available.HeaderText = "Available";
            this.Available.Name = "Available";
            this.Available.Visible = false;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.Visible = false;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal(¥)";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // bt_itemDel
            // 
            this.bt_itemDel.HeaderText = "";
            this.bt_itemDel.Name = "bt_itemDel";
            this.bt_itemDel.ReadOnly = true;
            this.bt_itemDel.Text = "";
            // 
            // weight
            // 
            this.weight.HeaderText = "weight";
            this.weight.Name = "weight";
            this.weight.Visible = false;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(155, 23);
            this.txt_item.Name = "txt_item";
            this.txt_item.ReadOnly = true;
            this.txt_item.Size = new System.Drawing.Size(112, 25);
            this.txt_item.TabIndex = 16;
            // 
            // lbl_availableQty
            // 
            this.lbl_availableQty.AutoSize = true;
            this.lbl_availableQty.Location = new System.Drawing.Point(410, 28);
            this.lbl_availableQty.Name = "lbl_availableQty";
            this.lbl_availableQty.Size = new System.Drawing.Size(0, 15);
            this.lbl_availableQty.TabIndex = 5;
            this.lbl_availableQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_weightAmt
            // 
            this.lbl_weightAmt.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_weightAmt.Location = new System.Drawing.Point(72, 229);
            this.lbl_weightAmt.Name = "lbl_weightAmt";
            this.lbl_weightAmt.Size = new System.Drawing.Size(75, 15);
            this.lbl_weightAmt.TabIndex = 11;
            this.lbl_weightAmt.Text = "0";
            this.lbl_weightAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_price
            // 
            this.lbl_price.Location = new System.Drawing.Point(272, 24);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(66, 22);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_kg.Location = new System.Drawing.Point(147, 229);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(23, 15);
            this.lbl_kg.TabIndex = 12;
            this.lbl_kg.Text = "kg";
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_weight.Location = new System.Drawing.Point(11, 229);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(59, 15);
            this.lbl_weight.TabIndex = 10;
            this.lbl_weight.Text = "Weight:";
            // 
            // txt_qty
            // 
            this.txt_qty.Enabled = false;
            this.txt_qty.Location = new System.Drawing.Point(508, 23);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(49, 25);
            this.txt_qty.TabIndex = 7;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // lbl_totalAmt
            // 
            this.lbl_totalAmt.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_totalAmt.Location = new System.Drawing.Point(544, 229);
            this.lbl_totalAmt.Name = "lbl_totalAmt";
            this.lbl_totalAmt.Size = new System.Drawing.Size(90, 15);
            this.lbl_totalAmt.TabIndex = 14;
            this.lbl_totalAmt.Text = "0.00";
            this.lbl_totalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Enabled = false;
            this.txt_itemID.Location = new System.Drawing.Point(70, 23);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(80, 25);
            this.txt_itemID.TabIndex = 1;
            this.txt_itemID.TextChanged += new System.EventHandler(this.txt_itemID_TextChanged);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_total.Location = new System.Drawing.Point(480, 229);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(62, 15);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "Total: ¥";
            // 
            // bt_addItem
            // 
            this.bt_addItem.Enabled = false;
            this.bt_addItem.Location = new System.Drawing.Point(563, 23);
            this.bt_addItem.Name = "bt_addItem";
            this.bt_addItem.Size = new System.Drawing.Size(68, 25);
            this.bt_addItem.TabIndex = 8;
            this.bt_addItem.Text = "Add";
            this.bt_addItem.UseVisualStyleBackColor = true;
            this.bt_addItem.Click += new System.EventHandler(this.bt_addItem_Click);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(466, 28);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(40, 15);
            this.lbl_qty.TabIndex = 6;
            this.lbl_qty.Text = "QTY:";
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.Location = new System.Drawing.Point(344, 28);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(65, 15);
            this.lbl_available.TabIndex = 4;
            this.lbl_available.Text = "Available:";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Location = new System.Drawing.Point(12, 28);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(56, 15);
            this.lbl_itemid.TabIndex = 0;
            this.lbl_itemid.Text = "Item ID:";
            // 
            // bt_submit
            // 
            this.bt_submit.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_submit.Location = new System.Drawing.Point(517, 599);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(87, 35);
            this.bt_submit.TabIndex = 9;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_reset.Location = new System.Drawing.Point(617, 599);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(87, 35);
            this.bt_reset.TabIndex = 10;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.CustomFormat = " dd / MM / yyyy";
            this.dtp_orderDate.Enabled = false;
            this.dtp_orderDate.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_orderDate.Location = new System.Drawing.Point(541, 85);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(170, 25);
            this.dtp_orderDate.TabIndex = 5;
            // 
            // gpBox_dealer
            // 
            this.gpBox_dealer.Controls.Add(this.lbl_dealerID);
            this.gpBox_dealer.Controls.Add(this.lbl_dealerName);
            this.gpBox_dealer.Controls.Add(this.txt_dealerID);
            this.gpBox_dealer.Controls.Add(this.txt_dealerName);
            this.gpBox_dealer.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_dealer.Location = new System.Drawing.Point(56, 117);
            this.gpBox_dealer.Name = "gpBox_dealer";
            this.gpBox_dealer.Size = new System.Drawing.Size(654, 57);
            this.gpBox_dealer.TabIndex = 6;
            this.gpBox_dealer.TabStop = false;
            this.gpBox_dealer.Text = "Dealer Information";
            // 
            // lbl_dealerID
            // 
            this.lbl_dealerID.AutoSize = true;
            this.lbl_dealerID.Location = new System.Drawing.Point(42, 27);
            this.lbl_dealerID.Name = "lbl_dealerID";
            this.lbl_dealerID.Size = new System.Drawing.Size(67, 15);
            this.lbl_dealerID.TabIndex = 0;
            this.lbl_dealerID.Text = "Dealer ID:";
            // 
            // lbl_dealerName
            // 
            this.lbl_dealerName.AutoSize = true;
            this.lbl_dealerName.Location = new System.Drawing.Point(246, 27);
            this.lbl_dealerName.Name = "lbl_dealerName";
            this.lbl_dealerName.Size = new System.Drawing.Size(85, 15);
            this.lbl_dealerName.TabIndex = 2;
            this.lbl_dealerName.Text = "Dealer Name:";
            // 
            // txt_dealerID
            // 
            this.txt_dealerID.Location = new System.Drawing.Point(121, 22);
            this.txt_dealerID.Name = "txt_dealerID";
            this.txt_dealerID.ReadOnly = true;
            this.txt_dealerID.Size = new System.Drawing.Size(100, 25);
            this.txt_dealerID.TabIndex = 1;
            // 
            // txt_dealerName
            // 
            this.txt_dealerName.Location = new System.Drawing.Point(340, 22);
            this.txt_dealerName.Name = "txt_dealerName";
            this.txt_dealerName.ReadOnly = true;
            this.txt_dealerName.Size = new System.Drawing.Size(100, 25);
            this.txt_dealerName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_recAdd);
            this.groupBox1.Controls.Add(this.cbBox_recAdd_city);
            this.groupBox1.Controls.Add(this.lbl_invName);
            this.groupBox1.Controls.Add(this.cbBox_recAdd_province);
            this.groupBox1.Controls.Add(this.lbl_expectDate);
            this.groupBox1.Controls.Add(this.lbl_recAdd);
            this.groupBox1.Controls.Add(this.lbl_invAdd);
            this.groupBox1.Controls.Add(this.txt_invName);
            this.groupBox1.Controls.Add(this.txt_invAdd);
            this.groupBox1.Controls.Add(this.dtp_expectDate);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(56, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receiver Information";
            // 
            // txt_recAdd
            // 
            this.txt_recAdd.Location = new System.Drawing.Point(121, 54);
            this.txt_recAdd.Name = "txt_recAdd";
            this.txt_recAdd.ReadOnly = true;
            this.txt_recAdd.Size = new System.Drawing.Size(524, 25);
            this.txt_recAdd.TabIndex = 3;
            // 
            // cbBox_recAdd_city
            // 
            this.cbBox_recAdd_city.Enabled = false;
            this.cbBox_recAdd_city.FormattingEnabled = true;
            this.cbBox_recAdd_city.Location = new System.Drawing.Point(249, 26);
            this.cbBox_recAdd_city.Name = "cbBox_recAdd_city";
            this.cbBox_recAdd_city.Size = new System.Drawing.Size(121, 23);
            this.cbBox_recAdd_city.TabIndex = 2;
            // 
            // lbl_invName
            // 
            this.lbl_invName.AutoSize = true;
            this.lbl_invName.Location = new System.Drawing.Point(12, 89);
            this.lbl_invName.Name = "lbl_invName";
            this.lbl_invName.Size = new System.Drawing.Size(90, 15);
            this.lbl_invName.TabIndex = 4;
            this.lbl_invName.Text = "Invoice Name:";
            // 
            // cbBox_recAdd_province
            // 
            this.cbBox_recAdd_province.Enabled = false;
            this.cbBox_recAdd_province.FormattingEnabled = true;
            this.cbBox_recAdd_province.Location = new System.Drawing.Point(121, 26);
            this.cbBox_recAdd_province.Name = "cbBox_recAdd_province";
            this.cbBox_recAdd_province.Size = new System.Drawing.Size(121, 23);
            this.cbBox_recAdd_province.TabIndex = 1;
            this.cbBox_recAdd_province.SelectedIndexChanged += new System.EventHandler(this.cbBox_recAdd_province_SelectedIndexChanged);
            // 
            // lbl_expectDate
            // 
            this.lbl_expectDate.AutoSize = true;
            this.lbl_expectDate.Location = new System.Drawing.Point(238, 89);
            this.lbl_expectDate.Name = "lbl_expectDate";
            this.lbl_expectDate.Size = new System.Drawing.Size(136, 15);
            this.lbl_expectDate.TabIndex = 6;
            this.lbl_expectDate.Text = "Expect Receiving Date";
            // 
            // lbl_recAdd
            // 
            this.lbl_recAdd.AutoSize = true;
            this.lbl_recAdd.Location = new System.Drawing.Point(12, 30);
            this.lbl_recAdd.Name = "lbl_recAdd";
            this.lbl_recAdd.Size = new System.Drawing.Size(109, 15);
            this.lbl_recAdd.TabIndex = 0;
            this.lbl_recAdd.Text = "Receiver Address:";
            // 
            // lbl_invAdd
            // 
            this.lbl_invAdd.AutoSize = true;
            this.lbl_invAdd.Location = new System.Drawing.Point(12, 119);
            this.lbl_invAdd.Name = "lbl_invAdd";
            this.lbl_invAdd.Size = new System.Drawing.Size(102, 15);
            this.lbl_invAdd.TabIndex = 8;
            this.lbl_invAdd.Text = "Invoice Address:";
            // 
            // txt_invName
            // 
            this.txt_invName.Location = new System.Drawing.Point(121, 84);
            this.txt_invName.Name = "txt_invName";
            this.txt_invName.ReadOnly = true;
            this.txt_invName.Size = new System.Drawing.Size(100, 25);
            this.txt_invName.TabIndex = 5;
            // 
            // txt_invAdd
            // 
            this.txt_invAdd.Location = new System.Drawing.Point(121, 114);
            this.txt_invAdd.Name = "txt_invAdd";
            this.txt_invAdd.ReadOnly = true;
            this.txt_invAdd.Size = new System.Drawing.Size(524, 25);
            this.txt_invAdd.TabIndex = 9;
            // 
            // dtp_expectDate
            // 
            this.dtp_expectDate.CustomFormat = " dd / MM / yyyy";
            this.dtp_expectDate.Enabled = false;
            this.dtp_expectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_expectDate.Location = new System.Drawing.Point(380, 84);
            this.dtp_expectDate.Name = "dtp_expectDate";
            this.dtp_expectDate.Size = new System.Drawing.Size(170, 25);
            this.dtp_expectDate.TabIndex = 7;
            // 
            // lbl_orderID_No
            // 
            this.lbl_orderID_No.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_orderID_No.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_orderID_No.Location = new System.Drawing.Point(126, 86);
            this.lbl_orderID_No.Name = "lbl_orderID_No";
            this.lbl_orderID_No.Size = new System.Drawing.Size(100, 22);
            this.lbl_orderID_No.TabIndex = 1;
            this.lbl_orderID_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_status.Location = new System.Drawing.Point(340, 86);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(100, 22);
            this.lbl_status.TabIndex = 3;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_orderStatus
            // 
            this.lbl_orderStatus.AutoSize = true;
            this.lbl_orderStatus.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_orderStatus.Location = new System.Drawing.Point(254, 90);
            this.lbl_orderStatus.Name = "lbl_orderStatus";
            this.lbl_orderStatus.Size = new System.Drawing.Size(82, 15);
            this.lbl_orderStatus.TabIndex = 2;
            this.lbl_orderStatus.Text = "Order Status:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(56, 599);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 68;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 40);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // ModifyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(769, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_orderStatus);
            this.Controls.Add(this.lbl_orderID_No);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpBox_dealer);
            this.Controls.Add(this.dtp_orderDate);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.gpBox_itemList);
            this.Controls.Add(this.lbl_orderDate);
            this.Controls.Add(this.lbl_orderID);
            this.Controls.Add(this.bt_reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyOrder";
            this.Text = "ModifyOrder";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModifyOrder_Load);
            this.gpBox_itemList.ResumeLayout(false);
            this.gpBox_itemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_itemList)).EndInit();
            this.gpBox_dealer.ResumeLayout(false);
            this.gpBox_dealer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label lbl_orderDate;
        private System.Windows.Forms.GroupBox gpBox_itemList;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.DateTimePicker dtp_orderDate;
        private System.Windows.Forms.GroupBox gpBox_dealer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_recAdd;
        private System.Windows.Forms.ComboBox cbBox_recAdd_city;
        private System.Windows.Forms.Label lbl_invName;
        private System.Windows.Forms.ComboBox cbBox_recAdd_province;
        private System.Windows.Forms.Label lbl_expectDate;
        private System.Windows.Forms.Label lbl_recAdd;
        private System.Windows.Forms.Label lbl_invAdd;
        private System.Windows.Forms.TextBox txt_invName;
        private System.Windows.Forms.TextBox txt_invAdd;
        private System.Windows.Forms.DateTimePicker dtp_expectDate;
        private System.Windows.Forms.TextBox txt_dealerName;
        private System.Windows.Forms.TextBox txt_dealerID;
        private System.Windows.Forms.Label lbl_dealerName;
        private System.Windows.Forms.Label lbl_dealerID;
        private System.Windows.Forms.Label lbl_totalAmt;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_weightAmt;
        private System.Windows.Forms.Label lbl_kg;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_orderID_No;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_orderStatus;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Button bt_addItem;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView_itemList;
        private System.Windows.Forms.Label lbl_availableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn bt_itemDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_item;
    }
}