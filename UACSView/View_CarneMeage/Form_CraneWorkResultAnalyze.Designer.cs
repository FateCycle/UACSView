namespace UACSView.View_CarneMeage
{
    partial class Form_CraneWorkResultAnalyze
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CraneWorkResultAnalyze));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flexCraneWorkResult = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.cmbWorkType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCrane = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMouth = new System.Windows.Forms.Button();
            this.btnSeason = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.coillab = new System.Windows.Forms.Label();
            this.txtCoilNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.containerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpOperate = new L2Tools.Lib.CustomControls.RoundedRectangularGroupBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flexCraneWorkResult)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.containerTableLayoutPanel.SuspendLayout();
            this.grpOperate.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flexCraneWorkResult
            // 
            this.flexCraneWorkResult.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.flexCraneWorkResult.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.flexCraneWorkResult.ColumnInfo = "10,1,0,0,0,150,Columns:";
            this.flexCraneWorkResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexCraneWorkResult.ExtendLastCol = true;
            this.flexCraneWorkResult.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flexCraneWorkResult.Location = new System.Drawing.Point(0, 0);
            this.flexCraneWorkResult.Name = "flexCraneWorkResult";
            this.flexCraneWorkResult.Rows.Count = 4;
            this.flexCraneWorkResult.Rows.DefaultSize = 30;
            this.flexCraneWorkResult.Size = new System.Drawing.Size(1882, 682);
            this.flexCraneWorkResult.StyleInfo = resources.GetString("flexCraneWorkResult.StyleInfo");
            this.flexCraneWorkResult.TabIndex = 25;
            // 
            // cmbWorkType
            // 
            this.cmbWorkType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbWorkType.FormattingEnabled = true;
            this.cmbWorkType.Items.AddRange(new object[] {
            "全部",
            "车辆入库",
            "车辆出库",
            "机组上料",
            "倒库"});
            this.cmbWorkType.Location = new System.Drawing.Point(763, 65);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(195, 34);
            this.cmbWorkType.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(650, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "作业类型：";
            // 
            // cmbCrane
            // 
            this.cmbCrane.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCrane.FormattingEnabled = true;
            this.cmbCrane.Items.AddRange(new object[] {
            "全部",
            "1-1",
            "1-2",
            "1-3"});
            this.cmbCrane.Location = new System.Drawing.Point(763, 19);
            this.cmbCrane.Name = "cmbCrane";
            this.cmbCrane.Size = new System.Drawing.Size(195, 34);
            this.cmbCrane.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(650, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "行  车  号：";
            // 
            // btnMouth
            // 
            this.btnMouth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnMouth.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMouth.ForeColor = System.Drawing.Color.White;
            this.btnMouth.Location = new System.Drawing.Point(458, 58);
            this.btnMouth.Name = "btnMouth";
            this.btnMouth.Size = new System.Drawing.Size(90, 40);
            this.btnMouth.TabIndex = 29;
            this.btnMouth.Text = "月度";
            this.btnMouth.UseVisualStyleBackColor = false;
            // 
            // btnSeason
            // 
            this.btnSeason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnSeason.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSeason.ForeColor = System.Drawing.Color.White;
            this.btnSeason.Location = new System.Drawing.Point(255, 59);
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.Size = new System.Drawing.Size(90, 40);
            this.btnSeason.TabIndex = 28;
            this.btnSeason.Text = "季度";
            this.btnSeason.UseVisualStyleBackColor = false;
            // 
            // btnYear
            // 
            this.btnYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnYear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(51, 59);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(90, 40);
            this.btnYear.TabIndex = 27;
            this.btnYear.Text = "年度";
            this.btnYear.UseVisualStyleBackColor = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(330, 16);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(241, 33);
            this.dtpEnd.TabIndex = 26;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(72, 15);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(240, 33);
            this.dtpStart.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "日期：";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.311225F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.68877F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1888, 758);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flexCraneWorkResult);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(3, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1882, 682);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1882, 64);
            this.panel2.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(706, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 22);
            this.label12.TabIndex = 7;
            this.label12.Text = "自动化率：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(802, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 6;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(558, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(462, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "手动模式：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(338, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(242, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "自动模式：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(139, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(43, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "全部模式：";
            // 
            // coillab
            // 
            this.coillab.AutoSize = true;
            this.coillab.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coillab.Location = new System.Drawing.Point(1061, 72);
            this.coillab.Name = "coillab";
            this.coillab.Size = new System.Drawing.Size(88, 26);
            this.coillab.TabIndex = 37;
            this.coillab.Text = "材料号：";
            // 
            // txtCoilNo
            // 
            this.txtCoilNo.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCoilNo.Location = new System.Drawing.Point(1193, 68);
            this.txtCoilNo.Name = "txtCoilNo";
            this.txtCoilNo.Size = new System.Drawing.Size(167, 33);
            this.txtCoilNo.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1061, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "操作模式：";
            // 
            // cmbMode
            // 
            this.cmbMode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "全部",
            "自动",
            "手动"});
            this.cmbMode.Location = new System.Drawing.Point(1193, 20);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(167, 34);
            this.cmbMode.TabIndex = 40;
            // 
            // containerTableLayoutPanel
            // 
            this.containerTableLayoutPanel.ColumnCount = 1;
            this.containerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerTableLayoutPanel.Controls.Add(this.grpTitle, 0, 0);
            this.containerTableLayoutPanel.Controls.Add(this.grpOperate, 0, 1);
            this.containerTableLayoutPanel.Controls.Add(this.pnlContainer, 0, 2);
            this.containerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.containerTableLayoutPanel.Name = "containerTableLayoutPanel";
            this.containerTableLayoutPanel.RowCount = 3;
            this.containerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.containerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.containerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerTableLayoutPanel.Size = new System.Drawing.Size(1894, 944);
            this.containerTableLayoutPanel.TabIndex = 0;
            this.containerTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.containerTableLayoutPanel_Paint);
            // 
            // grpOperate
            // 
            this.grpOperate.BorderWidth = 0;
            this.grpOperate.ColorScheme = L2Tools.Functions.ColorSln.EnmColorScheme.BlueGray;
            this.grpOperate.Controls.Add(this.cmbMode);
            this.grpOperate.Controls.Add(this.label4);
            this.grpOperate.Controls.Add(this.txtCoilNo);
            this.grpOperate.Controls.Add(this.coillab);
            this.grpOperate.Controls.Add(this.btnExport);
            this.grpOperate.Controls.Add(this.btnQuery);
            this.grpOperate.Controls.Add(this.cmbWorkType);
            this.grpOperate.Controls.Add(this.label3);
            this.grpOperate.Controls.Add(this.cmbCrane);
            this.grpOperate.Controls.Add(this.label2);
            this.grpOperate.Controls.Add(this.btnMouth);
            this.grpOperate.Controls.Add(this.btnSeason);
            this.grpOperate.Controls.Add(this.btnYear);
            this.grpOperate.Controls.Add(this.dtpEnd);
            this.grpOperate.Controls.Add(this.dtpStart);
            this.grpOperate.Controls.Add(this.label1);
            this.grpOperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOperate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpOperate.FontColor = System.Drawing.Color.Black;
            this.grpOperate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpOperate.GroupTitleThick = 0;
            this.grpOperate.Location = new System.Drawing.Point(3, 63);
            this.grpOperate.MoGradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(221)))));
            this.grpOperate.MoGradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(233)))));
            this.grpOperate.MoInteriorBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grpOperate.MoInteriorTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grpOperate.Name = "grpOperate";
            this.grpOperate.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.grpOperate.Size = new System.Drawing.Size(1888, 114);
            this.grpOperate.TabIndex = 8;
            this.grpOperate.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.tableLayoutPanel2);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlContainer.Location = new System.Drawing.Point(3, 183);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1888, 758);
            this.pnlContainer.TabIndex = 2;
            // 
            // grpTitle
            // 
            this.grpTitle.BackgroundImage = global::UACSView.Properties.Resources.title_bg;
            this.grpTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTitle.Controls.Add(this.lblTitle);
            this.grpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTitle.Location = new System.Drawing.Point(3, 3);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(1888, 54);
            this.grpTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblTitle.Size = new System.Drawing.Size(1888, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "行车履历查询";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::UACSView.Properties.Resources.export__1_;
            this.btnExport.Location = new System.Drawing.Point(1747, 28);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 3, 200, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 50);
            this.btnExport.TabIndex = 35;
            this.btnExport.Text = " 导出";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Image = global::UACSView.Properties.Resources.search__1_;
            this.btnQuery.Location = new System.Drawing.Point(1594, 28);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 50);
            this.btnQuery.TabIndex = 34;
            this.btnQuery.Text = "查询";
            this.btnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // Form_CraneWorkResultAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 944);
            this.Controls.Add(this.containerTableLayoutPanel);
            this.Name = "Form_CraneWorkResultAnalyze";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.flexCraneWorkResult)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.containerTableLayoutPanel.ResumeLayout(false);
            this.grpOperate.ResumeLayout(false);
            this.grpOperate.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.grpTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.C1FlexGrid.C1FlexGrid flexCraneWorkResult;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbWorkType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCrane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMouth;
        private System.Windows.Forms.Button btnSeason;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label coillab;
        private System.Windows.Forms.TextBox txtCoilNo;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel grpTitle;
        public L2Tools.Lib.CustomControls.RoundedRectangularGroupBox grpOperate;
        private System.Windows.Forms.TableLayoutPanel containerTableLayoutPanel;
    }
}