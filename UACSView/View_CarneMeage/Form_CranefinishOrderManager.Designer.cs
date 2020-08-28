namespace UACSView.View_CarneMeage
{
    partial class Form_CranefinishOrderManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_BATCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRANE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_TYPE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LENGTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WIDTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THICK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FROM_STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TO_STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finish_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labComptDate = new System.Windows.Forms.Label();
            this.butImport = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.combType = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.LabDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PalTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODE,
            this.ORDER_BATCH,
            this.CRANE_NO,
            this.ORDER_TYPE_NAME,
            this.MAT_NO,
            this.LENGTH,
            this.WIDTH,
            this.THICK,
            this.WEIGHT,
            this.FROM_STOCK_NO,
            this.TO_STOCK_NO,
            this.Start_time,
            this.Finish_Time});
            this.dataGridView1.Location = new System.Drawing.Point(-6, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1282, 417);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CODE
            // 
            this.CODE.HeaderText = "序号";
            this.CODE.Name = "CODE";
            this.CODE.Visible = false;
            // 
            // ORDER_BATCH
            // 
            this.ORDER_BATCH.DataPropertyName = "ORDER_BATCH";
            this.ORDER_BATCH.HeaderText = "批次号";
            this.ORDER_BATCH.Name = "ORDER_BATCH";
            this.ORDER_BATCH.Visible = false;
            // 
            // CRANE_NO
            // 
            this.CRANE_NO.DataPropertyName = "CRANE_NO";
            this.CRANE_NO.HeaderText = "行车号";
            this.CRANE_NO.Name = "CRANE_NO";
            // 
            // ORDER_TYPE_NAME
            // 
            this.ORDER_TYPE_NAME.DataPropertyName = "ORDER_TYPE_NAME";
            this.ORDER_TYPE_NAME.HeaderText = "指令类型";
            this.ORDER_TYPE_NAME.Name = "ORDER_TYPE_NAME";
            // 
            // MAT_NO
            // 
            this.MAT_NO.DataPropertyName = "MAT_NO";
            this.MAT_NO.HeaderText = "材料号";
            this.MAT_NO.Name = "MAT_NO";
            // 
            // LENGTH
            // 
            this.LENGTH.DataPropertyName = "LENGTH";
            this.LENGTH.HeaderText = "长度";
            this.LENGTH.Name = "LENGTH";
            // 
            // WIDTH
            // 
            this.WIDTH.DataPropertyName = "WIDTH";
            this.WIDTH.HeaderText = "宽度";
            this.WIDTH.Name = "WIDTH";
            // 
            // THICK
            // 
            this.THICK.DataPropertyName = "THICK";
            this.THICK.HeaderText = "厚度";
            this.THICK.Name = "THICK";
            // 
            // WEIGHT
            // 
            this.WEIGHT.DataPropertyName = "WEIGHT";
            this.WEIGHT.HeaderText = "重量";
            this.WEIGHT.Name = "WEIGHT";
            // 
            // FROM_STOCK_NO
            // 
            this.FROM_STOCK_NO.DataPropertyName = "FROM_STOCK_NO";
            this.FROM_STOCK_NO.HeaderText = "起吊位";
            this.FROM_STOCK_NO.Name = "FROM_STOCK_NO";
            // 
            // TO_STOCK_NO
            // 
            this.TO_STOCK_NO.DataPropertyName = "TO_STOCK_NO";
            this.TO_STOCK_NO.HeaderText = "卸下位";
            this.TO_STOCK_NO.Name = "TO_STOCK_NO";
            // 
            // Start_time
            // 
            this.Start_time.DataPropertyName = "Start_time";
            dataGridViewCellStyle8.Format = "yyyy-MM-dd";
            this.Start_time.DefaultCellStyle = dataGridViewCellStyle8;
            this.Start_time.HeaderText = "生成日期";
            this.Start_time.Name = "Start_time";
            // 
            // Finish_Time
            // 
            this.Finish_Time.DataPropertyName = "Finish_Time";
            dataGridViewCellStyle9.Format = "yyyy-MM-dd";
            this.Finish_Time.DefaultCellStyle = dataGridViewCellStyle9;
            this.Finish_Time.HeaderText = "完成日期";
            this.Finish_Time.Name = "Finish_Time";
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
            this.PalTop.Size = new System.Drawing.Size(1276, 88);
            this.PalTop.TabIndex = 11;
            this.PalTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PalTop_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(572, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "行车完成指令管理";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.labComptDate);
            this.panel1.Controls.Add(this.butImport);
            this.panel1.Controls.Add(this.butSelect);
            this.panel1.Controls.Add(this.combType);
            this.panel1.Controls.Add(this.labType);
            this.panel1.Controls.Add(this.labCode);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.LabDate);
            this.panel1.Location = new System.Drawing.Point(-3, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 122);
            this.panel1.TabIndex = 14;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Location = new System.Drawing.Point(433, 71);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(164, 30);
            this.txtCode.TabIndex = 22;
            // 
            // labComptDate
            // 
            this.labComptDate.AutoSize = true;
            this.labComptDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labComptDate.Location = new System.Drawing.Point(16, 77);
            this.labComptDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labComptDate.Name = "labComptDate";
            this.labComptDate.Size = new System.Drawing.Size(90, 22);
            this.labComptDate.TabIndex = 21;
            this.labComptDate.Text = "生成日期：";
            // 
            // butImport
            // 
            this.butImport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butImport.ForeColor = System.Drawing.Color.Black;
            this.butImport.Location = new System.Drawing.Point(973, 48);
            this.butImport.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butImport.Name = "butImport";
            this.butImport.Size = new System.Drawing.Size(96, 51);
            this.butImport.TabIndex = 20;
            this.butImport.Text = "导出";
            this.butImport.UseVisualStyleBackColor = false;
            this.butImport.Click += new System.EventHandler(this.butImport_Click);
            // 
            // butSelect
            // 
            this.butSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butSelect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butSelect.ForeColor = System.Drawing.Color.Black;
            this.butSelect.Location = new System.Drawing.Point(1140, 46);
            this.butSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(95, 53);
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
            this.combType.Location = new System.Drawing.Point(431, 24);
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
            this.labType.Location = new System.Drawing.Point(330, 29);
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
            this.labCode.Location = new System.Drawing.Point(345, 79);
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
            this.dateTimeStart.Location = new System.Drawing.Point(106, 74);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(155, 29);
            this.dateTimeStart.TabIndex = 5;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(107, 22);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(155, 29);
            this.dateTimeEnd.TabIndex = 4;
            // 
            // LabDate
            // 
            this.LabDate.AutoSize = true;
            this.LabDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabDate.Location = new System.Drawing.Point(17, 25);
            this.LabDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabDate.Name = "LabDate";
            this.LabDate.Size = new System.Drawing.Size(90, 22);
            this.LabDate.TabIndex = 3;
            this.LabDate.Text = "完成日期：";
            // 
            // Form_CranefinishOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PalTop);
            this.Name = "Form_CranefinishOrderManager";
            this.Text = "行车完成指令管理";
            this.Load += new System.EventHandler(this.Form_CranefinishOrderManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PalTop.ResumeLayout(false);
            this.PalTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_BATCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRANE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_TYPE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LENGTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn WIDTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn THICK;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FROM_STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TO_STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finish_Time;
        private System.Windows.Forms.Panel PalTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labComptDate;
        private System.Windows.Forms.Button butImport;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label LabDate;
    }
}