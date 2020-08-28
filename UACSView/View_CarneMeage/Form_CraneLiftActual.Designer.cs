namespace UACSView.View_CarneMeage
{
    partial class Form_CraneLiftActual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRANE_GROUP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FROM_STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TO_STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FROM_LAYER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REC_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CRANE_NO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labMiddle2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.butImport = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.ButSelect = new System.Windows.Forms.Button();
            this.combType = new System.Windows.Forms.ComboBox();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.labType = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.LabModule = new System.Windows.Forms.Label();
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
            this.ID,
            this.CRANE_GROUP_NO,
            this.MAT_NO_1,
            this.MAT_NO_2,
            this.FROM_STOCK_NO,
            this.TO_STOCK_NO,
            this.FLAG,
            this.ORDER_TYPE,
            this.FROM_LAYER,
            this.X,
            this.Y,
            this.Z,
            this.REC_TIME});
            this.dataGridView1.Location = new System.Drawing.Point(0, 226);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 419);
            this.dataGridView1.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // CRANE_GROUP_NO
            // 
            this.CRANE_GROUP_NO.DataPropertyName = "CRANE_GROUP_NO";
            this.CRANE_GROUP_NO.HeaderText = "指令号";
            this.CRANE_GROUP_NO.Name = "CRANE_GROUP_NO";
            // 
            // MAT_NO_1
            // 
            this.MAT_NO_1.DataPropertyName = "MAT_NO_1";
            this.MAT_NO_1.HeaderText = "方坯1";
            this.MAT_NO_1.Name = "MAT_NO_1";
            // 
            // MAT_NO_2
            // 
            this.MAT_NO_2.DataPropertyName = "MAT_NO_2";
            this.MAT_NO_2.HeaderText = "方坯2";
            this.MAT_NO_2.Name = "MAT_NO_2";
            // 
            // FROM_STOCK_NO
            // 
            this.FROM_STOCK_NO.DataPropertyName = "FROM_STOCK_NO";
            this.FROM_STOCK_NO.HeaderText = "起吊库位";
            this.FROM_STOCK_NO.Name = "FROM_STOCK_NO";
            // 
            // TO_STOCK_NO
            // 
            this.TO_STOCK_NO.DataPropertyName = "TO_STOCK_NO";
            this.TO_STOCK_NO.HeaderText = "卸下库位";
            this.TO_STOCK_NO.Name = "TO_STOCK_NO";
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "作业状态";
            this.FLAG.Name = "FLAG";
            // 
            // ORDER_TYPE
            // 
            this.ORDER_TYPE.DataPropertyName = "ORDER_TYPE";
            this.ORDER_TYPE.HeaderText = "指令类型";
            this.ORDER_TYPE.Name = "ORDER_TYPE";
            // 
            // FROM_LAYER
            // 
            this.FROM_LAYER.DataPropertyName = "FROM_LAYER";
            this.FROM_LAYER.FillWeight = 60F;
            this.FROM_LAYER.HeaderText = "层号";
            this.FROM_LAYER.Name = "FROM_LAYER";
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.X.DefaultCellStyle = dataGridViewCellStyle2;
            this.X.FillWeight = 60F;
            this.X.HeaderText = "X坐标";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.DataPropertyName = "Y";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Y.DefaultCellStyle = dataGridViewCellStyle3;
            this.Y.FillWeight = 60F;
            this.Y.HeaderText = "Y坐标";
            this.Y.Name = "Y";
            // 
            // Z
            // 
            this.Z.DataPropertyName = "Z";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Z.DefaultCellStyle = dataGridViewCellStyle4;
            this.Z.FillWeight = 60F;
            this.Z.HeaderText = "Z坐标";
            this.Z.Name = "Z";
            // 
            // REC_TIME
            // 
            this.REC_TIME.DataPropertyName = "REC_TIME";
            dataGridViewCellStyle5.Format = "F";
            dataGridViewCellStyle5.NullValue = null;
            this.REC_TIME.DefaultCellStyle = dataGridViewCellStyle5;
            this.REC_TIME.FillWeight = 120F;
            this.REC_TIME.HeaderText = "操作时间";
            this.REC_TIME.Name = "REC_TIME";
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
            this.PalTop.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(572, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "行 车 吊 运 实 绩";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.CRANE_NO);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labMiddle2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.butImport);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.ButSelect);
            this.panel1.Controls.Add(this.combType);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.labType);
            this.panel1.Controls.Add(this.labCode);
            this.panel1.Controls.Add(this.LabModule);
            this.panel1.Location = new System.Drawing.Point(-9, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 145);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CRANE_NO
            // 
            this.CRANE_NO.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CRANE_NO.Location = new System.Drawing.Point(627, 76);
            this.CRANE_NO.Multiline = true;
            this.CRANE_NO.Name = "CRANE_NO";
            this.CRANE_NO.Size = new System.Drawing.Size(180, 30);
            this.CRANE_NO.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(557, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "指令号：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labMiddle2
            // 
            this.labMiddle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labMiddle2.BackColor = System.Drawing.Color.Silver;
            this.labMiddle2.Location = new System.Drawing.Point(-1, 124);
            this.labMiddle2.Name = "labMiddle2";
            this.labMiddle2.Size = new System.Drawing.Size(1295, 10);
            this.labMiddle2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(341, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "~~";
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(393, 26);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(217, 29);
            this.dateEnd.TabIndex = 22;
            // 
            // butImport
            // 
            this.butImport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butImport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butImport.ForeColor = System.Drawing.Color.Black;
            this.butImport.Location = new System.Drawing.Point(1031, 53);
            this.butImport.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butImport.Name = "butImport";
            this.butImport.Size = new System.Drawing.Size(96, 51);
            this.butImport.TabIndex = 21;
            this.butImport.Text = "导出";
            this.butImport.UseVisualStyleBackColor = false;
            this.butImport.Click += new System.EventHandler(this.butImport_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Location = new System.Drawing.Point(371, 78);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(180, 30);
            this.txtCode.TabIndex = 16;
            // 
            // ButSelect
            // 
            this.ButSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButSelect.ForeColor = System.Drawing.Color.Black;
            this.ButSelect.Location = new System.Drawing.Point(1154, 53);
            this.ButSelect.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButSelect.Name = "ButSelect";
            this.ButSelect.Size = new System.Drawing.Size(96, 51);
            this.ButSelect.TabIndex = 11;
            this.ButSelect.Text = "查询";
            this.ButSelect.UseVisualStyleBackColor = false;
            this.ButSelect.Click += new System.EventHandler(this.ButSelect_Click);
            // 
            // combType
            // 
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(107, 78);
            this.combType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(180, 30);
            this.combType.TabIndex = 9;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(107, 76);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(0, 29);
            this.dateTimeEnd.TabIndex = 8;
            this.dateTimeEnd.Visible = false;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimeStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(107, 26);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(216, 29);
            this.dateTimeStart.TabIndex = 7;
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(17, 84);
            this.labType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(90, 22);
            this.labType.TabIndex = 6;
            this.labType.Text = "指令类型：";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCode.Location = new System.Drawing.Point(301, 84);
            this.labCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(74, 22);
            this.labCode.TabIndex = 5;
            this.labCode.Text = "方坯号：";
            // 
            // LabModule
            // 
            this.LabModule.AutoSize = true;
            this.LabModule.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabModule.Location = new System.Drawing.Point(15, 29);
            this.LabModule.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabModule.Name = "LabModule";
            this.LabModule.Size = new System.Drawing.Size(90, 22);
            this.LabModule.TabIndex = 4;
            this.LabModule.Text = "操作日期：";
            // 
            // Form_CraneLiftActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PalTop);
            this.Name = "Form_CraneLiftActual";
            this.Text = "行车吊运实绩";
            this.Load += new System.EventHandler(this.Form_CraneLiftActual_Load);
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
        private System.Windows.Forms.Button butImport;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button ButSelect;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label LabModule;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labMiddle2;
        private System.Windows.Forms.TextBox CRANE_NO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRANE_GROUP_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FROM_STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TO_STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FROM_LAYER;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn REC_TIME;
    }
}