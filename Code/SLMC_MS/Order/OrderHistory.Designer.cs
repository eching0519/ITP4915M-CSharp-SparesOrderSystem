namespace SLMC_MS
{
    partial class OrderHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderHistory));
            this.dgv_incompleteOrder = new System.Windows.Forms.DataGridView();
            this.dgcD_received = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvD_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvD_expectRecevingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvD_orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvD_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvD_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvD_modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvD_cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.dgv_completeOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpBox_Incomplete = new System.Windows.Forms.GroupBox();
            this.gpBox_Complete = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incompleteOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_completeOrder)).BeginInit();
            this.gpBox_Incomplete.SuspendLayout();
            this.gpBox_Complete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_incompleteOrder
            // 
            this.dgv_incompleteOrder.AllowUserToAddRows = false;
            this.dgv_incompleteOrder.AllowUserToDeleteRows = false;
            this.dgv_incompleteOrder.AllowUserToResizeColumns = false;
            this.dgv_incompleteOrder.AllowUserToResizeRows = false;
            this.dgv_incompleteOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_incompleteOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcD_received,
            this.dgvD_date,
            this.dgvD_expectRecevingDate,
            this.dgvD_orderID,
            this.dgvD_Amount,
            this.dgvD_Status,
            this.dgvD_modify,
            this.dgvD_cancel});
            this.dgv_incompleteOrder.Location = new System.Drawing.Point(10, 16);
            this.dgv_incompleteOrder.Name = "dgv_incompleteOrder";
            this.dgv_incompleteOrder.RowHeadersVisible = false;
            this.dgv_incompleteOrder.RowTemplate.Height = 24;
            this.dgv_incompleteOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_incompleteOrder.Size = new System.Drawing.Size(907, 196);
            this.dgv_incompleteOrder.TabIndex = 0;
            this.dgv_incompleteOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_incompleteOrder_CellContentClick);
            this.dgv_incompleteOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_incompleteOrder_CellDoubleClick);
            // 
            // dgcD_received
            // 
            this.dgcD_received.Frozen = true;
            this.dgcD_received.HeaderText = "";
            this.dgcD_received.Name = "dgcD_received";
            this.dgcD_received.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcD_received.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcD_received.Width = 21;
            // 
            // dgvD_date
            // 
            this.dgvD_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvD_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvD_date.HeaderText = "Order Date";
            this.dgvD_date.Name = "dgvD_date";
            this.dgvD_date.ReadOnly = true;
            // 
            // dgvD_expectRecevingDate
            // 
            this.dgvD_expectRecevingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvD_expectRecevingDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvD_expectRecevingDate.FillWeight = 108F;
            this.dgvD_expectRecevingDate.HeaderText = "Expect Receving Date ";
            this.dgvD_expectRecevingDate.Name = "dgvD_expectRecevingDate";
            this.dgvD_expectRecevingDate.ReadOnly = true;
            // 
            // dgvD_orderID
            // 
            this.dgvD_orderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvD_orderID.HeaderText = "Order ID";
            this.dgvD_orderID.Name = "dgvD_orderID";
            this.dgvD_orderID.ReadOnly = true;
            // 
            // dgvD_Amount
            // 
            this.dgvD_Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvD_Amount.HeaderText = "Amount";
            this.dgvD_Amount.Name = "dgvD_Amount";
            this.dgvD_Amount.ReadOnly = true;
            // 
            // dgvD_Status
            // 
            this.dgvD_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvD_Status.HeaderText = "Status";
            this.dgvD_Status.Name = "dgvD_Status";
            this.dgvD_Status.ReadOnly = true;
            // 
            // dgvD_modify
            // 
            this.dgvD_modify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvD_modify.HeaderText = "";
            this.dgvD_modify.Name = "dgvD_modify";
            this.dgvD_modify.ReadOnly = true;
            this.dgvD_modify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvD_modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvD_modify.Width = 78;
            // 
            // dgvD_cancel
            // 
            this.dgvD_cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvD_cancel.HeaderText = "";
            this.dgvD_cancel.Name = "dgvD_cancel";
            this.dgvD_cancel.ReadOnly = true;
            this.dgvD_cancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvD_cancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvD_cancel.Width = 78;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(10, 216);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(75, 23);
            this.bt_confirm.TabIndex = 1;
            this.bt_confirm.Text = "Received";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // dgv_completeOrder
            // 
            this.dgv_completeOrder.AllowUserToAddRows = false;
            this.dgv_completeOrder.AllowUserToDeleteRows = false;
            this.dgv_completeOrder.AllowUserToResizeColumns = false;
            this.dgv_completeOrder.AllowUserToResizeRows = false;
            this.dgv_completeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_completeOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_completeOrder.Location = new System.Drawing.Point(10, 16);
            this.dgv_completeOrder.Name = "dgv_completeOrder";
            this.dgv_completeOrder.RowHeadersVisible = false;
            this.dgv_completeOrder.RowTemplate.Height = 24;
            this.dgv_completeOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_completeOrder.Size = new System.Drawing.Size(907, 196);
            this.dgv_completeOrder.TabIndex = 0;
            this.dgv_completeOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_completeOrder_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Order Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Expect Receving Date ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Order ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // gpBox_Incomplete
            // 
            this.gpBox_Incomplete.Controls.Add(this.dgv_incompleteOrder);
            this.gpBox_Incomplete.Controls.Add(this.bt_confirm);
            this.gpBox_Incomplete.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_Incomplete.Location = new System.Drawing.Point(38, 77);
            this.gpBox_Incomplete.Name = "gpBox_Incomplete";
            this.gpBox_Incomplete.Size = new System.Drawing.Size(930, 245);
            this.gpBox_Incomplete.TabIndex = 5;
            this.gpBox_Incomplete.TabStop = false;
            this.gpBox_Incomplete.Text = "Incomplete Order";
            // 
            // gpBox_Complete
            // 
            this.gpBox_Complete.Controls.Add(this.dgv_completeOrder);
            this.gpBox_Complete.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_Complete.Location = new System.Drawing.Point(38, 328);
            this.gpBox_Complete.Name = "gpBox_Complete";
            this.gpBox_Complete.Size = new System.Drawing.Size(930, 218);
            this.gpBox_Complete.TabIndex = 6;
            this.gpBox_Complete.TabStop = false;
            this.gpBox_Complete.Text = "Completed Record in 30 Days";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 40);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(38, 552);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 27;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // OrderHistory
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1014, 605);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBox_Incomplete);
            this.Controls.Add(this.gpBox_Complete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.VisibleChanged += new System.EventHandler(this.OrderHistory_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incompleteOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_completeOrder)).EndInit();
            this.gpBox_Incomplete.ResumeLayout(false);
            this.gpBox_Complete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_incompleteOrder;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.DataGridView dgv_completeOrder;
        private System.Windows.Forms.GroupBox gpBox_Incomplete;
        private System.Windows.Forms.GroupBox gpBox_Complete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcD_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_expectRecevingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvD_Status;
        private System.Windows.Forms.DataGridViewButtonColumn dgvD_modify;
        private System.Windows.Forms.DataGridViewButtonColumn dgvD_cancel;
    }
}