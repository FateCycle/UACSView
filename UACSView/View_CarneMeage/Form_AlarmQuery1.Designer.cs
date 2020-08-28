namespace UACSView.View_CarneMeage
{
    partial class Form_AlarmQuery1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AlarmQuery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCrane = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMsgMoudle = new System.Windows.Forms.ComboBox();
            this.txtMatNO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMsgLevel = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.grpTitle.SuspendLayout();
            this.grpOperate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.SuspendLayout();
            
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.fg);
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(12, 15, 12, 10);
            this.pnlContainer.Size = new System.Drawing.Size(1899, 786);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(1899, 60);
            this.lblTitle.Text = "报警信息管理";
            // 
            // grpTitle
            // 
            this.grpTitle.Size = new System.Drawing.Size(1899, 60);
            // 
            // grpOperate
            // 
            this.grpOperate.Controls.Add(this.btnExport);
            this.grpOperate.Controls.Add(this.btnQuery);
            this.grpOperate.Controls.Add(this.txtMatNO);
            this.grpOperate.Controls.Add(this.cbbMsgLevel);
            this.grpOperate.Controls.Add(this.cbbMsgMoudle);
            this.grpOperate.Controls.Add(this.cbbCrane);
            this.grpOperate.Controls.Add(this.groupBox1);
            this.grpOperate.Controls.Add(this.label6);
            this.grpOperate.Controls.Add(this.label4);
            this.grpOperate.Controls.Add(this.label5);
            this.grpOperate.Controls.Add(this.label3);
            this.grpOperate.Size = new System.Drawing.Size(1899, 100);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间段";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(139, 54);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 26);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(140, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 26);
            this.dtpStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(59, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "结束时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(698, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "行车";
            // 
            // cbbCrane
            // 
            this.cbbCrane.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbCrane.FormattingEnabled = true;
            this.cbbCrane.Location = new System.Drawing.Point(743, 23);
            this.cbbCrane.Name = "cbbCrane";
            this.cbbCrane.Size = new System.Drawing.Size(121, 27);
            this.cbbCrane.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(682, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "材料号";
            // 
            // cbbMsgMoudle
            // 
            this.cbbMsgMoudle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbMsgMoudle.FormattingEnabled = true;
            this.cbbMsgMoudle.Location = new System.Drawing.Point(985, 24);
            this.cbbMsgMoudle.Name = "cbbMsgMoudle";
            this.cbbMsgMoudle.Size = new System.Drawing.Size(121, 27);
            this.cbbMsgMoudle.TabIndex = 1;
            // 
            // txtMatNO
            // 
            this.txtMatNO.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMatNO.Location = new System.Drawing.Point(743, 59);
            this.txtMatNO.Name = "txtMatNO";
            this.txtMatNO.Size = new System.Drawing.Size(121, 26);
            this.txtMatNO.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(924, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "模块名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(908, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "信息级别";
            // 
            // cbbMsgLevel
            // 
            this.cbbMsgLevel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbMsgLevel.FormattingEnabled = true;
            this.cbbMsgLevel.Location = new System.Drawing.Point(985, 60);
            this.cbbMsgLevel.Name = "cbbMsgLevel";
            this.cbbMsgLevel.Size = new System.Drawing.Size(121, 27);
            this.cbbMsgLevel.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            //this.btnQuery.Image = global::InfoManager.Properties.Resources.icon_Query;
            this.btnQuery.Location = new System.Drawing.Point(1720, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(132, 66);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查 询";
            this.btnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // fg
            // 
            this.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fg.DragMode = C1.Win.C1FlexGrid.DragModeEnum.Automatic;
            this.fg.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.fg.ExtendLastCol = true;
            this.fg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fg.Location = new System.Drawing.Point(12, 15);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 26;
            this.fg.ShowCursor = true;
            this.fg.Size = new System.Drawing.Size(1875, 761);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 2;
            //this.fg.DoubleClick += new System.EventHandler(this.fg_DoubleClick);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            // this.btnExport.Image = global::InfoManager.Properties.Resources.Export24;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(2298, 41);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 43);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = " 导 出";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // B3_AlarmQuery
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 946);
            this.Name = "B3_AlarmQuery";
            this.Text = "B3_AlarmQuery";
            this.pnlContainer.ResumeLayout(false);
            this.grpTitle.ResumeLayout(false);
            this.grpOperate.ResumeLayout(false);
            this.grpOperate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatNO;
        private System.Windows.Forms.ComboBox cbbMsgMoudle;
        private System.Windows.Forms.ComboBox cbbCrane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMsgLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnQuery;
        public C1.Win.C1FlexGrid.C1FlexGrid fg;
        public System.Windows.Forms.Button btnExport;
    }
}