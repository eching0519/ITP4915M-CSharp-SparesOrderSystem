namespace SLMC_MS
{
    partial class SupplierList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierList));
            this.lbl_name = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_supplierID = new System.Windows.Forms.Label();
            this.dgv_supplierList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(22, 59);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(149, 23);
            this.lbl_name.TabIndex = 68;
            this.lbl_name.Text = "Supplier Name:";
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(345, 54);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(120, 25);
            this.bt_search.TabIndex = 8;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(146, 54);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(160, 34);
            this.txt_name.TabIndex = 69;
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Location = new System.Drawing.Point(22, 31);
            this.lbl_supplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(119, 23);
            this.lbl_supplierID.TabIndex = 0;
            this.lbl_supplierID.Text = "Supplier ID:";
            // 
            // dgv_supplierList
            // 
            this.dgv_supplierList.AllowUserToAddRows = false;
            this.dgv_supplierList.AllowUserToDeleteRows = false;
            this.dgv_supplierList.AllowUserToResizeColumns = false;
            this.dgv_supplierList.AllowUserToResizeRows = false;
            this.dgv_supplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_supplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_supplierList.Location = new System.Drawing.Point(25, 89);
            this.dgv_supplierList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_supplierList.Name = "dgv_supplierList";
            this.dgv_supplierList.ReadOnly = true;
            this.dgv_supplierList.RowHeadersVisible = false;
            this.dgv_supplierList.RowTemplate.Height = 24;
            this.dgv_supplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplierList.Size = new System.Drawing.Size(440, 506);
            this.dgv_supplierList.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Supplier ID";
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
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.Location = new System.Drawing.Point(146, 26);
            this.txt_supplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(160, 34);
            this.txt_supplierID.TabIndex = 1;
            // 
            // SupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 619);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.lbl_supplierID);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_supplierID);
            this.Controls.Add(this.dgv_supplierList);
            this.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierList";
            this.Text = "Supplier List";
            this.Load += new System.EventHandler(this.SupplierList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_supplierID;
        private System.Windows.Forms.DataGridView dgv_supplierList;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}