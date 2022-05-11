namespace SLMC_MS
{
    partial class OrderSearchEngine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSearchEngine));
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.lbl_dealerID = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.txt_dealerID = new System.Windows.Forms.TextBox();
            this.lbl_distract = new System.Windows.Forms.Label();
            this.cbbox_province = new System.Windows.Forms.ComboBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_minAmount = new System.Windows.Forms.TextBox();
            this.txt_maxAmount = new System.Windows.Forms.TextBox();
            this.lbl_dealerName = new System.Windows.Forms.Label();
            this.txt_dealerName = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.date_from = new System.Windows.Forms.DateTimePicker();
            this.bt_search = new System.Windows.Forms.Button();
            this.dgv_orderSearchList = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbox_city = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_to = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckBox_cancel = new System.Windows.Forms.CheckBox();
            this.ckBox_complete = new System.Windows.Forms.CheckBox();
            this.ckBox_delivering = new System.Windows.Forms.CheckBox();
            this.ckBox_packing = new System.Windows.Forms.CheckBox();
            this.ckBox_assembled = new System.Windows.Forms.CheckBox();
            this.ckBox_processing = new System.Windows.Forms.CheckBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderSearchList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AccessibleDescription = "lbl_orderID";
            this.lbl_orderID.AccessibleName = "lbl_orderID";
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Location = new System.Drawing.Point(28, 70);
            this.lbl_orderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(96, 23);
            this.lbl_orderID.TabIndex = 0;
            this.lbl_orderID.Text = "Order ID:";
            // 
            // lbl_dealerID
            // 
            this.lbl_dealerID.AccessibleDescription = "lbl_dealerID";
            this.lbl_dealerID.AccessibleName = "lbl_dealerID";
            this.lbl_dealerID.AutoSize = true;
            this.lbl_dealerID.Location = new System.Drawing.Point(28, 103);
            this.lbl_dealerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dealerID.Name = "lbl_dealerID";
            this.lbl_dealerID.Size = new System.Drawing.Size(104, 23);
            this.lbl_dealerID.TabIndex = 2;
            this.lbl_dealerID.Text = "Dealer ID:";
            // 
            // txt_orderID
            // 
            this.txt_orderID.AccessibleDescription = "txt_orderID";
            this.txt_orderID.AccessibleName = "txt_orderID";
            this.txt_orderID.Location = new System.Drawing.Point(124, 65);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(157, 34);
            this.txt_orderID.TabIndex = 1;
            // 
            // txt_dealerID
            // 
            this.txt_dealerID.AccessibleDescription = "txt_dealerID";
            this.txt_dealerID.AccessibleName = "txt_dealerID";
            this.txt_dealerID.Location = new System.Drawing.Point(124, 98);
            this.txt_dealerID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dealerID.Name = "txt_dealerID";
            this.txt_dealerID.Size = new System.Drawing.Size(157, 34);
            this.txt_dealerID.TabIndex = 3;
            // 
            // lbl_distract
            // 
            this.lbl_distract.AccessibleDescription = "lbl_distract";
            this.lbl_distract.AccessibleName = "lbl_distract";
            this.lbl_distract.AutoSize = true;
            this.lbl_distract.Location = new System.Drawing.Point(541, 70);
            this.lbl_distract.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_distract.Name = "lbl_distract";
            this.lbl_distract.Size = new System.Drawing.Size(85, 23);
            this.lbl_distract.TabIndex = 10;
            this.lbl_distract.Text = "Distract:";
            // 
            // cbbox_province
            // 
            this.cbbox_province.AccessibleDescription = "";
            this.cbbox_province.AccessibleName = "";
            this.cbbox_province.FormattingEnabled = true;
            this.cbbox_province.Location = new System.Drawing.Point(604, 66);
            this.cbbox_province.Margin = new System.Windows.Forms.Padding(4);
            this.cbbox_province.Name = "cbbox_province";
            this.cbbox_province.Size = new System.Drawing.Size(103, 31);
            this.cbbox_province.TabIndex = 11;
            this.cbbox_province.SelectedIndexChanged += new System.EventHandler(this.cbbox_province_SelectedIndexChanged);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AccessibleDescription = "lbl_amount";
            this.lbl_amount.AccessibleName = "lbl_amount";
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(28, 169);
            this.lbl_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(88, 23);
            this.lbl_amount.TabIndex = 6;
            this.lbl_amount.Text = "Amount:";
            // 
            // txt_minAmount
            // 
            this.txt_minAmount.AccessibleDescription = "txt_amountS";
            this.txt_minAmount.AccessibleName = "txt_amountS";
            this.txt_minAmount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txt_minAmount.CausesValidation = false;
            this.txt_minAmount.Location = new System.Drawing.Point(124, 164);
            this.txt_minAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_minAmount.Name = "txt_minAmount";
            this.txt_minAmount.Size = new System.Drawing.Size(69, 34);
            this.txt_minAmount.TabIndex = 7;
            this.txt_minAmount.TextChanged += new System.EventHandler(this.txt_minAmount_TextChanged);
            // 
            // txt_maxAmount
            // 
            this.txt_maxAmount.AccessibleDescription = "txt_amountB";
            this.txt_maxAmount.AccessibleName = "txt_amountB";
            this.txt_maxAmount.Location = new System.Drawing.Point(212, 164);
            this.txt_maxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maxAmount.Name = "txt_maxAmount";
            this.txt_maxAmount.Size = new System.Drawing.Size(69, 34);
            this.txt_maxAmount.TabIndex = 8;
            this.txt_maxAmount.TextChanged += new System.EventHandler(this.txt_maxAmount_TextChanged);
            // 
            // lbl_dealerName
            // 
            this.lbl_dealerName.AccessibleDescription = "lbl_dealerName";
            this.lbl_dealerName.AccessibleName = "lbl_dealerName";
            this.lbl_dealerName.AutoSize = true;
            this.lbl_dealerName.Location = new System.Drawing.Point(28, 136);
            this.lbl_dealerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dealerName.Name = "lbl_dealerName";
            this.lbl_dealerName.Size = new System.Drawing.Size(134, 23);
            this.lbl_dealerName.TabIndex = 4;
            this.lbl_dealerName.Text = "Dealer Name:";
            // 
            // txt_dealerName
            // 
            this.txt_dealerName.AccessibleDescription = "txt_dealerName";
            this.txt_dealerName.AccessibleName = "txt_dealerName";
            this.txt_dealerName.Location = new System.Drawing.Point(124, 131);
            this.txt_dealerName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dealerName.Name = "txt_dealerName";
            this.txt_dealerName.Size = new System.Drawing.Size(157, 34);
            this.txt_dealerName.TabIndex = 5;
            // 
            // lbl_date
            // 
            this.lbl_date.AccessibleDescription = "lbl_date";
            this.lbl_date.AccessibleName = "lbl_date";
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(541, 103);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(153, 23);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "Date:        From";
            // 
            // date_from
            // 
            this.date_from.Checked = false;
            this.date_from.Location = new System.Drawing.Point(649, 98);
            this.date_from.Margin = new System.Windows.Forms.Padding(4);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(168, 34);
            this.date_from.TabIndex = 14;
            this.date_from.Value = new System.DateTime(2019, 6, 19, 0, 0, 0, 0);
            this.date_from.ValueChanged += new System.EventHandler(this.date_from_ValueChanged);
            // 
            // bt_search
            // 
            this.bt_search.AccessibleDescription = "bt_search";
            this.bt_search.AccessibleName = "bt_search";
            this.bt_search.Location = new System.Drawing.Point(717, 162);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(100, 29);
            this.bt_search.TabIndex = 17;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // dgv_orderSearchList
            // 
            this.dgv_orderSearchList.AllowUserToAddRows = false;
            this.dgv_orderSearchList.AllowUserToDeleteRows = false;
            this.dgv_orderSearchList.AllowUserToResizeColumns = false;
            this.dgv_orderSearchList.AllowUserToResizeRows = false;
            this.dgv_orderSearchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orderSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderSearchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column3,
            this.Column4});
            this.dgv_orderSearchList.Location = new System.Drawing.Point(28, 200);
            this.dgv_orderSearchList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_orderSearchList.MultiSelect = false;
            this.dgv_orderSearchList.Name = "dgv_orderSearchList";
            this.dgv_orderSearchList.RowHeadersVisible = false;
            this.dgv_orderSearchList.RowTemplate.Height = 24;
            this.dgv_orderSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_orderSearchList.Size = new System.Drawing.Size(789, 362);
            this.dgv_orderSearchList.StandardTab = true;
            this.dgv_orderSearchList.TabIndex = 18;
            this.dgv_orderSearchList.TabStop = false;
            this.dgv_orderSearchList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orderSearchList_CellDoubleClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "City";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "Order ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Order Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Dealer ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dealer Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "lbl_amount";
            this.label1.AccessibleName = "lbl_amount";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "~";
            // 
            // cbbox_city
            // 
            this.cbbox_city.AccessibleDescription = "";
            this.cbbox_city.AccessibleName = "";
            this.cbbox_city.FormattingEnabled = true;
            this.cbbox_city.Location = new System.Drawing.Point(714, 66);
            this.cbbox_city.Margin = new System.Windows.Forms.Padding(4);
            this.cbbox_city.Name = "cbbox_city";
            this.cbbox_city.Size = new System.Drawing.Size(103, 31);
            this.cbbox_city.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "lbl_amount";
            this.label2.AccessibleName = "lbl_amount";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "To";
            // 
            // date_to
            // 
            this.date_to.Location = new System.Drawing.Point(649, 131);
            this.date_to.Margin = new System.Windows.Forms.Padding(4);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(168, 34);
            this.date_to.TabIndex = 16;
            this.date_to.ValueChanged += new System.EventHandler(this.date_to_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckBox_cancel);
            this.groupBox1.Controls.Add(this.ckBox_complete);
            this.groupBox1.Controls.Add(this.ckBox_delivering);
            this.groupBox1.Controls.Add(this.ckBox_packing);
            this.groupBox1.Controls.Add(this.ckBox_assembled);
            this.groupBox1.Controls.Add(this.ckBox_processing);
            this.groupBox1.Location = new System.Drawing.Point(308, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 91);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Status";
            // 
            // ckBox_cancel
            // 
            this.ckBox_cancel.AutoSize = true;
            this.ckBox_cancel.Checked = true;
            this.ckBox_cancel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBox_cancel.Location = new System.Drawing.Point(114, 65);
            this.ckBox_cancel.Name = "ckBox_cancel";
            this.ckBox_cancel.Size = new System.Drawing.Size(97, 27);
            this.ckBox_cancel.TabIndex = 5;
            this.ckBox_cancel.Text = "Cancel";
            this.ckBox_cancel.UseVisualStyleBackColor = true;
            // 
            // ckBox_complete
            // 
            this.ckBox_complete.AutoSize = true;
            this.ckBox_complete.Checked = true;
            this.ckBox_complete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBox_complete.Location = new System.Drawing.Point(114, 42);
            this.ckBox_complete.Name = "ckBox_complete";
            this.ckBox_complete.Size = new System.Drawing.Size(121, 27);
            this.ckBox_complete.TabIndex = 3;
            this.ckBox_complete.Text = "Complete";
            this.ckBox_complete.UseVisualStyleBackColor = true;
            // 
            // ckBox_delivering
            // 
            this.ckBox_delivering.AutoSize = true;
            this.ckBox_delivering.Checked = true;
            this.ckBox_delivering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBox_delivering.Location = new System.Drawing.Point(114, 19);
            this.ckBox_delivering.Name = "ckBox_delivering";
            this.ckBox_delivering.Size = new System.Drawing.Size(130, 27);
            this.ckBox_delivering.TabIndex = 1;
            this.ckBox_delivering.Text = "Delivering";
            this.ckBox_delivering.UseVisualStyleBackColor = true;
            // 
            // ckBox_packing
            // 
            this.ckBox_packing.AutoSize = true;
            this.ckBox_packing.Checked = true;
            this.ckBox_packing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBox_packing.Location = new System.Drawing.Point(12, 65);
            this.ckBox_packing.Name = "ckBox_packing";
            this.ckBox_packing.Size = new System.Drawing.Size(107, 27);
            this.ckBox_packing.TabIndex = 4;
            this.ckBox_packing.Text = "Packing";
            this.ckBox_packing.UseVisualStyleBackColor = true;
            // 
            // ckBox_assembled
            // 
            this.ckBox_assembled.AutoSize = true;
            this.ckBox_assembled.Checked = true;
            this.ckBox_assembled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBox_assembled.Location = new System.Drawing.Point(12, 42);
            this.ckBox_assembled.Name = "ckBox_assembled";
            this.ckBox_assembled.Size = new System.Drawing.Size(133, 27);
            this.ckBox_assembled.TabIndex = 2;
            this.ckBox_assembled.Text = "Assembled";
            this.ckBox_assembled.UseVisualStyleBackColor = true;
            // 
            // ckBox_processing
            // 
            this.ckBox_processing.AutoSize = true;
            this.ckBox_processing.Checked = true;
            this.ckBox_processing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBox_processing.Location = new System.Drawing.Point(12, 19);
            this.ckBox_processing.Name = "ckBox_processing";
            this.ckBox_processing.Size = new System.Drawing.Size(130, 27);
            this.ckBox_processing.TabIndex = 0;
            this.ckBox_processing.Text = "Processing";
            this.ckBox_processing.UseVisualStyleBackColor = true;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(28, 569);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 69;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 40);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // OrderSearchEngine
            // 
            this.AccessibleName = "OrderSearchingEngine";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(851, 616);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbox_city);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_orderSearchList);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_dealerName);
            this.Controls.Add(this.lbl_dealerName);
            this.Controls.Add(this.txt_maxAmount);
            this.Controls.Add(this.txt_minAmount);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.cbbox_province);
            this.Controls.Add(this.lbl_distract);
            this.Controls.Add(this.txt_dealerID);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.lbl_dealerID);
            this.Controls.Add(this.lbl_orderID);
            this.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderSearchEngine";
            this.Text = "OrderSearchEngine";
            this.Load += new System.EventHandler(this.OrderSearchEngine_Load);
            this.Shown += new System.EventHandler(this.OrderSearchEngine_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderSearchList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.Label lbl_dealerID;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.TextBox txt_dealerID;
        private System.Windows.Forms.Label lbl_distract;
        private System.Windows.Forms.ComboBox cbbox_province;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_minAmount;
        private System.Windows.Forms.TextBox txt_maxAmount;
        private System.Windows.Forms.Label lbl_dealerName;
        private System.Windows.Forms.TextBox txt_dealerName;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker date_from;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.DataGridView dgv_orderSearchList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_dealerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_dealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_amount;
        private System.Windows.Forms.ComboBox cbbox_city;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckBox_cancel;
        private System.Windows.Forms.CheckBox ckBox_complete;
        private System.Windows.Forms.CheckBox ckBox_delivering;
        private System.Windows.Forms.CheckBox ckBox_packing;
        private System.Windows.Forms.CheckBox ckBox_assembled;
        private System.Windows.Forms.CheckBox ckBox_processing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
    }
}