namespace SLMC_MS
{
    partial class ItemSearchingEngine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSearchingEngine));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_itemSearchList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_search = new System.Windows.Forms.Button();
            this.txt_supplierName = new System.Windows.Forms.TextBox();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.txt_maxAmount = new System.Windows.Forms.TextBox();
            this.txt_minAmount = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.lbl_supplierID = new System.Windows.Forms.Label();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_availableMax = new System.Windows.Forms.TextBox();
            this.txt_availableMin = new System.Windows.Forms.TextBox();
            this.lbl_available = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemSearchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lbl_amount";
            this.label1.AccessibleName = "lbl_amount";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "~";
            // 
            // dgv_itemSearchList
            // 
            this.dgv_itemSearchList.AllowUserToAddRows = false;
            this.dgv_itemSearchList.AllowUserToDeleteRows = false;
            this.dgv_itemSearchList.AllowUserToResizeRows = false;
            this.dgv_itemSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemSearchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column12,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column10,
            this.Column13,
            this.Column14});
            this.dgv_itemSearchList.Location = new System.Drawing.Point(44, 180);
            this.dgv_itemSearchList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_itemSearchList.MultiSelect = false;
            this.dgv_itemSearchList.Name = "dgv_itemSearchList";
            this.dgv_itemSearchList.RowHeadersVisible = false;
            this.dgv_itemSearchList.RowTemplate.Height = 24;
            this.dgv_itemSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemSearchList.Size = new System.Drawing.Size(853, 394);
            this.dgv_itemSearchList.StandardTab = true;
            this.dgv_itemSearchList.TabIndex = 16;
            this.dgv_itemSearchList.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Item ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "名稱";
            this.Column12.Name = "Column12";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Supplier ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 120F;
            this.Column5.HeaderText = "Supplier Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Selling Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Purchase Price";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.HeaderText = "Stock";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 45;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Available";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column11.HeaderText = "Location";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 60;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column10.HeaderText = "Weight";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 55;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Danger Line";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Reorder Line";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // bt_search
            // 
            this.bt_search.AccessibleDescription = "bt_search";
            this.bt_search.AccessibleName = "bt_search";
            this.bt_search.Location = new System.Drawing.Point(755, 112);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(142, 60);
            this.bt_search.TabIndex = 15;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // txt_supplierName
            // 
            this.txt_supplierName.AccessibleDescription = "txt_dealerName";
            this.txt_supplierName.AccessibleName = "txt_dealerName";
            this.txt_supplierName.Location = new System.Drawing.Point(523, 112);
            this.txt_supplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplierName.Name = "txt_supplierName";
            this.txt_supplierName.Size = new System.Drawing.Size(157, 34);
            this.txt_supplierName.TabIndex = 7;
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AccessibleDescription = "";
            this.lbl_supplierName.AccessibleName = "";
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(415, 117);
            this.lbl_supplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(149, 23);
            this.lbl_supplierName.TabIndex = 6;
            this.lbl_supplierName.Text = "Supplier Name:";
            // 
            // txt_maxAmount
            // 
            this.txt_maxAmount.AccessibleDescription = "txt_amountB";
            this.txt_maxAmount.AccessibleName = "txt_amountB";
            this.txt_maxAmount.Location = new System.Drawing.Point(240, 147);
            this.txt_maxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maxAmount.Name = "txt_maxAmount";
            this.txt_maxAmount.Size = new System.Drawing.Size(69, 34);
            this.txt_maxAmount.TabIndex = 10;
            this.txt_maxAmount.TextChanged += new System.EventHandler(this.txt_maxAmount_TextChanged);
            // 
            // txt_minAmount
            // 
            this.txt_minAmount.AccessibleDescription = "txt_amountS";
            this.txt_minAmount.AccessibleName = "txt_amountS";
            this.txt_minAmount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_minAmount.CausesValidation = false;
            this.txt_minAmount.Location = new System.Drawing.Point(152, 147);
            this.txt_minAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_minAmount.Name = "txt_minAmount";
            this.txt_minAmount.Size = new System.Drawing.Size(69, 34);
            this.txt_minAmount.TabIndex = 9;
            this.txt_minAmount.TextChanged += new System.EventHandler(this.txt_minAmount_TextChanged);
            // 
            // lbl_price
            // 
            this.lbl_price.AccessibleDescription = "";
            this.lbl_price.AccessibleName = "";
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(44, 152);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(61, 23);
            this.lbl_price.TabIndex = 8;
            this.lbl_price.Text = "Price:";
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.AccessibleDescription = "txt_dealerID";
            this.txt_supplierID.AccessibleName = "txt_dealerID";
            this.txt_supplierID.Location = new System.Drawing.Point(152, 112);
            this.txt_supplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(157, 34);
            this.txt_supplierID.TabIndex = 5;
            // 
            // txt_itemID
            // 
            this.txt_itemID.AccessibleDescription = "txt_orderID";
            this.txt_itemID.AccessibleName = "txt_orderID";
            this.txt_itemID.Location = new System.Drawing.Point(152, 77);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(157, 34);
            this.txt_itemID.TabIndex = 1;
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AccessibleDescription = "lbl_dealerID";
            this.lbl_supplierID.AccessibleName = "lbl_dealerID";
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Location = new System.Drawing.Point(44, 117);
            this.lbl_supplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(119, 23);
            this.lbl_supplierID.TabIndex = 4;
            this.lbl_supplierID.Text = "Supplier ID:";
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AccessibleDescription = "lbl_orderID";
            this.lbl_itemID.AccessibleName = "lbl_orderID";
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Location = new System.Drawing.Point(44, 82);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(85, 23);
            this.lbl_itemID.TabIndex = 0;
            this.lbl_itemID.Text = "Item ID:";
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(44, 581);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 91;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 40);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // txt_itemName
            // 
            this.txt_itemName.AccessibleDescription = "txt_dealerName";
            this.txt_itemName.AccessibleName = "txt_dealerName";
            this.txt_itemName.Location = new System.Drawing.Point(523, 77);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(157, 34);
            this.txt_itemName.TabIndex = 3;
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AccessibleDescription = "";
            this.lbl_itemName.AccessibleName = "";
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Location = new System.Drawing.Point(415, 82);
            this.lbl_itemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(115, 23);
            this.lbl_itemName.TabIndex = 2;
            this.lbl_itemName.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "lbl_amount";
            this.label2.AccessibleName = "lbl_amount";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 97;
            this.label2.Text = "~";
            // 
            // txt_availableMax
            // 
            this.txt_availableMax.AccessibleDescription = "txt_amountB";
            this.txt_availableMax.AccessibleName = "txt_amountB";
            this.txt_availableMax.Location = new System.Drawing.Point(611, 147);
            this.txt_availableMax.Margin = new System.Windows.Forms.Padding(4);
            this.txt_availableMax.Name = "txt_availableMax";
            this.txt_availableMax.Size = new System.Drawing.Size(69, 34);
            this.txt_availableMax.TabIndex = 13;
            this.txt_availableMax.TextChanged += new System.EventHandler(this.txt_availableMax_TextChanged);
            // 
            // txt_availableMin
            // 
            this.txt_availableMin.AccessibleDescription = "txt_amountS";
            this.txt_availableMin.AccessibleName = "txt_amountS";
            this.txt_availableMin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_availableMin.CausesValidation = false;
            this.txt_availableMin.Location = new System.Drawing.Point(523, 147);
            this.txt_availableMin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_availableMin.Name = "txt_availableMin";
            this.txt_availableMin.Size = new System.Drawing.Size(69, 34);
            this.txt_availableMin.TabIndex = 12;
            this.txt_availableMin.TextChanged += new System.EventHandler(this.txt_availableMin_TextChanged);
            // 
            // lbl_available
            // 
            this.lbl_available.AccessibleDescription = "";
            this.lbl_available.AccessibleName = "";
            this.lbl_available.AutoSize = true;
            this.lbl_available.Location = new System.Drawing.Point(415, 152);
            this.lbl_available.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_available.Name = "lbl_available";
            this.lbl_available.Size = new System.Drawing.Size(158, 23);
            this.lbl_available.TabIndex = 11;
            this.lbl_available.Text = "Available Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(93, 31);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(264, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock under Danger Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(111, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(246, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stock under Reorder Line";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(537, 581);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 28);
            this.flowLayoutPanel1.TabIndex = 99;
            // 
            // ItemSearchingEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 638);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_availableMax);
            this.Controls.Add(this.txt_availableMin);
            this.Controls.Add(this.lbl_available);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_itemSearchList);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.txt_supplierName);
            this.Controls.Add(this.lbl_supplierName);
            this.Controls.Add(this.txt_maxAmount);
            this.Controls.Add(this.txt_minAmount);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txt_supplierID);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.lbl_supplierID);
            this.Controls.Add(this.lbl_itemID);
            this.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemSearchingEngine";
            this.Text = "ItemSearchingEngine";
            this.Load += new System.EventHandler(this.ItemSearchingEngine_Load);
            this.Shown += new System.EventHandler(this.ItemSearchingEngine_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemSearchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_itemSearchList;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox txt_supplierName;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.TextBox txt_maxAmount;
        private System.Windows.Forms.TextBox txt_minAmount;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Label lbl_supplierID;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_availableMax;
        private System.Windows.Forms.TextBox txt_availableMin;
        private System.Windows.Forms.Label lbl_available;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}