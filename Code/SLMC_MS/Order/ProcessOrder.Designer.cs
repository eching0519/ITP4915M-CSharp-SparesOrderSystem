namespace SLMC_MS
{
    partial class ProcessOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessOrder));
            this.ckList_city = new System.Windows.Forms.CheckedListBox();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.ck_city = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expRecDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBox_province = new System.Windows.Forms.ComboBox();
            this.lbl_weight = new System.Windows.Forms.Label();
            this.lbl_kg = new System.Windows.Forms.Label();
            this.lbl_weightValue = new System.Windows.Forms.Label();
            this.bt_despatch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            this.SuspendLayout();
            // 
            // ckList_city
            // 
            this.ckList_city.CheckOnClick = true;
            this.ckList_city.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ckList_city.FormattingEnabled = true;
            this.ckList_city.Location = new System.Drawing.Point(44, 155);
            this.ckList_city.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckList_city.Name = "ckList_city";
            this.ckList_city.Size = new System.Drawing.Size(178, 497);
            this.ckList_city.TabIndex = 1;
            this.ckList_city.SelectedIndexChanged += new System.EventHandler(this.ckList_city_SelectedIndexChanged);
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AllowUserToAddRows = false;
            this.dataGridView_order.AllowUserToDeleteRows = false;
            this.dataGridView_order.AllowUserToResizeColumns = false;
            this.dataGridView_order.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ck_city,
            this.City,
            this.OrderID,
            this.expRecDate,
            this.Weight});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_order.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_order.Location = new System.Drawing.Point(252, 112);
            this.dataGridView_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_order.MultiSelect = false;
            this.dataGridView_order.Name = "dataGridView_order";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_order.RowHeadersVisible = false;
            this.dataGridView_order.RowTemplate.Height = 24;
            this.dataGridView_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_order.Size = new System.Drawing.Size(926, 560);
            this.dataGridView_order.TabIndex = 2;
            this.dataGridView_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_order_CellContentClick);
            this.dataGridView_order.SelectionChanged += new System.EventHandler(this.dataGridView_order_SelectionChanged);
            this.dataGridView_order.Validated += new System.EventHandler(this.dataGridView_order_Validated);
            // 
            // ck_city
            // 
            this.ck_city.HeaderText = "";
            this.ck_city.Name = "ck_city";
            this.ck_city.Width = 21;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.City.DefaultCellStyle = dataGridViewCellStyle2;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // OrderID
            // 
            this.OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderID.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            // 
            // expRecDate
            // 
            this.expRecDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.expRecDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.expRecDate.HeaderText = "Expect Receiving Date";
            this.expRecDate.Name = "expRecDate";
            this.expRecDate.ReadOnly = true;
            this.expRecDate.Width = 159;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Weight.DefaultCellStyle = dataGridViewCellStyle5;
            this.Weight.HeaderText = "Weight (kg)";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // cbBox_province
            // 
            this.cbBox_province.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbBox_province.FormattingEnabled = true;
            this.cbBox_province.Location = new System.Drawing.Point(44, 112);
            this.cbBox_province.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBox_province.Name = "cbBox_province";
            this.cbBox_province.Size = new System.Drawing.Size(180, 31);
            this.cbBox_province.TabIndex = 0;
            this.cbBox_province.Text = "-------Province-------";
            this.cbBox_province.SelectedIndexChanged += new System.EventHandler(this.cbBox_province_SelectedIndexChanged);
            // 
            // lbl_weight
            // 
            this.lbl_weight.AutoSize = true;
            this.lbl_weight.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_weight.Location = new System.Drawing.Point(687, 695);
            this.lbl_weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weight.Name = "lbl_weight";
            this.lbl_weight.Size = new System.Drawing.Size(147, 24);
            this.lbl_weight.TabIndex = 3;
            this.lbl_weight.Text = "Total Weight:";
            // 
            // lbl_kg
            // 
            this.lbl_kg.AutoSize = true;
            this.lbl_kg.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_kg.Location = new System.Drawing.Point(970, 695);
            this.lbl_kg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kg.Name = "lbl_kg";
            this.lbl_kg.Size = new System.Drawing.Size(34, 24);
            this.lbl_kg.TabIndex = 5;
            this.lbl_kg.Text = "kg";
            // 
            // lbl_weightValue
            // 
            this.lbl_weightValue.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_weightValue.Location = new System.Drawing.Point(840, 695);
            this.lbl_weightValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_weightValue.Name = "lbl_weightValue";
            this.lbl_weightValue.Size = new System.Drawing.Size(136, 27);
            this.lbl_weightValue.TabIndex = 4;
            this.lbl_weightValue.Text = "0.00";
            this.lbl_weightValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_despatch
            // 
            this.bt_despatch.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_despatch.Location = new System.Drawing.Point(1028, 682);
            this.bt_despatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_despatch.Name = "bt_despatch";
            this.bt_despatch.Size = new System.Drawing.Size(150, 53);
            this.bt_despatch.TabIndex = 6;
            this.bt_despatch.Text = "Despatch";
            this.bt_despatch.UseVisualStyleBackColor = true;
            this.bt_despatch.Click += new System.EventHandler(this.bt_despatch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 67);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(44, 682);
            this.picBox_return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(86, 58);
            this.picBox_return.TabIndex = 67;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // ProcessOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 783);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_despatch);
            this.Controls.Add(this.lbl_weightValue);
            this.Controls.Add(this.lbl_kg);
            this.Controls.Add(this.lbl_weight);
            this.Controls.Add(this.ckList_city);
            this.Controls.Add(this.dataGridView_order);
            this.Controls.Add(this.cbBox_province);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProcessOrder";
            this.Text = "MyProcess";
            this.Load += new System.EventHandler(this.MyProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckList_city;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.ComboBox cbBox_province;
        private System.Windows.Forms.Label lbl_weight;
        private System.Windows.Forms.Label lbl_kg;
        private System.Windows.Forms.Label lbl_weightValue;
        private System.Windows.Forms.Button bt_despatch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ck_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn expRecDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}