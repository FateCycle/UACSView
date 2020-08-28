using System.Web.UI.Design;

namespace UACSView.View_CarneMeage
{
    partial class Form_AlarmQuery
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
            this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.containerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpOperate = new L2Tools.Lib.CustomControls.RoundedRectangularGroupBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.grpTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.containerTableLayoutPanel.SuspendLayout();
            this.grpOperate.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.Location = new System.Drawing.Point(214, 71);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 29);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpStart.Location = new System.Drawing.Point(214, 18);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 29);
            this.dtpStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(103, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "结束时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(553, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "行车";
            // 
            // cbbCrane
            // 
            this.cbbCrane.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbCrane.FormattingEnabled = true;
            this.cbbCrane.Location = new System.Drawing.Point(667, 18);
            this.cbbCrane.Name = "cbbCrane";
            this.cbbCrane.Size = new System.Drawing.Size(195, 34);
            this.cbbCrane.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(553, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "材料号";
            // 
            // cbbMsgMoudle
            // 
            this.cbbMsgMoudle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbMsgMoudle.FormattingEnabled = true;
            this.cbbMsgMoudle.Location = new System.Drawing.Point(1139, 17);
            this.cbbMsgMoudle.Name = "cbbMsgMoudle";
            this.cbbMsgMoudle.Size = new System.Drawing.Size(186, 34);
            this.cbbMsgMoudle.TabIndex = 1;
            // 
            // txtMatNO
            // 
            this.txtMatNO.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMatNO.Location = new System.Drawing.Point(667, 67);
            this.txtMatNO.Name = "txtMatNO";
            this.txtMatNO.Size = new System.Drawing.Size(195, 33);
            this.txtMatNO.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1015, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "模块名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1015, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "信息级别";
            // 
            // cbbMsgLevel
            // 
            this.cbbMsgLevel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbbMsgLevel.FormattingEnabled = true;
            this.cbbMsgLevel.Location = new System.Drawing.Point(1139, 67);
            this.cbbMsgLevel.Name = "cbbMsgLevel";
            this.cbbMsgLevel.Size = new System.Drawing.Size(186, 34);
            this.cbbMsgLevel.TabIndex = 1;
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
            this.fg.Size = new System.Drawing.Size(1869, 735);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 2;
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
            this.containerTableLayoutPanel.Size = new System.Drawing.Size(1899, 946);
            this.containerTableLayoutPanel.TabIndex = 0;
            this.containerTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // grpOperate
            // 
            this.grpOperate.BorderWidth = 0;
            this.grpOperate.ColorScheme = L2Tools.Functions.ColorSln.EnmColorScheme.BlueGray;
            this.grpOperate.Controls.Add(this.btnExport);
            this.grpOperate.Controls.Add(this.btnQuery);
            this.grpOperate.Controls.Add(this.txtMatNO);
            this.grpOperate.Controls.Add(this.cbbMsgLevel);
            this.grpOperate.Controls.Add(this.cbbMsgMoudle);
            this.grpOperate.Controls.Add(this.cbbCrane);
            this.grpOperate.Controls.Add(this.label1);
            this.grpOperate.Controls.Add(this.label2);
            this.grpOperate.Controls.Add(this.dtpEnd);
            this.grpOperate.Controls.Add(this.dtpStart);
            this.grpOperate.Controls.Add(this.label6);
            this.grpOperate.Controls.Add(this.label4);
            this.grpOperate.Controls.Add(this.label5);
            this.grpOperate.Controls.Add(this.label3);
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
            this.grpOperate.Size = new System.Drawing.Size(1893, 114);
            this.grpOperate.TabIndex = 8;
            this.grpOperate.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.fg);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(3, 183);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(12, 15, 12, 10);
            this.pnlContainer.Size = new System.Drawing.Size(1893, 760);
            this.pnlContainer.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Image = global::UACSView.Properties.Resources.search__1_;
            this.btnQuery.Location = new System.Drawing.Point(1576, 34);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(101, 48);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查 询";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuery.UseVisualStyleBackColor = false;
            // 
            // grpTitle
            // 
            this.grpTitle.BackgroundImage = global::UACSView.Properties.Resources.title_bg;
            this.grpTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTitle.Controls.Add(this.lblTitle);
            this.grpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTitle.Location = new System.Drawing.Point(3, 3);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(1893, 54);
            this.grpTitle.TabIndex = 6;
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
            this.lblTitle.Size = new System.Drawing.Size(1893, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "报警信息管理";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::UACSView.Properties.Resources.export__1_;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(1724, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(101, 48);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = " 导 出";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // Form_AlarmQuery
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 946);
            this.Controls.Add(this.containerTableLayoutPanel);
            this.Name = "Form_AlarmQuery";
            this.Text = "B3_AlarmQuery";
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.containerTableLayoutPanel.ResumeLayout(false);
            this.grpOperate.ResumeLayout(false);
            this.grpOperate.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.grpTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel grpTitle;
        public L2Tools.Lib.CustomControls.RoundedRectangularGroupBox grpOperate;
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
        private System.Windows.Forms.TableLayoutPanel containerTableLayoutPanel;
    }
}