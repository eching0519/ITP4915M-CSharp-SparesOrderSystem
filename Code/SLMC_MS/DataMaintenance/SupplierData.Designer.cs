namespace SLMC_MS
{
    partial class SupplierData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierData));
            this.lbl_search_name = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.txt_search_name = new System.Windows.Forms.TextBox();
            this.lbl_search_supplierID = new System.Windows.Forms.Label();
            this.dgv_supplierList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search_supplierID = new System.Windows.Forms.TextBox();
            this.gpBox_supplierList = new System.Windows.Forms.GroupBox();
            this.gpBox_supplierInformation = new System.Windows.Forms.GroupBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.txt_supAdd = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            this.lbl_supplierID = new System.Windows.Forms.Label();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.lbl_supAdd = new System.Windows.Forms.Label();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).BeginInit();
            this.gpBox_supplierList.SuspendLayout();
            this.gpBox_supplierInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_search_name
            // 
            this.lbl_search_name.AutoSize = true;
            this.lbl_search_name.Location = new System.Drawing.Point(13, 62);
            this.lbl_search_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_name.Name = "lbl_search_name";
            this.lbl_search_name.Size = new System.Drawing.Size(149, 23);
            this.lbl_search_name.TabIndex = 68;
            this.lbl_search_name.Text = "Supplier Name:";
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(305, 57);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(120, 25);
            this.bt_search.TabIndex = 8;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // txt_search_name
            // 
            this.txt_search_name.Location = new System.Drawing.Point(137, 57);
            this.txt_search_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search_name.Name = "txt_search_name";
            this.txt_search_name.Size = new System.Drawing.Size(160, 34);
            this.txt_search_name.TabIndex = 69;
            // 
            // lbl_search_supplierID
            // 
            this.lbl_search_supplierID.AutoSize = true;
            this.lbl_search_supplierID.Location = new System.Drawing.Point(13, 34);
            this.lbl_search_supplierID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_supplierID.Name = "lbl_search_supplierID";
            this.lbl_search_supplierID.Size = new System.Drawing.Size(119, 23);
            this.lbl_search_supplierID.TabIndex = 0;
            this.lbl_search_supplierID.Text = "Supplier ID:";
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
            this.dgv_supplierList.Location = new System.Drawing.Point(16, 86);
            this.dgv_supplierList.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_supplierList.Name = "dgv_supplierList";
            this.dgv_supplierList.ReadOnly = true;
            this.dgv_supplierList.RowHeadersVisible = false;
            this.dgv_supplierList.RowTemplate.Height = 24;
            this.dgv_supplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplierList.Size = new System.Drawing.Size(409, 298);
            this.dgv_supplierList.TabIndex = 9;
            this.dgv_supplierList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplierList_CellDoubleClick);
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
            // txt_search_supplierID
            // 
            this.txt_search_supplierID.Location = new System.Drawing.Point(137, 29);
            this.txt_search_supplierID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search_supplierID.Name = "txt_search_supplierID";
            this.txt_search_supplierID.Size = new System.Drawing.Size(160, 34);
            this.txt_search_supplierID.TabIndex = 1;
            // 
            // gpBox_supplierList
            // 
            this.gpBox_supplierList.Controls.Add(this.dgv_supplierList);
            this.gpBox_supplierList.Controls.Add(this.lbl_search_name);
            this.gpBox_supplierList.Controls.Add(this.txt_search_supplierID);
            this.gpBox_supplierList.Controls.Add(this.bt_search);
            this.gpBox_supplierList.Controls.Add(this.txt_search_name);
            this.gpBox_supplierList.Controls.Add(this.lbl_search_supplierID);
            this.gpBox_supplierList.Location = new System.Drawing.Point(418, 40);
            this.gpBox_supplierList.Name = "gpBox_supplierList";
            this.gpBox_supplierList.Size = new System.Drawing.Size(440, 399);
            this.gpBox_supplierList.TabIndex = 70;
            this.gpBox_supplierList.TabStop = false;
            this.gpBox_supplierList.Text = "Supplier List";
            // 
            // gpBox_supplierInformation
            // 
            this.gpBox_supplierInformation.Controls.Add(this.bt_clear);
            this.gpBox_supplierInformation.Controls.Add(this.txt_supAdd);
            this.gpBox_supplierInformation.Controls.Add(this.bt_submit);
            this.gpBox_supplierInformation.Controls.Add(this.txt_supplierID);
            this.gpBox_supplierInformation.Controls.Add(this.lbl_supplierID);
            this.gpBox_supplierInformation.Controls.Add(this.lbl_supplier);
            this.gpBox_supplierInformation.Controls.Add(this.lbl_supAdd);
            this.gpBox_supplierInformation.Controls.Add(this.txt_supplier);
            this.gpBox_supplierInformation.Location = new System.Drawing.Point(40, 87);
            this.gpBox_supplierInformation.Name = "gpBox_supplierInformation";
            this.gpBox_supplierInformation.Size = new System.Drawing.Size(372, 168);
            this.gpBox_supplierInformation.TabIndex = 71;
            this.gpBox_supplierInformation.TabStop = false;
            this.gpBox_supplierInformation.Text = "Supplier Information";
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(284, 136);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 73;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // txt_supAdd
            // 
            this.txt_supAdd.Location = new System.Drawing.Point(122, 100);
            this.txt_supAdd.Name = "txt_supAdd";
            this.txt_supAdd.Size = new System.Drawing.Size(237, 34);
            this.txt_supAdd.TabIndex = 77;
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(207, 136);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 72;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.Location = new System.Drawing.Point(122, 28);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(100, 34);
            this.txt_supplierID.TabIndex = 73;
            this.txt_supplierID.TextChanged += new System.EventHandler(this.txt_supplierID_TextChanged);
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Location = new System.Drawing.Point(9, 33);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(113, 23);
            this.lbl_supplierID.TabIndex = 72;
            this.lbl_supplierID.Text = "SupplierID:";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(9, 69);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(90, 23);
            this.lbl_supplier.TabIndex = 74;
            this.lbl_supplier.Text = "Supplier:";
            // 
            // lbl_supAdd
            // 
            this.lbl_supAdd.AutoSize = true;
            this.lbl_supAdd.Location = new System.Drawing.Point(9, 105);
            this.lbl_supAdd.Name = "lbl_supAdd";
            this.lbl_supAdd.Size = new System.Drawing.Size(167, 23);
            this.lbl_supAdd.TabIndex = 76;
            this.lbl_supAdd.Text = "Supplier Address:";
            // 
            // txt_supplier
            // 
            this.txt_supplier.Location = new System.Drawing.Point(122, 64);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(100, 34);
            this.txt_supplier.TabIndex = 75;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 40);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(40, 404);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 73;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SupplierData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 466);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBox_supplierInformation);
            this.Controls.Add(this.gpBox_supplierList);
            this.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierData";
            this.Text = "Supplier Data";
            this.Load += new System.EventHandler(this.SupplierData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).EndInit();
            this.gpBox_supplierList.ResumeLayout(false);
            this.gpBox_supplierList.PerformLayout();
            this.gpBox_supplierInformation.ResumeLayout(false);
            this.gpBox_supplierInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_search_name;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox txt_search_name;
        private System.Windows.Forms.Label lbl_search_supplierID;
        private System.Windows.Forms.DataGridView dgv_supplierList;
        private System.Windows.Forms.TextBox txt_search_supplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gpBox_supplierList;
        private System.Windows.Forms.GroupBox gpBox_supplierInformation;
        private System.Windows.Forms.TextBox txt_supAdd;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.Label lbl_supplierID;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Label lbl_supAdd;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}