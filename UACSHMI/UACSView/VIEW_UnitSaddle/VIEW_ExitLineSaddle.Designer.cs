namespace UACSView
{
    partial class VIEW_ExitLineSaddle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEW_ExitLineSaddle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAutoScroll = new System.Windows.Forms.Panel();
            this.coilUnitStatus1 = new UACSControls.CoilUnitStatus();
            this.coilUnitSaddleButton1 = new UACSControls.CoilUnitSaddleButton();
            this.coilUnitSaddle1 = new UACSControls.CoilUnitSaddle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExitSaddleInfo = new System.Windows.Forms.DataGridView();
            this.SADDLE_L2NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COIL_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WIDTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OUTDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORBIDEN_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUMMY_COIL_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEXT_UNIT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACK_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACK_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_LineSaddleControl = new System.Windows.Forms.Timer(this.components);
            this.panelAutoScroll.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExitSaddleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAutoScroll
            // 
            this.panelAutoScroll.AutoScroll = true;
            this.panelAutoScroll.Controls.Add(this.coilUnitStatus1);
            this.panelAutoScroll.Controls.Add(this.coilUnitSaddleButton1);
            this.panelAutoScroll.Controls.Add(this.coilUnitSaddle1);
            this.panelAutoScroll.Controls.Add(this.groupBox1);
            this.panelAutoScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAutoScroll.Location = new System.Drawing.Point(0, 0);
            this.panelAutoScroll.Name = "panelAutoScroll";
            this.panelAutoScroll.Size = new System.Drawing.Size(1290, 698);
            this.panelAutoScroll.TabIndex = 1;
            // 
            // coilUnitStatus1
            // 
            this.coilUnitStatus1.Location = new System.Drawing.Point(848, 461);
            this.coilUnitStatus1.Name = "coilUnitStatus1";
            this.coilUnitStatus1.Size = new System.Drawing.Size(24, 23);
            this.coilUnitStatus1.TabIndex = 31;
            // 
            // coilUnitSaddleButton1
            // 
            this.coilUnitSaddleButton1.Location = new System.Drawing.Point(453, 580);
            this.coilUnitSaddleButton1.MySaddleNo = "";
            //this.coilUnitSaddleButton1.MySaddleTagName = "";
            this.coilUnitSaddleButton1.Name = "coilUnitSaddleButton1";
            this.coilUnitSaddleButton1.Size = new System.Drawing.Size(192, 52);
            this.coilUnitSaddleButton1.TabIndex = 30;
            // 
            // coilUnitSaddle1
            // 
            this.coilUnitSaddle1.ButtonDImage = ((System.Drawing.Image)(resources.GetObject("coilUnitSaddle1.ButtonDImage")));
            this.coilUnitSaddle1.ButtonUImage = ((System.Drawing.Image)(resources.GetObject("coilUnitSaddle1.ButtonUImage")));
            this.coilUnitSaddle1.CoilBackColor = System.Drawing.Color.SkyBlue;
            this.coilUnitSaddle1.CoilFontColor = System.Drawing.Color.Black;
            this.coilUnitSaddle1.CoilId = "AAAAAAAAAA0";
            this.coilUnitSaddle1.CoilLength = 16;
            this.coilUnitSaddle1.CoilStatus = -10;
            this.coilUnitSaddle1.Director = Baosight.ColdRolling.TcmControl.Direct.Horizontal;
            this.coilUnitSaddle1.DownEnable = true;
            this.coilUnitSaddle1.DownVisiable = true;
            this.coilUnitSaddle1.Location = new System.Drawing.Point(390, 461);
            this.coilUnitSaddle1.Name = "coilUnitSaddle1";
            this.coilUnitSaddle1.PosName = "鞍座";
            this.coilUnitSaddle1.PosNo = 1;
            this.coilUnitSaddle1.Size = new System.Drawing.Size(281, 150);
            this.coilUnitSaddle1.SkidName = "skidControl";
            this.coilUnitSaddle1.SkidSize = new System.Drawing.Size(215, 115);
            this.coilUnitSaddle1.TabIndex = 29;
            this.coilUnitSaddle1.TextFont = new System.Drawing.Font("微软雅黑", 15F);
            this.coilUnitSaddle1.UpEnable = true;
            this.coilUnitSaddle1.UpVisiable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.dgvExitSaddleInfo);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(25, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 266);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "鞍座信息";
            // 
            // dgvExitSaddleInfo
            // 
            this.dgvExitSaddleInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            this.dgvExitSaddleInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExitSaddleInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExitSaddleInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvExitSaddleInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExitSaddleInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExitSaddleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExitSaddleInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SADDLE_L2NAME,
            this.STOCK_NO,
            this.COIL_NO,
            this.WEIGHT,
            this.WIDTH,
            this.INDIA,
            this.OUTDIA,
            this.FORBIDEN_FLAG,
            this.DUMMY_COIL_FLAG,
            this.NEXT_UNIT_NO,
            this.PACK_CODE,
            this.PACK_FLAG});
            this.dgvExitSaddleInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExitSaddleInfo.EnableHeadersVisualStyles = false;
            this.dgvExitSaddleInfo.Location = new System.Drawing.Point(3, 19);
            this.dgvExitSaddleInfo.Name = "dgvExitSaddleInfo";
            this.dgvExitSaddleInfo.ReadOnly = true;
            this.dgvExitSaddleInfo.RowHeadersVisible = false;
            this.dgvExitSaddleInfo.RowTemplate.Height = 23;
            this.dgvExitSaddleInfo.Size = new System.Drawing.Size(1209, 244);
            this.dgvExitSaddleInfo.TabIndex = 2;
            // 
            // SADDLE_L2NAME
            // 
            this.SADDLE_L2NAME.DataPropertyName = "SADDLE_L2NAME";
            this.SADDLE_L2NAME.HeaderText = "序号";
            this.SADDLE_L2NAME.Name = "SADDLE_L2NAME";
            this.SADDLE_L2NAME.ReadOnly = true;
            // 
            // STOCK_NO
            // 
            this.STOCK_NO.DataPropertyName = "STOCK_NO";
            this.STOCK_NO.HeaderText = "鞍座号";
            this.STOCK_NO.Name = "STOCK_NO";
            this.STOCK_NO.ReadOnly = true;
            // 
            // COIL_NO
            // 
            this.COIL_NO.DataPropertyName = "COIL_NO";
            this.COIL_NO.HeaderText = "钢卷号";
            this.COIL_NO.Name = "COIL_NO";
            this.COIL_NO.ReadOnly = true;
            // 
            // WEIGHT
            // 
            this.WEIGHT.DataPropertyName = "WEIGHT";
            this.WEIGHT.HeaderText = "重量";
            this.WEIGHT.Name = "WEIGHT";
            this.WEIGHT.ReadOnly = true;
            // 
            // WIDTH
            // 
            this.WIDTH.DataPropertyName = "WIDTH";
            this.WIDTH.HeaderText = "宽度";
            this.WIDTH.Name = "WIDTH";
            this.WIDTH.ReadOnly = true;
            // 
            // INDIA
            // 
            this.INDIA.DataPropertyName = "INDIA";
            this.INDIA.HeaderText = "内径";
            this.INDIA.Name = "INDIA";
            this.INDIA.ReadOnly = true;
            // 
            // OUTDIA
            // 
            this.OUTDIA.DataPropertyName = "OUTDIA";
            this.OUTDIA.HeaderText = "外径";
            this.OUTDIA.Name = "OUTDIA";
            this.OUTDIA.ReadOnly = true;
            // 
            // FORBIDEN_FLAG
            // 
            this.FORBIDEN_FLAG.DataPropertyName = "FORBIDEN_FLAG";
            this.FORBIDEN_FLAG.HeaderText = "封闭标记";
            this.FORBIDEN_FLAG.Name = "FORBIDEN_FLAG";
            this.FORBIDEN_FLAG.ReadOnly = true;
            // 
            // DUMMY_COIL_FLAG
            // 
            this.DUMMY_COIL_FLAG.DataPropertyName = "DUMMY_COIL_FLAG";
            this.DUMMY_COIL_FLAG.HeaderText = "返回卷标记";
            this.DUMMY_COIL_FLAG.Name = "DUMMY_COIL_FLAG";
            this.DUMMY_COIL_FLAG.ReadOnly = true;
            // 
            // NEXT_UNIT_NO
            // 
            this.NEXT_UNIT_NO.DataPropertyName = "NEXT_UNIT_NO";
            this.NEXT_UNIT_NO.HeaderText = "下道机组";
            this.NEXT_UNIT_NO.Name = "NEXT_UNIT_NO";
            this.NEXT_UNIT_NO.ReadOnly = true;
            // 
            // PACK_CODE
            // 
            this.PACK_CODE.DataPropertyName = "PACK_CODE";
            this.PACK_CODE.HeaderText = "包装代码";
            this.PACK_CODE.Name = "PACK_CODE";
            this.PACK_CODE.ReadOnly = true;
            // 
            // PACK_FLAG
            // 
            this.PACK_FLAG.DataPropertyName = "PACK_FLAG";
            this.PACK_FLAG.HeaderText = "是否包装";
            this.PACK_FLAG.Name = "PACK_FLAG";
            this.PACK_FLAG.ReadOnly = true;
            // 
            // timer_LineSaddleControl
            // 
            this.timer_LineSaddleControl.Enabled = true;
            this.timer_LineSaddleControl.Interval = 5000;
            this.timer_LineSaddleControl.Tick += new System.EventHandler(this.timer_LineSaddleControl_Tick);
            // 
            // VIEW_ExitLineSaddle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 698);
            this.Controls.Add(this.panelAutoScroll);
            this.Name = "VIEW_ExitLineSaddle";
            this.Text = "VIEW_ExitLineSaddle";
            this.TabActivated += new System.EventHandler(this.MyTabActivated);
            this.TabDeactivated += new System.EventHandler(this.MyTabDeactivated);
            this.panelAutoScroll.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExitSaddleInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAutoScroll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExitSaddleInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SADDLE_L2NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COIL_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WIDTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn INDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OUTDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORBIDEN_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUMMY_COIL_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEXT_UNIT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACK_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACK_FLAG;

        private System.Windows.Forms.Timer timer_LineSaddleControl;
        private UACSControls.CoilUnitSaddleButton coilUnitSaddleButton1;
        private UACSControls.CoilUnitSaddle coilUnitSaddle1;
        private UACSControls.CoilUnitStatus coilUnitStatus1;
    }
}