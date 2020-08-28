namespace UACSView.View_CarneMeage
{
    partial class Form_CraneMessage02
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LASER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TREAMENT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INDEX_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REC_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.labMiddle2 = new System.Windows.Forms.Label();
            this.butSelect = new System.Windows.Forms.Button();
            this.combType = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.LabDate = new System.Windows.Forms.Label();
            this.PalTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.PalTop.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LASER_ID,
            this.TREAMENT_NO,
            this.XMAX,
            this.XMIN,
            this.YMAX,
            this.YMIN,
            this.INDEX_Y,
            this.X_CENTER,
            this.Y_CENTER,
            this.REC_TIME});
            this.dataGridView1.Location = new System.Drawing.Point(0, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 425);
            this.dataGridView1.TabIndex = 15;
            // 
            // LASER_ID
            // 
            this.LASER_ID.DataPropertyName = "LASER_ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LASER_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.LASER_ID.HeaderText = "LASER_ID";
            this.LASER_ID.Name = "LASER_ID";
            this.LASER_ID.ReadOnly = true;
            // 
            // TREAMENT_NO
            // 
            this.TREAMENT_NO.DataPropertyName = "TREAMENT_NO";
            this.TREAMENT_NO.HeaderText = "TREAMENT_NO";
            this.TREAMENT_NO.Name = "TREAMENT_NO";
            this.TREAMENT_NO.ReadOnly = true;
            // 
            // XMAX
            // 
            this.XMAX.DataPropertyName = "XMAX";
            this.XMAX.HeaderText = "XMAX";
            this.XMAX.Name = "XMAX";
            this.XMAX.ReadOnly = true;
            // 
            // XMIN
            // 
            this.XMIN.DataPropertyName = "XMIN";
            this.XMIN.HeaderText = "XMIN";
            this.XMIN.Name = "XMIN";
            this.XMIN.ReadOnly = true;
            // 
            // YMAX
            // 
            this.YMAX.DataPropertyName = "YMAX";
            this.YMAX.HeaderText = "YMAX";
            this.YMAX.Name = "YMAX";
            this.YMAX.ReadOnly = true;
            // 
            // YMIN
            // 
            this.YMIN.DataPropertyName = "YMIN";
            this.YMIN.HeaderText = "YMIN";
            this.YMIN.Name = "YMIN";
            this.YMIN.ReadOnly = true;
            // 
            // INDEX_Y
            // 
            this.INDEX_Y.DataPropertyName = "INDEX_Y";
            this.INDEX_Y.HeaderText = "INDEX_Y";
            this.INDEX_Y.Name = "INDEX_Y";
            this.INDEX_Y.ReadOnly = true;
            // 
            // X_CENTER
            // 
            this.X_CENTER.DataPropertyName = "X_CENTER";
            this.X_CENTER.HeaderText = "X_CENTER";
            this.X_CENTER.Name = "X_CENTER";
            this.X_CENTER.ReadOnly = true;
            // 
            // Y_CENTER
            // 
            this.Y_CENTER.DataPropertyName = "Y_CENTER";
            this.Y_CENTER.HeaderText = "Y_CENTER";
            this.Y_CENTER.Name = "Y_CENTER";
            this.Y_CENTER.ReadOnly = true;
            // 
            // REC_TIME
            // 
            this.REC_TIME.DataPropertyName = "REC_TIME";
            this.REC_TIME.HeaderText = "REC_TIME";
            this.REC_TIME.Name = "REC_TIME";
            this.REC_TIME.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TxtCode);
            this.panel1.Controls.Add(this.labMiddle2);
            this.panel1.Controls.Add(this.butSelect);
            this.panel1.Controls.Add(this.combType);
            this.panel1.Controls.Add(this.labType);
            this.panel1.Controls.Add(this.labCode);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.LabDate);
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 127);
            this.panel1.TabIndex = 21;
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtCode.Location = new System.Drawing.Point(419, 66);
            this.TxtCode.Multiline = true;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(164, 30);
            this.TxtCode.TabIndex = 27;
            // 
            // labMiddle2
            // 
            this.labMiddle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labMiddle2.BackColor = System.Drawing.Color.Silver;
            this.labMiddle2.Location = new System.Drawing.Point(-4, 105);
            this.labMiddle2.Name = "labMiddle2";
            this.labMiddle2.Size = new System.Drawing.Size(1295, 10);
            this.labMiddle2.TabIndex = 26;
            // 
            // butSelect
            // 
            this.butSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butSelect.ForeColor = System.Drawing.Color.Black;
            this.butSelect.Location = new System.Drawing.Point(1180, 45);
            this.butSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(96, 51);
            this.butSelect.TabIndex = 19;
            this.butSelect.Text = "查询";
            this.butSelect.UseVisualStyleBackColor = false;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // combType
            // 
            this.combType.DisplayMember = "ORDER_TYPE_NAME";
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(418, 18);
            this.combType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(164, 30);
            this.combType.TabIndex = 13;
            this.combType.ValueMember = "ORDER_TYPE_NAME";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(300, 22);
            this.labType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(90, 22);
            this.labType.TabIndex = 12;
            this.labType.Text = "指令类型：";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCode.Location = new System.Drawing.Point(315, 74);
            this.labCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(74, 22);
            this.labCode.TabIndex = 11;
            this.labCode.Text = "材料号：";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimeStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(107, 18);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(155, 29);
            this.dateTimeStart.TabIndex = 4;
            // 
            // LabDate
            // 
            this.LabDate.AutoSize = true;
            this.LabDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabDate.Location = new System.Drawing.Point(24, 22);
            this.LabDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabDate.Name = "LabDate";
            this.LabDate.Size = new System.Drawing.Size(90, 22);
            this.LabDate.TabIndex = 3;
            this.LabDate.Text = "生成日期：";
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
            this.PalTop.Size = new System.Drawing.Size(1276, 87);
            this.PalTop.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(572, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "XXXXXXXXXXX";
            // 
            // Form_CraneMessage02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PalTop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_CraneMessage02";
            this.Text = "Form_CraneMessage02";
            this.Load += new System.EventHandler(this.Form_CraneMessage02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PalTop.ResumeLayout(false);
            this.PalTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TREAMENT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn YMAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn YMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn INDEX_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_CENTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_CENTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn REC_TIME;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label labMiddle2;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label LabDate;
        private System.Windows.Forms.Panel PalTop;
        private System.Windows.Forms.Label label1;
    }
}