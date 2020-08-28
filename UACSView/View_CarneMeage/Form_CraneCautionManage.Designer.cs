namespace UACSView.View_CarneMeage
{
    partial class Form_CraneCautionManage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MessageRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRANE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.PalTop = new System.Windows.Forms.Panel();
            this.PalMiddle = new System.Windows.Forms.Panel();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.CombTru = new System.Windows.Forms.ComboBox();
            this.LabCode = new System.Windows.Forms.Label();
            this.ButSelect = new System.Windows.Forms.Button();
            this.LabTrue = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.LabDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PalTop.SuspendLayout();
            this.PalMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageRank,
            this.Date,
            this.Module,
            this.CRANE_NO,
            this.MAT_NO,
            this.TrueDate,
            this.TrueMan,
            this.Message});
            this.dataGridView1.Location = new System.Drawing.Point(-8, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1284, 433);
            this.dataGridView1.TabIndex = 19;
            // 
            // MessageRank
            // 
            this.MessageRank.DataPropertyName = "MessageRank";
            this.MessageRank.FillWeight = 67.87527F;
            this.MessageRank.HeaderText = "信息级别";
            this.MessageRank.Name = "MessageRank";
            this.MessageRank.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd";
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.FillWeight = 67.87527F;
            this.Date.HeaderText = "日志日期";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Module
            // 
            this.Module.DataPropertyName = "Module";
            this.Module.FillWeight = 67.87527F;
            this.Module.HeaderText = "模块名";
            this.Module.Name = "Module";
            this.Module.ReadOnly = true;
            // 
            // CRANE_NO
            // 
            this.CRANE_NO.DataPropertyName = "CRANE_NO";
            this.CRANE_NO.FillWeight = 67.87527F;
            this.CRANE_NO.HeaderText = "行车号";
            this.CRANE_NO.Name = "CRANE_NO";
            this.CRANE_NO.ReadOnly = true;
            // 
            // MAT_NO
            // 
            this.MAT_NO.DataPropertyName = "MAT_NO";
            this.MAT_NO.FillWeight = 67.87527F;
            this.MAT_NO.HeaderText = "材料号";
            this.MAT_NO.Name = "MAT_NO";
            this.MAT_NO.ReadOnly = true;
            // 
            // TrueDate
            // 
            this.TrueDate.DataPropertyName = "TrueDate";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd";
            this.TrueDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.TrueDate.FillWeight = 67.87527F;
            this.TrueDate.HeaderText = "确定日期";
            this.TrueDate.Name = "TrueDate";
            this.TrueDate.ReadOnly = true;
            // 
            // TrueMan
            // 
            this.TrueMan.DataPropertyName = "TrueMan";
            this.TrueMan.FillWeight = 67.87527F;
            this.TrueMan.HeaderText = "是否确定";
            this.TrueMan.Name = "TrueMan";
            this.TrueMan.ReadOnly = true;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.FillWeight = 324.8731F;
            this.Message.HeaderText = "内容";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(552, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "报警信息管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PalTop
            // 
            this.PalTop.BackColor = System.Drawing.Color.Silver;
            this.PalTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PalTop.Controls.Add(this.label1);
            this.PalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PalTop.Location = new System.Drawing.Point(0, 0);
            this.PalTop.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PalTop.Name = "PalTop";
            this.PalTop.Size = new System.Drawing.Size(1276, 72);
            this.PalTop.TabIndex = 17;
            // 
            // PalMiddle
            // 
            this.PalMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PalMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PalMiddle.Controls.Add(this.TxtCode);
            this.PalMiddle.Controls.Add(this.CombTru);
            this.PalMiddle.Controls.Add(this.LabCode);
            this.PalMiddle.Controls.Add(this.ButSelect);
            this.PalMiddle.Controls.Add(this.LabTrue);
            this.PalMiddle.Controls.Add(this.dateTimeEnd);
            this.PalMiddle.Controls.Add(this.dateTimeStart);
            this.PalMiddle.Controls.Add(this.LabDate);
            this.PalMiddle.Location = new System.Drawing.Point(-8, 72);
            this.PalMiddle.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PalMiddle.Name = "PalMiddle";
            this.PalMiddle.Size = new System.Drawing.Size(1292, 160);
            this.PalMiddle.TabIndex = 20;
            this.PalMiddle.Paint += new System.Windows.Forms.PaintEventHandler(this.PalMiddle_Paint);
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtCode.Location = new System.Drawing.Point(658, 22);
            this.TxtCode.Multiline = true;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCode.Size = new System.Drawing.Size(160, 30);
            this.TxtCode.TabIndex = 15;
            // 
            // CombTru
            // 
            this.CombTru.DisplayMember = "TrueMan";
            this.CombTru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombTru.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CombTru.FormattingEnabled = true;
            this.CombTru.Location = new System.Drawing.Point(658, 98);
            this.CombTru.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.CombTru.Name = "CombTru";
            this.CombTru.Size = new System.Drawing.Size(164, 30);
            this.CombTru.TabIndex = 10;
            this.CombTru.ValueMember = "TrueMan";
            this.CombTru.Visible = false;
            this.CombTru.SelectedIndexChanged += new System.EventHandler(this.CombTru_SelectedIndexChanged);
            // 
            // LabCode
            // 
            this.LabCode.AutoSize = true;
            this.LabCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabCode.Location = new System.Drawing.Point(561, 30);
            this.LabCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabCode.Name = "LabCode";
            this.LabCode.Size = new System.Drawing.Size(74, 22);
            this.LabCode.TabIndex = 4;
            this.LabCode.Text = "材料号：";
            // 
            // ButSelect
            // 
            this.ButSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButSelect.ForeColor = System.Drawing.Color.Black;
            this.ButSelect.Location = new System.Drawing.Point(1081, 45);
            this.ButSelect.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButSelect.Name = "ButSelect";
            this.ButSelect.Size = new System.Drawing.Size(96, 51);
            this.ButSelect.TabIndex = 7;
            this.ButSelect.Text = "查询";
            this.ButSelect.UseVisualStyleBackColor = false;
            this.ButSelect.Click += new System.EventHandler(this.ButSelect_Click_1);
            // 
            // LabTrue
            // 
            this.LabTrue.AutoSize = true;
            this.LabTrue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTrue.Location = new System.Drawing.Point(522, 101);
            this.LabTrue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabTrue.Name = "LabTrue";
            this.LabTrue.Size = new System.Drawing.Size(90, 22);
            this.LabTrue.TabIndex = 4;
            this.LabTrue.Text = "是否确定：";
            this.LabTrue.Visible = false;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(273, 17);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(155, 29);
            this.dateTimeEnd.TabIndex = 2;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimeStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(93, 17);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(155, 29);
            this.dateTimeStart.TabIndex = 1;
            // 
            // LabDate
            // 
            this.LabDate.AutoSize = true;
            this.LabDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabDate.Location = new System.Drawing.Point(14, 20);
            this.LabDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabDate.Name = "LabDate";
            this.LabDate.Size = new System.Drawing.Size(90, 22);
            this.LabDate.TabIndex = 0;
            this.LabDate.Text = "日志日期：";
            // 
            // Form_CraneCautionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.PalMiddle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PalTop);
            this.Name = "Form_CraneCautionManage";
            this.Text = "报警信息管理";
            this.Load += new System.EventHandler(this.Form_CraneCautionManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PalTop.ResumeLayout(false);
            this.PalTop.PerformLayout();
            this.PalMiddle.ResumeLayout(false);
            this.PalMiddle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PalTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRANE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.Panel PalMiddle;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.ComboBox CombTru;
        private System.Windows.Forms.Label LabCode;
        private System.Windows.Forms.Button ButSelect;
        private System.Windows.Forms.Label LabTrue;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label LabDate;
    }
}