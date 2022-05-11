namespace SLMC_MS
{
    partial class BroadcastMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BroadcastMessage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.dtPicker__deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.ckList_receiver = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_receiver = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_msg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_msgID = new System.Windows.Forms.Label();
            this.btn_newMsg = new System.Windows.Forms.Button();
            this.picBox_return = new System.Windows.Forms.PictureBox();
            this.btn_setTarget = new System.Windows.Forms.Button();
            this.panel_target = new System.Windows.Forms.Panel();
            this.btn_setTargetValue = new System.Windows.Forms.Button();
            this.txt_targetValue = new System.Windows.Forms.TextBox();
            this.cbBox_month = new System.Windows.Forms.ComboBox();
            this.cbBox_year = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_receiver.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_msg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).BeginInit();
            this.panel_target.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 40);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_history
            // 
            this.dgv_history.AllowUserToAddRows = false;
            this.dgv_history.AllowUserToDeleteRows = false;
            this.dgv_history.AllowUserToResizeColumns = false;
            this.dgv_history.AllowUserToResizeRows = false;
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_history.Location = new System.Drawing.Point(44, 90);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.RowHeadersVisible = false;
            this.dgv_history.RowTemplate.Height = 27;
            this.dgv_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_history.Size = new System.Drawing.Size(552, 325);
            this.dgv_history.TabIndex = 72;
            this.dgv_history.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_history_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "MsgID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Create on";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Format = "d";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Deliver on";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(89, 0);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(380, 25);
            this.txt_title.TabIndex = 73;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(3, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(34, 15);
            this.lbl_title.TabIndex = 74;
            this.lbl_title.Text = "Title";
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(3, 5);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(51, 15);
            this.lbl_content.TabIndex = 75;
            this.lbl_content.Text = "Content";
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(89, 0);
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(380, 120);
            this.txt_content.TabIndex = 76;
            // 
            // dtPicker__deliveryDate
            // 
            this.dtPicker__deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker__deliveryDate.Location = new System.Drawing.Point(89, 0);
            this.dtPicker__deliveryDate.Name = "dtPicker__deliveryDate";
            this.dtPicker__deliveryDate.Size = new System.Drawing.Size(200, 25);
            this.dtPicker__deliveryDate.TabIndex = 77;
            this.dtPicker__deliveryDate.ValueChanged += new System.EventHandler(this.dtPicker__deliveryDate_ValueChanged);
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Location = new System.Drawing.Point(3, 5);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(86, 15);
            this.lbl_deliveryDate.TabIndex = 78;
            this.lbl_deliveryDate.Text = "Delivery Date";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(332, 281);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(140, 34);
            this.btn_submit.TabIndex = 79;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(186, 281);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(140, 34);
            this.btn_del.TabIndex = 80;
            this.btn_del.Text = "Delete Message";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Location = new System.Drawing.Point(3, 5);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(56, 15);
            this.lbl_receiver.TabIndex = 81;
            this.lbl_receiver.Text = "Receiver";
            // 
            // ckList_receiver
            // 
            this.ckList_receiver.CheckOnClick = true;
            this.ckList_receiver.FormattingEnabled = true;
            this.ckList_receiver.Location = new System.Drawing.Point(89, 0);
            this.ckList_receiver.Name = "ckList_receiver";
            this.ckList_receiver.Size = new System.Drawing.Size(200, 84);
            this.ckList_receiver.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_title);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 25);
            this.panel1.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtPicker__deliveryDate);
            this.panel2.Controls.Add(this.lbl_deliveryDate);
            this.panel2.Location = new System.Drawing.Point(3, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 25);
            this.panel2.TabIndex = 84;
            // 
            // panel_receiver
            // 
            this.panel_receiver.Controls.Add(this.ckList_receiver);
            this.panel_receiver.Controls.Add(this.lbl_receiver);
            this.panel_receiver.Location = new System.Drawing.Point(3, 65);
            this.panel_receiver.Name = "panel_receiver";
            this.panel_receiver.Size = new System.Drawing.Size(469, 84);
            this.panel_receiver.TabIndex = 85;
            this.panel_receiver.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_content);
            this.panel4.Controls.Add(this.lbl_content);
            this.panel4.Location = new System.Drawing.Point(3, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 120);
            this.panel4.TabIndex = 86;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel_receiver);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.btn_submit);
            this.flowLayoutPanel1.Controls.Add(this.btn_del);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(475, 320);
            this.flowLayoutPanel1.TabIndex = 89;
            // 
            // panel_msg
            // 
            this.panel_msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_msg.Controls.Add(this.label1);
            this.panel_msg.Controls.Add(this.lbl_msgID);
            this.panel_msg.Controls.Add(this.flowLayoutPanel1);
            this.panel_msg.Location = new System.Drawing.Point(56, 53);
            this.panel_msg.Name = "panel_msg";
            this.panel_msg.Size = new System.Drawing.Size(528, 395);
            this.panel_msg.TabIndex = 90;
            this.panel_msg.Visible = false;
            this.panel_msg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_msg_MouseDown);
            this.panel_msg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_msg_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 32);
            this.label1.TabIndex = 105;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_msgID
            // 
            this.lbl_msgID.AutoSize = true;
            this.lbl_msgID.Location = new System.Drawing.Point(3, 2);
            this.lbl_msgID.Name = "lbl_msgID";
            this.lbl_msgID.Size = new System.Drawing.Size(47, 15);
            this.lbl_msgID.TabIndex = 75;
            this.lbl_msgID.Text = "MsgID";
            this.lbl_msgID.Visible = false;
            this.lbl_msgID.TextChanged += new System.EventHandler(this.lbl_msgID_TextChanged);
            this.lbl_msgID.VisibleChanged += new System.EventHandler(this.lbl_msgID_VisibleChanged);
            // 
            // btn_newMsg
            // 
            this.btn_newMsg.Location = new System.Drawing.Point(428, 44);
            this.btn_newMsg.Name = "btn_newMsg";
            this.btn_newMsg.Size = new System.Drawing.Size(168, 40);
            this.btn_newMsg.TabIndex = 80;
            this.btn_newMsg.Text = "New Message";
            this.btn_newMsg.UseVisualStyleBackColor = true;
            this.btn_newMsg.Click += new System.EventHandler(this.btn_newMsg_Click);
            // 
            // picBox_return
            // 
            this.picBox_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_return.Image = global::SLMC_MS.Properties.Resources.return_button;
            this.picBox_return.Location = new System.Drawing.Point(44, 422);
            this.picBox_return.Name = "picBox_return";
            this.picBox_return.Size = new System.Drawing.Size(57, 35);
            this.picBox_return.TabIndex = 91;
            this.picBox_return.TabStop = false;
            this.picBox_return.Click += new System.EventHandler(this.picBox_return_Click);
            // 
            // btn_setTarget
            // 
            this.btn_setTarget.Location = new System.Drawing.Point(294, 44);
            this.btn_setTarget.Name = "btn_setTarget";
            this.btn_setTarget.Size = new System.Drawing.Size(128, 40);
            this.btn_setTarget.TabIndex = 92;
            this.btn_setTarget.Text = "Set Target";
            this.btn_setTarget.UseVisualStyleBackColor = true;
            this.btn_setTarget.Visible = false;
            this.btn_setTarget.Click += new System.EventHandler(this.btn_setTarget_Click);
            // 
            // panel_target
            // 
            this.panel_target.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_target.Controls.Add(this.btn_setTargetValue);
            this.panel_target.Controls.Add(this.txt_targetValue);
            this.panel_target.Controls.Add(this.cbBox_month);
            this.panel_target.Controls.Add(this.cbBox_year);
            this.panel_target.Controls.Add(this.label2);
            this.panel_target.Location = new System.Drawing.Point(196, 90);
            this.panel_target.Name = "panel_target";
            this.panel_target.Size = new System.Drawing.Size(400, 61);
            this.panel_target.TabIndex = 93;
            this.panel_target.Visible = false;
            this.panel_target.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_target_MouseDown);
            this.panel_target.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_target_MouseMove);
            // 
            // btn_setTargetValue
            // 
            this.btn_setTargetValue.Location = new System.Drawing.Point(291, 19);
            this.btn_setTargetValue.Name = "btn_setTargetValue";
            this.btn_setTargetValue.Size = new System.Drawing.Size(75, 23);
            this.btn_setTargetValue.TabIndex = 110;
            this.btn_setTargetValue.Text = "Set";
            this.btn_setTargetValue.UseVisualStyleBackColor = true;
            this.btn_setTargetValue.Click += new System.EventHandler(this.btn_setTargetValue_Click);
            // 
            // txt_targetValue
            // 
            this.txt_targetValue.Location = new System.Drawing.Point(184, 18);
            this.txt_targetValue.Name = "txt_targetValue";
            this.txt_targetValue.Size = new System.Drawing.Size(100, 25);
            this.txt_targetValue.TabIndex = 109;
            // 
            // cbBox_month
            // 
            this.cbBox_month.FormattingEnabled = true;
            this.cbBox_month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbBox_month.Location = new System.Drawing.Point(24, 19);
            this.cbBox_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBox_month.Name = "cbBox_month";
            this.cbBox_month.Size = new System.Drawing.Size(74, 23);
            this.cbBox_month.TabIndex = 108;
            this.cbBox_month.SelectedIndexChanged += new System.EventHandler(this.cbBox_month_SelectedIndexChanged);
            // 
            // cbBox_year
            // 
            this.cbBox_year.FormattingEnabled = true;
            this.cbBox_year.Location = new System.Drawing.Point(104, 19);
            this.cbBox_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBox_year.Name = "cbBox_year";
            this.cbBox_year.Size = new System.Drawing.Size(74, 23);
            this.cbBox_year.TabIndex = 107;
            this.cbBox_year.SelectedIndexChanged += new System.EventHandler(this.cbBox_year_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 32);
            this.label2.TabIndex = 106;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BroadcastMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 501);
            this.Controls.Add(this.panel_msg);
            this.Controls.Add(this.panel_target);
            this.Controls.Add(this.picBox_return);
            this.Controls.Add(this.btn_newMsg);
            this.Controls.Add(this.dgv_history);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_setTarget);
            this.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BroadcastMessage";
            this.Text = "BroadcastMessage";
            this.Load += new System.EventHandler(this.BroadcastMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_receiver.ResumeLayout(false);
            this.panel_receiver.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel_msg.ResumeLayout(false);
            this.panel_msg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_return)).EndInit();
            this.panel_target.ResumeLayout(false);
            this.panel_target.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.DateTimePicker dtPicker__deliveryDate;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.CheckedListBox ckList_receiver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_receiver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_msg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbl_msgID;
        private System.Windows.Forms.Button btn_newMsg;
        private System.Windows.Forms.PictureBox picBox_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_setTarget;
        private System.Windows.Forms.Panel panel_target;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBox_month;
        private System.Windows.Forms.ComboBox cbBox_year;
        private System.Windows.Forms.Button btn_setTargetValue;
        private System.Windows.Forms.TextBox txt_targetValue;
    }
}