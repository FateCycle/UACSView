namespace UACSView.View_CraneMonitor
{
    partial class _Form_library_Monitor
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
            this.timer_InitializeLoad = new System.Windows.Forms.Timer(this.components);
            this.timer_ShowXY = new System.Windows.Forms.Timer(this.components);
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.timerAreaAndSaddle = new System.Windows.Forms.Timer(this.components);
            this.timerArea = new System.Windows.Forms.Timer(this.components);
            this.timerCrane = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnShowXY = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowCrane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelZ53BayS = new System.Windows.Forms.Panel();
            this.panelBay = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.Label();
            this.conCrane86 = new UACSControls.conCrane();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.manualControl1 = new UACSControls.CraneMonitor.MANUALControl();
            this.panel10 = new System.Windows.Forms.Panel();
            this.LineActionStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUnitLockStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUnitLock = new System.Windows.Forms.Button();
            this.btnUnitUnLock = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvByUnitScan = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INDEX_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conCraneStatus86 = new UACSControls.conCraneStatus();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCarArrive = new System.Windows.Forms.Button();
            this.btnLaserScan = new System.Windows.Forms.Button();
            this.btnCarLeave = new System.Windows.Forms.Button();
            this.parkingStatusControl1 = new UACSControls.CraneMonitor.ParkingStausControl();
            this.dgvByParking = new System.Windows.Forms.DataGridView();
            this.PARKING_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASER_ACTION_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TREATMENT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROOVEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROOVE_ACT_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROOVE_ACT_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GROOVE_ACT_Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainParkingControl1 = new UACSControls.CraneMonitor.TrainParkingControl();
            this.userMessage1 = new UACSControls.UserMessage();
            this.timer_ParkScanInfo = new System.Windows.Forms.Timer(this.components);
            this.timer_RefreshOrder = new System.Windows.Forms.Timer(this.components);
            this.timer_RefreshUnit = new System.Windows.Forms.Timer(this.components);
            this.timer_TrainParking = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelZ53BayS.SuspendLayout();
            this.panelBay.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByUnitScan)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvByParking)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_InitializeLoad
            // 
            this.timer_InitializeLoad.Enabled = true;
            this.timer_InitializeLoad.Tick += new System.EventHandler(this.timer_InitializeLoad_Tick);
            // 
            // timer_ShowXY
            // 
            this.timer_ShowXY.Enabled = true;
            this.timer_ShowXY.Tick += new System.EventHandler(this.timer_ShowXY_Tick);
            // 
            // timerClear
            // 
            this.timerClear.Interval = 100000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // timerAreaAndSaddle
            // 
            this.timerAreaAndSaddle.Enabled = true;
            this.timerAreaAndSaddle.Interval = 8000;
            this.timerAreaAndSaddle.Tick += new System.EventHandler(this.timerUnit_Tick);
            // 
            // timerArea
            // 
            this.timerArea.Enabled = true;
            this.timerArea.Interval = 9000;
            this.timerArea.Tick += new System.EventHandler(this.timerArea_Tick);
            // 
            // timerCrane
            // 
            this.timerCrane.Enabled = true;
            this.timerCrane.Interval = 1000;
            this.timerCrane.Tick += new System.EventHandler(this.timerCrane_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 68);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnShowXY);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnShowCrane);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 68);
            this.panel2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(227, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "异常";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Red;
            this.panel9.Location = new System.Drawing.Point(198, 15);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(22, 19);
            this.panel9.TabIndex = 31;
            // 
            // btnShowXY
            // 
            this.btnShowXY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowXY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowXY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowXY.ForeColor = System.Drawing.Color.White;
            this.btnShowXY.Location = new System.Drawing.Point(1181, 27);
            this.btnShowXY.Name = "btnShowXY";
            this.btnShowXY.Size = new System.Drawing.Size(75, 23);
            this.btnShowXY.TabIndex = 28;
            this.btnShowXY.Text = "显示XY";
            this.btnShowXY.UseVisualStyleBackColor = true;
            this.btnShowXY.Click += new System.EventHandler(this.btnShowXY_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(123, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "预定不安全";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(95, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(22, 19);
            this.panel6.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(33, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "预定安全";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Location = new System.Drawing.Point(5, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 19);
            this.panel5.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1164, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "注意：自动行车不进入红色区域";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnShowCrane
            // 
            this.btnShowCrane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowCrane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowCrane.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowCrane.ForeColor = System.Drawing.Color.White;
            this.btnShowCrane.Location = new System.Drawing.Point(1262, 27);
            this.btnShowCrane.Name = "btnShowCrane";
            this.btnShowCrane.Size = new System.Drawing.Size(75, 23);
            this.btnShowCrane.TabIndex = 9;
            this.btnShowCrane.Text = "隐藏行车";
            this.btnShowCrane.UseVisualStyleBackColor = true;
            this.btnShowCrane.Click += new System.EventHandler(this.btnShowCrane_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(593, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "特轧厂库区监控";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panelZ53BayS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1364, 443);
            this.panel3.TabIndex = 4;
            // 
            // panelZ53BayS
            // 
            this.panelZ53BayS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelZ53BayS.Controls.Add(this.panelBay);
            this.panelZ53BayS.Controls.Add(this.tableLayoutPanel3);
            this.panelZ53BayS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZ53BayS.Location = new System.Drawing.Point(0, 0);
            this.panelZ53BayS.Name = "panelZ53BayS";
            this.panelZ53BayS.Size = new System.Drawing.Size(1364, 443);
            this.panelZ53BayS.TabIndex = 0;
            // 
            // panelBay
            // 
            this.panelBay.BackColor = System.Drawing.Color.PeachPuff;
            this.panelBay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBay.Controls.Add(this.panel4);
            this.panelBay.Controls.Add(this.conCrane86);
            this.panelBay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBay.Location = new System.Drawing.Point(0, 0);
            this.panelBay.Name = "panelBay";
            this.panelBay.Size = new System.Drawing.Size(1364, 443);
            this.panelBay.TabIndex = 7;
            this.panelBay.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2250Bay_Paint_2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtY);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtX);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 66);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "X:";
            // 
            // txtY
            // 
            this.txtY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtY.AutoSize = true;
            this.txtY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtY.ForeColor = System.Drawing.Color.White;
            this.txtY.Location = new System.Drawing.Point(25, 40);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 17);
            this.txtY.TabIndex = 15;
            this.txtY.Text = "999999";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Y:";
            // 
            // txtX
            // 
            this.txtX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtX.AutoSize = true;
            this.txtX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtX.ForeColor = System.Drawing.Color.White;
            this.txtX.Location = new System.Drawing.Point(25, 10);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 17);
            this.txtX.TabIndex = 14;
            this.txtX.Text = "999999";
            // 
            // conCrane86
            // 
            this.conCrane86.BackColor = System.Drawing.SystemColors.Control;
            this.conCrane86.CraneNO = null;
            this.conCrane86.Location = new System.Drawing.Point(330, 0);
            this.conCrane86.Name = "conCrane86";
            this.conCrane86.Size = new System.Drawing.Size(49, 550);
            this.conCrane86.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(74, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1352, 453);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.25184F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.74816F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.conCraneStatus86, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 526);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1364, 220);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.05295F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.94705F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(538, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(823, 214);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel8);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(471, 208);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "机组";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.2393F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.78272F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.97798F));
            this.tableLayoutPanel8.Controls.Add(this.manualControl1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel10, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnUnitLock, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.btnUnitUnLock, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.btn1, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.btn2, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.btn3, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.btn4, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.btn5, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.57841F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42544F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42544F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.8569F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.8569F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.8569F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(465, 184);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // manualControl1
            // 
            this.manualControl1.BackColor = System.Drawing.Color.SteelBlue;
            this.manualControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manualControl1.Location = new System.Drawing.Point(4, 5);
            this.manualControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manualControl1.Name = "manualControl1";
            this.tableLayoutPanel8.SetRowSpan(this.manualControl1, 6);
            this.manualControl1.Size = new System.Drawing.Size(304, 174);
            this.manualControl1.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.LineActionStatus);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.lblUnitLockStatus);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(369, 3);
            this.panel10.Name = "panel10";
            this.tableLayoutPanel8.SetRowSpan(this.panel10, 2);
            this.panel10.Size = new System.Drawing.Size(93, 60);
            this.panel10.TabIndex = 3;
            // 
            // LineActionStatus
            // 
            this.LineActionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineActionStatus.AutoSize = true;
            this.LineActionStatus.BackColor = System.Drawing.Color.Red;
            this.LineActionStatus.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LineActionStatus.ForeColor = System.Drawing.Color.White;
            this.LineActionStatus.Location = new System.Drawing.Point(51, 30);
            this.LineActionStatus.Name = "LineActionStatus";
            this.LineActionStatus.Size = new System.Drawing.Size(37, 15);
            this.LineActionStatus.TabIndex = 3;
            this.LineActionStatus.Text = "初始化";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(3, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "移动状态:";
            // 
            // lblUnitLockStatus
            // 
            this.lblUnitLockStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitLockStatus.AutoSize = true;
            this.lblUnitLockStatus.BackColor = System.Drawing.Color.Red;
            this.lblUnitLockStatus.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUnitLockStatus.ForeColor = System.Drawing.Color.White;
            this.lblUnitLockStatus.Location = new System.Drawing.Point(50, 4);
            this.lblUnitLockStatus.Name = "lblUnitLockStatus";
            this.lblUnitLockStatus.Size = new System.Drawing.Size(37, 15);
            this.lblUnitLockStatus.TabIndex = 1;
            this.lblUnitLockStatus.Text = "初始化";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(2, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "锁定状态:";
            // 
            // btnUnitLock
            // 
            this.btnUnitLock.BackColor = System.Drawing.Color.White;
            this.btnUnitLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnitLock.Location = new System.Drawing.Point(367, 67);
            this.btnUnitLock.Margin = new System.Windows.Forms.Padding(1);
            this.btnUnitLock.Name = "btnUnitLock";
            this.tableLayoutPanel8.SetRowSpan(this.btnUnitLock, 2);
            this.btnUnitLock.Size = new System.Drawing.Size(97, 57);
            this.btnUnitLock.TabIndex = 1;
            this.btnUnitLock.Text = "锁定";
            this.btnUnitLock.UseVisualStyleBackColor = false;
            this.btnUnitLock.Click += new System.EventHandler(this.btnUnitLock_Click);
            // 
            // btnUnitUnLock
            // 
            this.btnUnitUnLock.BackColor = System.Drawing.Color.White;
            this.btnUnitUnLock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnitUnLock.Location = new System.Drawing.Point(367, 126);
            this.btnUnitUnLock.Margin = new System.Windows.Forms.Padding(1);
            this.btnUnitUnLock.Name = "btnUnitUnLock";
            this.tableLayoutPanel8.SetRowSpan(this.btnUnitUnLock, 2);
            this.btnUnitUnLock.Size = new System.Drawing.Size(97, 57);
            this.btnUnitUnLock.TabIndex = 2;
            this.btnUnitUnLock.Text = "解锁";
            this.btnUnitUnLock.UseVisualStyleBackColor = false;
            this.btnUnitUnLock.Click += new System.EventHandler(this.btnUnitUnLock_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(312, 36);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 30);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "清空1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(312, 66);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 30);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "清空2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(312, 96);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 29);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "清空3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(312, 125);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 29);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "清空4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(312, 154);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 30);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "清空5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(312, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 36);
            this.label7.TabIndex = 10;
            this.label7.Text = "库位操作";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvByUnitScan);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(480, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 208);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "台架激光扫描";
            // 
            // dgvByUnitScan
            // 
            this.dgvByUnitScan.AllowUserToAddRows = false;
            this.dgvByUnitScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvByUnitScan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.INDEX_Y,
            this.X_CENTER,
            this.Y_CENTER,
            this.XMAX,
            this.XMIN,
            this.YMAX,
            this.YMIN});
            this.dgvByUnitScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvByUnitScan.Location = new System.Drawing.Point(3, 21);
            this.dgvByUnitScan.Name = "dgvByUnitScan";
            this.dgvByUnitScan.RowHeadersVisible = false;
            this.dgvByUnitScan.RowTemplate.Height = 23;
            this.dgvByUnitScan.Size = new System.Drawing.Size(334, 184);
            this.dgvByUnitScan.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TREATMENT_NO";
            this.dataGridViewTextBoxColumn3.HeaderText = "处理号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // INDEX_Y
            // 
            this.INDEX_Y.DataPropertyName = "INDEX_Y";
            this.INDEX_Y.HeaderText = "位置号";
            this.INDEX_Y.Name = "INDEX_Y";
            this.INDEX_Y.Width = 80;
            // 
            // X_CENTER
            // 
            this.X_CENTER.DataPropertyName = "X_CENTER";
            this.X_CENTER.HeaderText = "X中心";
            this.X_CENTER.Name = "X_CENTER";
            this.X_CENTER.Width = 80;
            // 
            // Y_CENTER
            // 
            this.Y_CENTER.DataPropertyName = "Y_CENTER";
            this.Y_CENTER.HeaderText = "Y中心";
            this.Y_CENTER.Name = "Y_CENTER";
            this.Y_CENTER.Width = 80;
            // 
            // XMAX
            // 
            this.XMAX.DataPropertyName = "XMAX";
            this.XMAX.HeaderText = "X最大";
            this.XMAX.Name = "XMAX";
            this.XMAX.Width = 80;
            // 
            // XMIN
            // 
            this.XMIN.DataPropertyName = "XMIN";
            this.XMIN.HeaderText = "X最小";
            this.XMIN.Name = "XMIN";
            this.XMIN.Width = 80;
            // 
            // YMAX
            // 
            this.YMAX.DataPropertyName = "YMAX";
            this.YMAX.HeaderText = "Y最大";
            this.YMAX.Name = "YMAX";
            this.YMAX.Width = 80;
            // 
            // YMIN
            // 
            this.YMIN.DataPropertyName = "YMIN";
            this.YMIN.HeaderText = "Y最小";
            this.YMIN.Name = "YMIN";
            this.YMIN.Width = 80;
            // 
            // conCraneStatus86
            // 
            this.conCraneStatus86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conCraneStatus86.CraneNO = "";
            this.conCraneStatus86.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conCraneStatus86.Location = new System.Drawing.Point(3, 3);
            this.conCraneStatus86.Name = "conCraneStatus86";
            this.conCraneStatus86.Size = new System.Drawing.Size(529, 214);
            this.conCraneStatus86.TabIndex = 0;
            this.conCraneStatus86.Load += new System.EventHandler(this.conCraneStatus86_Load);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.parkingStatusControl1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dgvByParking, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.trainParkingControl1, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.userMessage1, 0, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.12024F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.51795F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.07152F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.33264F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.95765F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(426, 423);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.btnCarArrive, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnLaserScan, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCarLeave, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(420, 41);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCarArrive
            // 
            this.btnCarArrive.BackColor = System.Drawing.Color.White;
            this.btnCarArrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCarArrive.Location = new System.Drawing.Point(3, 3);
            this.btnCarArrive.Name = "btnCarArrive";
            this.btnCarArrive.Size = new System.Drawing.Size(134, 35);
            this.btnCarArrive.TabIndex = 0;
            this.btnCarArrive.Text = "车辆到达";
            this.btnCarArrive.UseVisualStyleBackColor = false;
            this.btnCarArrive.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLaserScan
            // 
            this.btnLaserScan.BackColor = System.Drawing.Color.White;
            this.btnLaserScan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaserScan.Location = new System.Drawing.Point(143, 3);
            this.btnLaserScan.Name = "btnLaserScan";
            this.btnLaserScan.Size = new System.Drawing.Size(134, 35);
            this.btnLaserScan.TabIndex = 1;
            this.btnLaserScan.Text = "激光扫描";
            this.btnLaserScan.UseVisualStyleBackColor = false;
            this.btnLaserScan.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCarLeave
            // 
            this.btnCarLeave.BackColor = System.Drawing.Color.White;
            this.btnCarLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCarLeave.Location = new System.Drawing.Point(283, 3);
            this.btnCarLeave.Name = "btnCarLeave";
            this.btnCarLeave.Size = new System.Drawing.Size(134, 35);
            this.btnCarLeave.TabIndex = 2;
            this.btnCarLeave.Text = "车辆离开";
            this.btnCarLeave.UseVisualStyleBackColor = false;
            this.btnCarLeave.Click += new System.EventHandler(this.button3_Click);
            // 
            // parkingStatusControl1
            // 
            this.parkingStatusControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parkingStatusControl1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parkingStatusControl1.Location = new System.Drawing.Point(0, 47);
            this.parkingStatusControl1.Margin = new System.Windows.Forms.Padding(0);
            this.parkingStatusControl1.Name = "parkingStatusControl1";
            this.parkingStatusControl1.PARKING_NO = "CC1TV01";
            this.parkingStatusControl1.Size = new System.Drawing.Size(426, 52);
            this.parkingStatusControl1.TabIndex = 1;
            // 
            // dgvByParking
            // 
            this.dgvByParking.AllowUserToAddRows = false;
            this.dgvByParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvByParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARKING_NO,
            this.LASER_ACTION_COUNT,
            this.TREATMENT_NO,
            this.GROOVEID,
            this.GROOVE_ACT_X,
            this.GROOVE_ACT_Y,
            this.GROOVE_ACT_Z});
            this.dgvByParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvByParking.Location = new System.Drawing.Point(3, 102);
            this.dgvByParking.Name = "dgvByParking";
            this.dgvByParking.RowHeadersVisible = false;
            this.dgvByParking.RowTemplate.Height = 23;
            this.dgvByParking.Size = new System.Drawing.Size(420, 138);
            this.dgvByParking.TabIndex = 2;
            // 
            // PARKING_NO
            // 
            this.PARKING_NO.DataPropertyName = "PARKING_NO";
            this.PARKING_NO.HeaderText = "停车位号";
            this.PARKING_NO.Name = "PARKING_NO";
            // 
            // LASER_ACTION_COUNT
            // 
            this.LASER_ACTION_COUNT.DataPropertyName = "LASER_ACTION_COUNT";
            this.LASER_ACTION_COUNT.HeaderText = "扫描次数";
            this.LASER_ACTION_COUNT.Name = "LASER_ACTION_COUNT";
            // 
            // TREATMENT_NO
            // 
            this.TREATMENT_NO.DataPropertyName = "TREATMENT_NO";
            this.TREATMENT_NO.HeaderText = "处理号";
            this.TREATMENT_NO.Name = "TREATMENT_NO";
            // 
            // GROOVEID
            // 
            this.GROOVEID.DataPropertyName = "GROOVEID";
            this.GROOVEID.HeaderText = "槽号";
            this.GROOVEID.Name = "GROOVEID";
            this.GROOVEID.Width = 80;
            // 
            // GROOVE_ACT_X
            // 
            this.GROOVE_ACT_X.DataPropertyName = "GROOVE_ACT_X";
            this.GROOVE_ACT_X.HeaderText = "X中心";
            this.GROOVE_ACT_X.Name = "GROOVE_ACT_X";
            this.GROOVE_ACT_X.Width = 80;
            // 
            // GROOVE_ACT_Y
            // 
            this.GROOVE_ACT_Y.DataPropertyName = "GROOVE_ACT_Y";
            this.GROOVE_ACT_Y.HeaderText = "Y中心";
            this.GROOVE_ACT_Y.Name = "GROOVE_ACT_Y";
            this.GROOVE_ACT_Y.Width = 80;
            // 
            // GROOVE_ACT_Z
            // 
            this.GROOVE_ACT_Z.DataPropertyName = "GROOVE_ACT_Z";
            this.GROOVE_ACT_Z.HeaderText = "Z高度";
            this.GROOVE_ACT_Z.Name = "GROOVE_ACT_Z";
            // 
            // trainParkingControl1
            // 
            this.trainParkingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainParkingControl1.Location = new System.Drawing.Point(4, 248);
            this.trainParkingControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trainParkingControl1.Name = "trainParkingControl1";
            this.trainParkingControl1.Size = new System.Drawing.Size(418, 114);
            this.trainParkingControl1.TabIndex = 3;
            // 
            // userMessage1
            // 
            this.userMessage1.CraneNO = "";
            this.userMessage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userMessage1.Location = new System.Drawing.Point(4, 372);
            this.userMessage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userMessage1.Name = "userMessage1";
            this.userMessage1.Size = new System.Drawing.Size(418, 46);
            this.userMessage1.TabIndex = 4;
            // 
            // timer_ParkScanInfo
            // 
            this.timer_ParkScanInfo.Interval = 2000;
            this.timer_ParkScanInfo.Tick += new System.EventHandler(this.timer_ParkScanInfo_Tick);
            // 
            // timer_TrainParking
            // 
            this.timer_TrainParking.Interval = 1500;
            this.timer_TrainParking.Tick += new System.EventHandler(this.timer_TrainParking_Tick);
            // 
            // _Form_library_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "_Form_library_Monitor";
            this.Text = "_Form_library_Monitor";
            this.TabActivated += new System.EventHandler(this.MyTabActivated);
            this.TabDeactivated += new System.EventHandler(this.MyTabDeactivated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelZ53BayS.ResumeLayout(false);
            this.panelBay.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByUnitScan)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvByParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_InitializeLoad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelZ53BayS;
        private System.Windows.Forms.Button btnShowXY;
        private System.Windows.Forms.Button btnShowCrane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer_ShowXY;
        private System.Windows.Forms.Timer timerClear;
        private System.Windows.Forms.Timer timerAreaAndSaddle;
        private System.Windows.Forms.Timer timerArea;
        private System.Windows.Forms.Timer timerCrane;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelBay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtX;
        private UACSControls.conCrane conCrane86;
        //private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCarArrive;
        private System.Windows.Forms.Button btnLaserScan;
        private System.Windows.Forms.Button btnCarLeave;
        private UACSControls.CraneMonitor.ParkingStausControl parkingStatusControl1;
        private System.Windows.Forms.DataGridView dgvByParking;
        private System.Windows.Forms.Timer timer_ParkScanInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARKING_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASER_ACTION_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TREATMENT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROOVEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROOVE_ACT_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROOVE_ACT_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROOVE_ACT_Z;
        private System.Windows.Forms.Timer timer_RefreshOrder;
        private System.Windows.Forms.Timer timer_RefreshUnit;
        private UACSControls.CraneMonitor.TrainParkingControl trainParkingControl1;
        private System.Windows.Forms.Timer timer_TrainParking;
        private UACSControls.UserMessage userMessage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private UACSControls.CraneMonitor.MANUALControl manualControl1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label LineActionStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUnitLockStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUnitLock;
        private System.Windows.Forms.Button btnUnitUnLock;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvByUnitScan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn INDEX_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_CENTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_CENTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn YMAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn YMIN;
        private UACSControls.conCraneStatus conCraneStatus86;
    }
}