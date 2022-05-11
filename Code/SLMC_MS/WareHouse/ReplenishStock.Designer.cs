namespace SLMC_MS
{
    partial class ReplenishStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplenishStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ReorderList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.lbl_availableQty = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.bt_addItem = new System.Windows.Forms.Button();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_available = new System.Windows.Forms.Label();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_replenishHistory = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReorderList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_replenishHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ReorderList
            // 
            this.dgv_ReorderList.AllowUserToAddRows = false;
            this.dgv_ReorderList.AllowUserToDeleteRows = false;
            this.dgv_ReorderList.AllowUserToResizeColumns = false;
            this.dgv_ReorderList.AllowUserToResizeRows = false;
            this.dgv_ReorderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReorderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dgv_ReorderList.Location = new System.Drawing.Point(36, 69);
            this.dgv_ReorderList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_ReorderList.Name = "dgv_ReorderList";
            this.dgv_ReorderList.RowHeadersVisible = false;
            this.dgv_ReorderList.RowTemplate.Height = 27;
            this.dgv_ReorderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ReorderList.Size = new System.Drawing.Size(896, 432);
            this.dgv_ReorderList.TabIndex = 0;
            this.dgv_ReorderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ReorderList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Supplier";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Item Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "QTY";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(246, 31);
            this.txt_item.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_item.Name = "txt_item";
            this.txt_item.ReadOnly = true;
            this.txt_item.Size = new System.Drawing.Size(256, 25);
            this.txt_item.TabIndex = 24;
            // 
            // lbl_availableQty
            // 
            this.lbl_availableQty.AutoSize = true;
            this.lbl_availableQty.Location = new System.Drawing.Point(593, 36);
            this.lbl_availableQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_availableQty.Name = "lbl_availableQty";
            this.lbl_availableQty.Size = new System.Drawing.Size(0, 15);
            this.lbl_availableQty.TabIndex = 20;
            this.lbl_availableQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(732, 31);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(72, 25);
            this.txt_qty.TabIndex = 22;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_itemID
            // 
            this.txt_itemID.Location = new System.Drawing.Point(123, 31);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(118, 25);
            this.txt_itemID.TabIndex = 17;
            this.txt_itemID.TextChanged += new System.EventHandler(this.txt_itemID_TextChanged);
            // 
            // bt_addItem
            // 
            this.bt_addItem.Location = new System.Drawing.Point(830, 25);
            this.bt_addItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_addItem.Name = "bt_addItem";
            this.bt_addItem.Size = new System.Drawing.Size(102, 37);
            this.bt_addItem.TabIndex = 23;
            this.bt_addItem.Text = "Add";
            this.bt_addItem.UseVisualStyleBackColor = true;
            this.bt_addItem.Click += new System.EventHandler(this.bt_addItem_Click);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(666, 36);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(40, 15);
            this.lbl_qty.TabIndex = 21;
            this.lbl_qty.Text = "QTY:";
            // 
            // lbl_available
            // 
            this.lbl_available.AutoSize = true;
            this.lbl_available.Location = new System.Drawing.Point(524, 36);
            this.lbl_available.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(65, 15);
            this.lbl_available.TabIndex = 19;
            this.lbl_available.Text = "Available:";
            // 
            // lbl_itemid
            // 
            this.lbl_itemid.AutoSize = true;
            this.lbl_itemid.Location = new System.Drawing.Point(41, 36);
            this.lbl_itemid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemid.Name = "lbl_itemid";
            this.lbl_itemid.Size = new System.Drawing.Size(56, 15);
            this.lbl_itemid.TabIndex = 16;
            this.lbl_itemid.Text = "Item ID:";
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(817, 508);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(115, 37);
            this.bt_submit.TabIndex = 25;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_ReorderList);
            this.panel1.Controls.Add(this.bt_submit);
            this.panel1.Controls.Add(this.lbl_itemid);
            this.panel1.Controls.Add(this.txt_item);
            this.panel1.Controls.Add(this.lbl_available);
            this.panel1.Controls.Add(this.lbl_availableQty);
            this.panel1.Controls.Add(this.lbl_qty);
            this.panel1.Controls.Add(this.txt_qty);
            this.panel1.Controls.Add(this.bt_addItem);
            this.panel1.Controls.Add(this.txt_itemID);
            this.panel1.Location = new System.Drawing.Point(33, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 561);
            this.panel1.TabIndex = 26;
            this.panel1.Visible = false;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(942, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 92;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_replenishHistory
            // 
            this.dgv_replenishHistory.AllowUserToAddRows = false;
            this.dgv_replenishHistory.AllowUserToDeleteRows = false;
            this.dgv_replenishHistory.AllowUserToResizeColumns = false;
            this.dgv_replenishHistory.AllowUserToResizeRows = false;
            this.dgv_replenishHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_replenishHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column10});
            this.dgv_replenishHistory.Location = new System.Drawing.Point(103, 98);
            this.dgv_replenishHistory.Name = "dgv_replenishHistory";
            this.dgv_replenishHistory.RowHeadersVisible = false;
            this.dgv_replenishHistory.RowTemplate.Height = 24;
            this.dgv_replenishHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_replenishHistory.Size = new System.Drawing.Size(831, 433);
            this.dgv_replenishHistory.TabIndex = 27;
            this.dgv_replenishHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_replenishHistory_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "New Replenish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 40);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(103, 537);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 94;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column14.HeaderText = "Replenishment ID";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column10.HeaderText = "Order Date";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // btn_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_replenishHistory);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "btn_new";
            this.Text = "ReplenishStock";
            this.Load += new System.EventHandler(this.RepenishStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReorderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_replenishHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ReorderList;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label lbl_availableQty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Button bt_addItem;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_replenishHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}