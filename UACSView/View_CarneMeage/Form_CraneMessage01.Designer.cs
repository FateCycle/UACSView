namespace UACSView.View_CarneMeage
{
    partial class Form_CraneMessage01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAYER_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_ACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_ACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z_ACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTION_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRANE_MODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REC_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.labMiddle2 = new System.Windows.Forms.Label();
            this.butSelect = new System.Windows.Forms.Button();
            this.labCode = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.LabDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PalTop.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.STOCK_NO,
            this.LAYER_NO,
            this.MAT_NO_1,
            this.MAT_NO_2,
            this.X_ACT,
            this.Y_ACT,
            this.Z_ACT,
            this.ACTION_STATUS,
            this.CRANE_MODE,
            this.REC_TIME});
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 434);
            this.dataGridView1.TabIndex = 14;
            // 
            // STOCK_NO
            // 
            this.STOCK_NO.DataPropertyName = "STOCK_NO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.STOCK_NO.DefaultCellStyle = dataGridViewCellStyle2;
            this.STOCK_NO.HeaderText = "库位号";
            this.STOCK_NO.Name = "STOCK_NO";
            this.STOCK_NO.ReadOnly = true;
            // 
            // LAYER_NO
            // 
            this.LAYER_NO.DataPropertyName = "LAYER_NO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.LAYER_NO.DefaultCellStyle = dataGridViewCellStyle3;
            this.LAYER_NO.HeaderText = "层号";
            this.LAYER_NO.Name = "LAYER_NO";
            this.LAYER_NO.ReadOnly = true;
            // 
            // MAT_NO_1
            // 
            this.MAT_NO_1.DataPropertyName = "MAT_NO_1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MAT_NO_1.DefaultCellStyle = dataGridViewCellStyle4;
            this.MAT_NO_1.HeaderText = "方坯1";
            this.MAT_NO_1.Name = "MAT_NO_1";
            this.MAT_NO_1.ReadOnly = true;
            // 
            // MAT_NO_2
            // 
            this.MAT_NO_2.DataPropertyName = "MAT_NO_2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MAT_NO_2.DefaultCellStyle = dataGridViewCellStyle5;
            this.MAT_NO_2.HeaderText = "方坯2";
            this.MAT_NO_2.Name = "MAT_NO_2";
            this.MAT_NO_2.ReadOnly = true;
            // 
            // X_ACT
            // 
            this.X_ACT.DataPropertyName = "X_ACT";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.X_ACT.DefaultCellStyle = dataGridViewCellStyle6;
            this.X_ACT.FillWeight = 60F;
            this.X_ACT.HeaderText = "X坐标";
            this.X_ACT.Name = "X_ACT";
            this.X_ACT.ReadOnly = true;
            // 
            // Y_ACT
            // 
            this.Y_ACT.DataPropertyName = "Y_ACT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Y_ACT.DefaultCellStyle = dataGridViewCellStyle7;
            this.Y_ACT.FillWeight = 60F;
            this.Y_ACT.HeaderText = "Y坐标";
            this.Y_ACT.Name = "Y_ACT";
            this.Y_ACT.ReadOnly = true;
            // 
            // Z_ACT
            // 
            this.Z_ACT.DataPropertyName = "Z_ACT";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Z_ACT.DefaultCellStyle = dataGridViewCellStyle8;
            this.Z_ACT.FillWeight = 60F;
            this.Z_ACT.HeaderText = "Z坐标";
            this.Z_ACT.Name = "Z_ACT";
            this.Z_ACT.ReadOnly = true;
            // 
            // ACTION_STATUS
            // 
            this.ACTION_STATUS.DataPropertyName = "ACTION_STATUS";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.ACTION_STATUS.DefaultCellStyle = dataGridViewCellStyle9;
            this.ACTION_STATUS.HeaderText = "行车动作";
            this.ACTION_STATUS.Name = "ACTION_STATUS";
            this.ACTION_STATUS.ReadOnly = true;
            // 
            // CRANE_MODE
            // 
            this.CRANE_MODE.DataPropertyName = "CRANE_MODE";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.CRANE_MODE.DefaultCellStyle = dataGridViewCellStyle10;
            this.CRANE_MODE.HeaderText = "作业模式";
            this.CRANE_MODE.Name = "CRANE_MODE";
            this.CRANE_MODE.ReadOnly = true;
            // 
            // REC_TIME
            // 
            this.REC_TIME.DataPropertyName = "REC_TIME";
            dataGridViewCellStyle11.Format = "F";
            dataGridViewCellStyle11.NullValue = null;
            this.REC_TIME.DefaultCellStyle = dataGridViewCellStyle11;
            this.REC_TIME.FillWeight = 120F;
            this.REC_TIME.HeaderText = "时间";
            this.REC_TIME.Name = "REC_TIME";
            this.REC_TIME.ReadOnly = true;
            // 
            // PalTop
            // 
            this.PalTop.BackColor = System.Drawing.Color.Silver;
            this.PalTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PalTop.Controls.Add(this.label3);
            this.PalTop.Controls.Add(this.label1);
            this.PalTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PalTop.Location = new System.Drawing.Point(0, 0);
            this.PalTop.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PalTop.Name = "PalTop";
            this.PalTop.Size = new System.Drawing.Size(1276, 87);
            this.PalTop.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(574, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "行 车 吊 运 跟 踪";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(572, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "吊 运 跟 踪";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.TxtCode);
            this.panel1.Controls.Add(this.labMiddle2);
            this.panel1.Controls.Add(this.butSelect);
            this.panel1.Controls.Add(this.labCode);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.LabDate);
            this.panel1.Location = new System.Drawing.Point(-4, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 143);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(328, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "~~";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(385, 18);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(210, 29);
            this.dateTimeEnd.TabIndex = 28;
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtCode.Location = new System.Drawing.Point(107, 68);
            this.TxtCode.Multiline = true;
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(212, 30);
            this.TxtCode.TabIndex = 27;
            // 
            // labMiddle2
            // 
            this.labMiddle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labMiddle2.BackColor = System.Drawing.Color.Silver;
            this.labMiddle2.Location = new System.Drawing.Point(-4, 119);
            this.labMiddle2.Name = "labMiddle2";
            this.labMiddle2.Size = new System.Drawing.Size(1289, 10);
            this.labMiddle2.TabIndex = 26;
            // 
            // butSelect
            // 
            this.butSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butSelect.ForeColor = System.Drawing.Color.Black;
            this.butSelect.Location = new System.Drawing.Point(1170, 50);
            this.butSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(96, 51);
            this.butSelect.TabIndex = 19;
            this.butSelect.Text = "查询";
            this.butSelect.UseVisualStyleBackColor = false;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCode.Location = new System.Drawing.Point(8, 73);
            this.labCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(74, 22);
            this.labCode.TabIndex = 11;
            this.labCode.Text = "方坯号：";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(107, 18);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(212, 29);
            this.dateTimeStart.TabIndex = 4;
            // 
            // LabDate
            // 
            this.LabDate.AutoSize = true;
            this.LabDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabDate.Location = new System.Drawing.Point(24, 22);
            this.LabDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabDate.Name = "LabDate";
            this.LabDate.Size = new System.Drawing.Size(58, 22);
            this.LabDate.TabIndex = 3;
            this.LabDate.Text = "时间：";
            // 
            // Form_CraneMessage01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PalTop);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_CraneMessage01";
            this.Text = "Form_CraneJobFollow";
            this.Load += new System.EventHandler(this.Form_CraneMessage01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PalTop.ResumeLayout(false);
            this.PalTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PalTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label labMiddle2;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label LabDate;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAYER_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_ACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_ACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z_ACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACTION_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRANE_MODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn REC_TIME;
    }
}