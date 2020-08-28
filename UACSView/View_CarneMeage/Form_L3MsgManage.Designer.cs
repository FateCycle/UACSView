namespace UACSView.View_CarneMeage
{
    partial class Form_L3MsgManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CRANE_GROUP_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TO_STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FROM_STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FROM_LAYER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REC_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CRANE_NO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labMiddle2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.butWeek = new System.Windows.Forms.Button();
            this.butMonth = new System.Windows.Forms.Button();
            this.butQuarter = new System.Windows.Forms.Button();
            this.butYear = new System.Windows.Forms.Button();
            this.dateTimeStart1 = new System.Windows.Forms.DateTimePicker();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.ButSelect = new System.Windows.Forms.Button();
            this.combType = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.LabModule = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CRANE_GROUP_NO,
            this.MAT_NO_1,
            this.MAT_NO_2,
            this.ORDER_TYPE,
            this.FLAG,
            this.TO_STOCK_NO,
            this.FROM_STOCK_NO,
            this.FROM_LAYER,
            this.X,
            this.Y,
            this.Z,
            this.REC_TIME});
            this.dataGridView1.Location = new System.Drawing.Point(0, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 441);
            this.dataGridView1.TabIndex = 15;
            // 
            // CRANE_GROUP_NO
            // 
            this.CRANE_GROUP_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CRANE_GROUP_NO.DataPropertyName = "CRANE_GROUP_NO";
            this.CRANE_GROUP_NO.HeaderText = "指令号";
            this.CRANE_GROUP_NO.Name = "CRANE_GROUP_NO";
            this.CRANE_GROUP_NO.ReadOnly = true;
            this.CRANE_GROUP_NO.Width = 116;
            // 
            // MAT_NO_1
            // 
            this.MAT_NO_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MAT_NO_1.DataPropertyName = "MAT_NO_1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MAT_NO_1.DefaultCellStyle = dataGridViewCellStyle2;
            this.MAT_NO_1.HeaderText = "方坯号1";
            this.MAT_NO_1.Name = "MAT_NO_1";
            this.MAT_NO_1.ReadOnly = true;
            this.MAT_NO_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MAT_NO_1.Width = 115;
            // 
            // MAT_NO_2
            // 
            this.MAT_NO_2.DataPropertyName = "MAT_NO_2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MAT_NO_2.DefaultCellStyle = dataGridViewCellStyle3;
            this.MAT_NO_2.HeaderText = "方坯号2";
            this.MAT_NO_2.Name = "MAT_NO_2";
            this.MAT_NO_2.ReadOnly = true;
            // 
            // ORDER_TYPE
            // 
            this.ORDER_TYPE.DataPropertyName = "ORDER_TYPE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ORDER_TYPE.DefaultCellStyle = dataGridViewCellStyle4;
            this.ORDER_TYPE.HeaderText = "指令类型";
            this.ORDER_TYPE.Name = "ORDER_TYPE";
            this.ORDER_TYPE.ReadOnly = true;
            // 
            // FLAG
            // 
            this.FLAG.DataPropertyName = "FLAG";
            this.FLAG.HeaderText = "作业状态";
            this.FLAG.Name = "FLAG";
            this.FLAG.ReadOnly = true;
            // 
            // TO_STOCK_NO
            // 
            this.TO_STOCK_NO.DataPropertyName = "TO_STOCK_NO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.TO_STOCK_NO.DefaultCellStyle = dataGridViewCellStyle5;
            this.TO_STOCK_NO.HeaderText = "卸下库位";
            this.TO_STOCK_NO.Name = "TO_STOCK_NO";
            this.TO_STOCK_NO.ReadOnly = true;
            // 
            // FROM_STOCK_NO
            // 
            this.FROM_STOCK_NO.DataPropertyName = "FROM_STOCK_NO";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.Format = "yyyy-MM-dd";
            this.FROM_STOCK_NO.DefaultCellStyle = dataGridViewCellStyle6;
            this.FROM_STOCK_NO.HeaderText = "吊起库位";
            this.FROM_STOCK_NO.Name = "FROM_STOCK_NO";
            this.FROM_STOCK_NO.ReadOnly = true;
            // 
            // FROM_LAYER
            // 
            this.FROM_LAYER.DataPropertyName = "FROM_LAYER";
            this.FROM_LAYER.FillWeight = 60F;
            this.FROM_LAYER.HeaderText = "层号";
            this.FROM_LAYER.Name = "FROM_LAYER";
            this.FROM_LAYER.ReadOnly = true;
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.X.DefaultCellStyle = dataGridViewCellStyle7;
            this.X.FillWeight = 60F;
            this.X.HeaderText = "X坐标";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.DataPropertyName = "Y";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Y.DefaultCellStyle = dataGridViewCellStyle8;
            this.Y.FillWeight = 60F;
            this.Y.HeaderText = "Y坐标";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // Z
            // 
            this.Z.DataPropertyName = "Z";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Z.DefaultCellStyle = dataGridViewCellStyle9;
            this.Z.FillWeight = 60F;
            this.Z.HeaderText = "Z坐标";
            this.Z.Name = "Z";
            this.Z.ReadOnly = true;
            // 
            // REC_TIME
            // 
            this.REC_TIME.DataPropertyName = "REC_TIME";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.Format = "F";
            dataGridViewCellStyle10.NullValue = null;
            this.REC_TIME.DefaultCellStyle = dataGridViewCellStyle10;
            this.REC_TIME.FillWeight = 120F;
            this.REC_TIME.HeaderText = "操作时间";
            this.REC_TIME.Name = "REC_TIME";
            this.REC_TIME.ReadOnly = true;
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
            this.PalTop.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(572, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "L3 电 文 查 询";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CRANE_NO);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labMiddle2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.butWeek);
            this.panel1.Controls.Add(this.butMonth);
            this.panel1.Controls.Add(this.butQuarter);
            this.panel1.Controls.Add(this.butYear);
            this.panel1.Controls.Add(this.dateTimeStart1);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.ButSelect);
            this.panel1.Controls.Add(this.combType);
            this.panel1.Controls.Add(this.labType);
            this.panel1.Controls.Add(this.labCode);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.LabModule);
            this.panel1.Location = new System.Drawing.Point(-7, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 129);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CRANE_NO
            // 
            this.CRANE_NO.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CRANE_NO.Location = new System.Drawing.Point(712, 25);
            this.CRANE_NO.Name = "CRANE_NO";
            this.CRANE_NO.Size = new System.Drawing.Size(166, 29);
            this.CRANE_NO.TabIndex = 30;
            this.CRANE_NO.TextChanged += new System.EventHandler(this.CRANE_NO_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(640, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "指令号：";
            // 
            // labMiddle2
            // 
            this.labMiddle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labMiddle2.BackColor = System.Drawing.Color.Silver;
            this.labMiddle2.Location = new System.Drawing.Point(-2, 104);
            this.labMiddle2.Name = "labMiddle2";
            this.labMiddle2.Size = new System.Drawing.Size(1295, 10);
            this.labMiddle2.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(115, 68);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 29);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 29);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // butWeek
            // 
            this.butWeek.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butWeek.ForeColor = System.Drawing.Color.Black;
            this.butWeek.Location = new System.Drawing.Point(354, 119);
            this.butWeek.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butWeek.Name = "butWeek";
            this.butWeek.Size = new System.Drawing.Size(96, 51);
            this.butWeek.TabIndex = 23;
            this.butWeek.Text = "周数";
            this.butWeek.UseVisualStyleBackColor = false;
            this.butWeek.Visible = false;
            this.butWeek.Click += new System.EventHandler(this.butWeek_Click);
            // 
            // butMonth
            // 
            this.butMonth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butMonth.ForeColor = System.Drawing.Color.Black;
            this.butMonth.Location = new System.Drawing.Point(243, 119);
            this.butMonth.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butMonth.Name = "butMonth";
            this.butMonth.Size = new System.Drawing.Size(96, 51);
            this.butMonth.TabIndex = 22;
            this.butMonth.Text = "月度";
            this.butMonth.UseVisualStyleBackColor = false;
            this.butMonth.Visible = false;
            this.butMonth.Click += new System.EventHandler(this.butMonth_Click);
            // 
            // butQuarter
            // 
            this.butQuarter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butQuarter.ForeColor = System.Drawing.Color.Black;
            this.butQuarter.Location = new System.Drawing.Point(133, 119);
            this.butQuarter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butQuarter.Name = "butQuarter";
            this.butQuarter.Size = new System.Drawing.Size(96, 51);
            this.butQuarter.TabIndex = 21;
            this.butQuarter.Text = "季度";
            this.butQuarter.UseVisualStyleBackColor = false;
            this.butQuarter.Visible = false;
            this.butQuarter.Click += new System.EventHandler(this.butQuarter_Click);
            // 
            // butYear
            // 
            this.butYear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butYear.ForeColor = System.Drawing.Color.Black;
            this.butYear.Location = new System.Drawing.Point(27, 119);
            this.butYear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butYear.Name = "butYear";
            this.butYear.Size = new System.Drawing.Size(96, 51);
            this.butYear.TabIndex = 20;
            this.butYear.Text = "年度";
            this.butYear.UseVisualStyleBackColor = false;
            this.butYear.Visible = false;
            this.butYear.Click += new System.EventHandler(this.butYear_Click);
            // 
            // dateTimeStart1
            // 
            this.dateTimeStart1.CustomFormat = "HH:mm:ss";
            this.dateTimeStart1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeStart1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart1.Location = new System.Drawing.Point(239, 68);
            this.dateTimeStart1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart1.Name = "dateTimeStart1";
            this.dateTimeStart1.ShowUpDown = true;
            this.dateTimeStart1.Size = new System.Drawing.Size(97, 29);
            this.dateTimeStart1.TabIndex = 19;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Location = new System.Drawing.Point(446, 25);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(166, 29);
            this.txtCode.TabIndex = 17;
            // 
            // ButSelect
            // 
            this.ButSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButSelect.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButSelect.ForeColor = System.Drawing.Color.Black;
            this.ButSelect.Location = new System.Drawing.Point(1147, 46);
            this.ButSelect.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButSelect.Name = "ButSelect";
            this.ButSelect.Size = new System.Drawing.Size(96, 51);
            this.ButSelect.TabIndex = 16;
            this.ButSelect.Text = "查询";
            this.ButSelect.UseVisualStyleBackColor = false;
            this.ButSelect.Click += new System.EventHandler(this.ButSelect_Click);
            // 
            // combType
            // 
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(446, 67);
            this.combType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(166, 30);
            this.combType.TabIndex = 14;
            this.combType.SelectedIndexChanged += new System.EventHandler(this.combType_SelectedIndexChanged);
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(360, 75);
            this.labType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(90, 22);
            this.labType.TabIndex = 13;
            this.labType.Text = "指令类型：";
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCode.Location = new System.Drawing.Point(376, 32);
            this.labCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(74, 22);
            this.labCode.TabIndex = 12;
            this.labCode.Text = "方坯号：";
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "HH:mm:ss";
            this.dateTimeStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(239, 25);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.ShowUpDown = true;
            this.dateTimeStart.Size = new System.Drawing.Size(97, 29);
            this.dateTimeStart.TabIndex = 10;
            this.dateTimeStart.ValueChanged += new System.EventHandler(this.dateTimeStart_ValueChanged);
            // 
            // LabModule
            // 
            this.LabModule.AutoSize = true;
            this.LabModule.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabModule.Location = new System.Drawing.Point(23, 30);
            this.LabModule.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabModule.Name = "LabModule";
            this.LabModule.Size = new System.Drawing.Size(90, 22);
            this.LabModule.TabIndex = 9;
            this.LabModule.Text = "操作时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_L3MsgManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PalTop);
            this.Name = "Form_L3MsgManage";
            this.Text = "L3电文查询";
            this.Load += new System.EventHandler(this.Form_L3MsgManage_Load);
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
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button ButSelect;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label LabModule;
        private System.Windows.Forms.DateTimePicker dateTimeStart1;
        private System.Windows.Forms.Button butWeek;
        private System.Windows.Forms.Button butMonth;
        private System.Windows.Forms.Button butQuarter;
        private System.Windows.Forms.Button butYear;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRANE_GROUP_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TO_STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FROM_STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FROM_LAYER;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn REC_TIME;
        private System.Windows.Forms.Label labMiddle2;
        private System.Windows.Forms.TextBox CRANE_NO;
        private System.Windows.Forms.Label label2;
    }
}