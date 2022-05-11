namespace SLMC_MS
{
    partial class SparePartsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SparePartsControl));
            this.txt_DangerLine = new System.Windows.Forms.TextBox();
            this.txt_ReorderLine = new System.Windows.Forms.TextBox();
            this.lbl_dangerLine = new System.Windows.Forms.Label();
            this.lbl_reorderLine = new System.Windows.Forms.Label();
            this.dgv_SearchingList = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DangerLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_search_itemID = new System.Windows.Forms.Label();
            this.txt_search_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_search_name = new System.Windows.Forms.Label();
            this.txt_search_Name = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpBox_itemList = new System.Windows.Forms.GroupBox();
            this.ckBox_undefinedLocation = new System.Windows.Forms.CheckBox();
            this.ckBox_undefinedLine = new System.Windows.Forms.CheckBox();
            this.gpBox_itemInfo = new System.Windows.Forms.GroupBox();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.txt_name_ch = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.lbl_name_ch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gpBox_itemList.SuspendLayout();
            this.gpBox_itemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DangerLine
            // 
            this.txt_DangerLine.Location = new System.Drawing.Point(176, 255);
            this.txt_DangerLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DangerLine.Name = "txt_DangerLine";
            this.txt_DangerLine.Size = new System.Drawing.Size(181, 34);
            this.txt_DangerLine.TabIndex = 7;
            // 
            // txt_ReorderLine
            // 
            this.txt_ReorderLine.Location = new System.Drawing.Point(176, 323);
            this.txt_ReorderLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ReorderLine.Name = "txt_ReorderLine";
            this.txt_ReorderLine.Size = new System.Drawing.Size(181, 34);
            this.txt_ReorderLine.TabIndex = 9;
            // 
            // lbl_dangerLine
            // 
            this.lbl_dangerLine.AutoSize = true;
            this.lbl_dangerLine.Location = new System.Drawing.Point(33, 263);
            this.lbl_dangerLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dangerLine.Name = "lbl_dangerLine";
            this.lbl_dangerLine.Size = new System.Drawing.Size(121, 23);
            this.lbl_dangerLine.TabIndex = 6;
            this.lbl_dangerLine.Text = "Danger Line";
            // 
            // lbl_reorderLine
            // 
            this.lbl_reorderLine.AutoSize = true;
            this.lbl_reorderLine.Location = new System.Drawing.Point(33, 332);
            this.lbl_reorderLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reorderLine.Name = "lbl_reorderLine";
            this.lbl_reorderLine.Size = new System.Drawing.Size(126, 23);
            this.lbl_reorderLine.TabIndex = 8;
            this.lbl_reorderLine.Text = "Reorder Line";
            // 
            // dgv_SearchingList
            // 
            this.dgv_SearchingList.AllowUserToAddRows = false;
            this.dgv_SearchingList.AllowUserToDeleteRows = false;
            this.dgv_SearchingList.AllowUserToResizeColumns = false;
            this.dgv_SearchingList.AllowUserToResizeRows = false;
            this.dgv_SearchingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SearchingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_SearchingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.name,
            this.DangerLevel,
            this.ReorderLevel,
            this.Location});
            this.dgv_SearchingList.Location = new System.Drawing.Point(32, 170);
            this.dgv_SearchingList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_SearchingList.Name = "dgv_SearchingList";
            this.dgv_SearchingList.ReadOnly = true;
            this.dgv_SearchingList.RowHeadersVisible = false;
            this.dgv_SearchingList.RowTemplate.Height = 24;
            this.dgv_SearchingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SearchingList.Size = new System.Drawing.Size(837, 508);
            this.dgv_SearchingList.TabIndex = 6;
            this.dgv_SearchingList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchingList_CellDoubleClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // DangerLevel
            // 
            this.DangerLevel.HeaderText = "Danger Line";
            this.DangerLevel.Name = "DangerLevel";
            this.DangerLevel.ReadOnly = true;
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.HeaderText = "Reorder Line";
            this.ReorderLevel.Name = "ReorderLevel";
            this.ReorderLevel.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // lbl_search_itemID
            // 
            this.lbl_search_itemID.AutoSize = true;
            this.lbl_search_itemID.Location = new System.Drawing.Point(32, 55);
            this.lbl_search_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_itemID.Name = "lbl_search_itemID";
            this.lbl_search_itemID.Size = new System.Drawing.Size(79, 23);
            this.lbl_search_itemID.TabIndex = 0;
            this.lbl_search_itemID.Text = "Item ID";
            // 
            // txt_search_ItemID
            // 
            this.txt_search_ItemID.Location = new System.Drawing.Point(118, 47);
            this.txt_search_ItemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search_ItemID.Name = "txt_search_ItemID";
            this.txt_search_ItemID.Size = new System.Drawing.Size(166, 34);
            this.txt_search_ItemID.TabIndex = 1;
            this.txt_search_ItemID.TextChanged += new System.EventHandler(this.txt_search_ItemID_TextChanged);
            // 
            // lbl_search_name
            // 
            this.lbl_search_name.AutoSize = true;
            this.lbl_search_name.Location = new System.Drawing.Point(32, 107);
            this.lbl_search_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search_name.Name = "lbl_search_name";
            this.lbl_search_name.Size = new System.Drawing.Size(63, 23);
            this.lbl_search_name.TabIndex = 2;
            this.lbl_search_name.Text = "Name";
            // 
            // txt_search_Name
            // 
            this.txt_search_Name.Location = new System.Drawing.Point(118, 98);
            this.txt_search_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search_Name.Name = "txt_search_Name";
            this.txt_search_Name.Size = new System.Drawing.Size(166, 34);
            this.txt_search_Name.TabIndex = 3;
            this.txt_search_Name.TextChanged += new System.EventHandler(this.txt_search_Name_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gpBox_itemList
            // 
            this.gpBox_itemList.Controls.Add(this.ckBox_undefinedLocation);
            this.gpBox_itemList.Controls.Add(this.ckBox_undefinedLine);
            this.gpBox_itemList.Controls.Add(this.lbl_search_itemID);
            this.gpBox_itemList.Controls.Add(this.txt_search_ItemID);
            this.gpBox_itemList.Controls.Add(this.lbl_search_name);
            this.gpBox_itemList.Controls.Add(this.dgv_SearchingList);
            this.gpBox_itemList.Controls.Add(this.txt_search_Name);
            this.gpBox_itemList.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_itemList.Location = new System.Drawing.Point(504, 83);
            this.gpBox_itemList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_itemList.Name = "gpBox_itemList";
            this.gpBox_itemList.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_itemList.Size = new System.Drawing.Size(900, 700);
            this.gpBox_itemList.TabIndex = 23;
            this.gpBox_itemList.TabStop = false;
            this.gpBox_itemList.Text = "Item List";
            // 
            // ckBox_undefinedLocation
            // 
            this.ckBox_undefinedLocation.AutoSize = true;
            this.ckBox_undefinedLocation.Location = new System.Drawing.Point(330, 103);
            this.ckBox_undefinedLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckBox_undefinedLocation.Name = "ckBox_undefinedLocation";
            this.ckBox_undefinedLocation.Size = new System.Drawing.Size(387, 27);
            this.ckBox_undefinedLocation.TabIndex = 5;
            this.ckBox_undefinedLocation.Text = "Don\'t select items with defined location";
            this.ckBox_undefinedLocation.UseVisualStyleBackColor = true;
            this.ckBox_undefinedLocation.CheckedChanged += new System.EventHandler(this.ckBox_undefinedLocation_CheckedChanged);
            // 
            // ckBox_undefinedLine
            // 
            this.ckBox_undefinedLine.AutoSize = true;
            this.ckBox_undefinedLine.Location = new System.Drawing.Point(330, 52);
            this.ckBox_undefinedLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckBox_undefinedLine.Name = "ckBox_undefinedLine";
            this.ckBox_undefinedLine.Size = new System.Drawing.Size(535, 27);
            this.ckBox_undefinedLine.TabIndex = 4;
            this.ckBox_undefinedLine.Text = "Don\'t select items with defined danger line / reorder line";
            this.ckBox_undefinedLine.UseVisualStyleBackColor = true;
            this.ckBox_undefinedLine.CheckedChanged += new System.EventHandler(this.ckBox_undefinedLine_CheckedChanged);
            // 
            // gpBox_itemInfo
            // 
            this.gpBox_itemInfo.Controls.Add(this.txt_DangerLine);
            this.gpBox_itemInfo.Controls.Add(this.lbl_dangerLine);
            this.gpBox_itemInfo.Controls.Add(this.lbl_itemID);
            this.gpBox_itemInfo.Controls.Add(this.txt_ReorderLine);
            this.gpBox_itemInfo.Controls.Add(this.lbl_name);
            this.gpBox_itemInfo.Controls.Add(this.lbl_reorderLine);
            this.gpBox_itemInfo.Controls.Add(this.lbl_location);
            this.gpBox_itemInfo.Controls.Add(this.txt_ItemID);
            this.gpBox_itemInfo.Controls.Add(this.bt_clear);
            this.gpBox_itemInfo.Controls.Add(this.txt_name);
            this.gpBox_itemInfo.Controls.Add(this.bt_submit);
            this.gpBox_itemInfo.Controls.Add(this.txt_name_ch);
            this.gpBox_itemInfo.Controls.Add(this.txt_location);
            this.gpBox_itemInfo.Controls.Add(this.lbl_name_ch);
            this.gpBox_itemInfo.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpBox_itemInfo.Location = new System.Drawing.Point(69, 182);
            this.gpBox_itemInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_itemInfo.Name = "gpBox_itemInfo";
            this.gpBox_itemInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpBox_itemInfo.Size = new System.Drawing.Size(410, 527);
            this.gpBox_itemInfo.TabIndex = 30;
            this.gpBox_itemInfo.TabStop = false;
            this.gpBox_itemInfo.Text = "Item Information";
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Location = new System.Drawing.Point(33, 58);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(79, 23);
            this.lbl_itemID.TabIndex = 0;
            this.lbl_itemID.Text = "Item ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(33, 127);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(128, 23);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name (ENG)";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(33, 400);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(133, 23);
            this.lbl_location.TabIndex = 10;
            this.lbl_location.Text = "Located Shelf";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(176, 50);
            this.txt_ItemID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(181, 34);
            this.txt_ItemID.TabIndex = 1;
            this.txt_ItemID.TextChanged += new System.EventHandler(this.txt_ItemID_TextChanged);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(246, 460);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(112, 38);
            this.bt_clear.TabIndex = 13;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(176, 118);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(181, 34);
            this.txt_name.TabIndex = 3;
            // 
            // bt_submit
            // 
            this.bt_submit.Location = new System.Drawing.Point(124, 460);
            this.bt_submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(112, 38);
            this.bt_submit.TabIndex = 12;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // txt_name_ch
            // 
            this.txt_name_ch.Location = new System.Drawing.Point(176, 187);
            this.txt_name_ch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name_ch.Name = "txt_name_ch";
            this.txt_name_ch.ReadOnly = true;
            this.txt_name_ch.Size = new System.Drawing.Size(181, 34);
            this.txt_name_ch.TabIndex = 5;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(176, 392);
            this.txt_location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(181, 34);
            this.txt_location.TabIndex = 11;
            // 
            // lbl_name_ch
            // 
            this.lbl_name_ch.AutoSize = true;
            this.lbl_name_ch.Location = new System.Drawing.Point(90, 195);
            this.lbl_name_ch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name_ch.Name = "lbl_name_ch";
            this.lbl_name_ch.Size = new System.Drawing.Size(61, 23);
            this.lbl_name_ch.TabIndex = 4;
            this.lbl_name_ch.Text = "(CHI)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 67);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(69, 725);
            this.picBox_return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(86, 58);
            this.picBox_return.TabIndex = 68;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // SparePartsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 870);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpBox_itemInfo);
            this.Controls.Add(this.gpBox_itemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SparePartsControl";
            this.Text = "SparePartsControlSetting";
            this.Load += new System.EventHandler(this.SparePartsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gpBox_itemList.ResumeLayout(false);
            this.gpBox_itemList.PerformLayout();
            this.gpBox_itemInfo.ResumeLayout(false);
            this.gpBox_itemInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DangerLine;
        private System.Windows.Forms.TextBox txt_ReorderLine;
        private System.Windows.Forms.Label lbl_dangerLine;
        private System.Windows.Forms.Label lbl_reorderLine;
        private System.Windows.Forms.DataGridView dgv_SearchingList;
        private System.Windows.Forms.Label lbl_search_itemID;
        private System.Windows.Forms.TextBox txt_search_ItemID;
        private System.Windows.Forms.Label lbl_search_name;
        private System.Windows.Forms.TextBox txt_search_Name;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox gpBox_itemList;
        private System.Windows.Forms.CheckBox ckBox_undefinedLine;
        private System.Windows.Forms.GroupBox gpBox_itemInfo;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.TextBox txt_name_ch;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label lbl_name_ch;
        private System.Windows.Forms.CheckBox ckBox_undefinedLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DangerLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_return;
    }
}