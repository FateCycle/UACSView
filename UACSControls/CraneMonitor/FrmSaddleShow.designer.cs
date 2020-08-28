namespace UACSControls
{
    partial class FrmSaddleShow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblArea = new System.Windows.Forms.Label();
            this.panelSaddle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AREA_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREA_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_START = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_END = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_START = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_END = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSaddle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblArea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelSaddle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.754447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.0385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.207053F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 783);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblArea.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblArea.Location = new System.Drawing.Point(579, 18);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(86, 31);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "坑区号";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // panelSaddle
            // 
            this.panelSaddle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSaddle.Controls.Add(this.panel2);
            this.panelSaddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaddle.Location = new System.Drawing.Point(3, 71);
            this.panelSaddle.Name = "panelSaddle";
            this.panelSaddle.Size = new System.Drawing.Size(1238, 644);
            this.panelSaddle.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(43, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 576);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnUpdata);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 721);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 59);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(256, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "不可吊运";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(232, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 33);
            this.panel4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(142, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "有坯-可吊";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(118, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 33);
            this.panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "无坯-可放";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(9, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 33);
            this.panel5.TabIndex = 11;
            // 
            // btnUpdata
            // 
            this.btnUpdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdata.BackColor = System.Drawing.Color.AliceBlue;
            this.btnUpdata.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdata.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdata.Location = new System.Drawing.Point(973, 12);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(116, 36);
            this.btnUpdata.TabIndex = 7;
            this.btnUpdata.Text = "刷新";
            this.btnUpdata.UseVisualStyleBackColor = false;
            this.btnUpdata.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(1113, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AREA_NO,
            this.AREA_NAME,
            this.X_START,
            this.X_END,
            this.Y_START,
            this.Y_END,
            this.STATUS});
            this.dataGridView1.Location = new System.Drawing.Point(127, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(919, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AREA_NO
            // 
            this.AREA_NO.DataPropertyName = "AREA_NO";
            this.AREA_NO.HeaderText = "编号";
            this.AREA_NO.Name = "AREA_NO";
            // 
            // AREA_NAME
            // 
            this.AREA_NAME.DataPropertyName = "AREA_NAME";
            this.AREA_NAME.HeaderText = "名称";
            this.AREA_NAME.Name = "AREA_NAME";
            // 
            // X_START
            // 
            this.X_START.DataPropertyName = "X_START";
            this.X_START.HeaderText = "X_开始";
            this.X_START.Name = "X_START";
            // 
            // X_END
            // 
            this.X_END.DataPropertyName = "X_END";
            this.X_END.HeaderText = "X_结束";
            this.X_END.Name = "X_END";
            // 
            // Y_START
            // 
            this.Y_START.DataPropertyName = "Y_START";
            this.Y_START.HeaderText = "Y_开始";
            this.Y_START.Name = "Y_START";
            // 
            // Y_END
            // 
            this.Y_END.DataPropertyName = "Y_END";
            this.Y_END.HeaderText = "Y_结束";
            this.Y_END.Name = "Y_END";
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "锁定";
            this.STATUS.Name = "STATUS";
            // 
            // FrmSaddleShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 783);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FrmSaddleShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成品库库区详细画面";
            this.Load += new System.EventHandler(this.FrmSaddleShow_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelSaddle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Panel panelSaddle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_START;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_END;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_START;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_END;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        // private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}