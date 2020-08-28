namespace UACSControls.CraneMonitor
{
    partial class BaseForm
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpOperate = new L2Tools.Lib.CustomControls.RoundedRectangularGroupBox();
            this.grpTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.containerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.grpTitle.SuspendLayout();
            this.containerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();


            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(3, 219);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1888, 722);
            this.pnlContainer.TabIndex = 5;
            // 
            // grpOperate
            // 
            this.grpOperate.BorderWidth = 0;
            this.grpOperate.ColorScheme = L2Tools.Functions.ColorSln.EnmColorScheme.BlueGray;
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
            this.grpOperate.Size = new System.Drawing.Size(1888, 150);
            this.grpOperate.TabIndex = 8;
            this.grpOperate.TabStop = false;
            // 
            // grpTitle
            // 
            this.grpTitle.BackgroundImage = global::UACSControls.Resource1.title_bg;
            this.grpTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTitle.Controls.Add(this.lblTitle);
            this.grpTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTitle.Location = new System.Drawing.Point(3, 3);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(1888, 54);
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
            this.lblTitle.Size = new System.Drawing.Size(1888, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "标题栏";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // containerTableLayoutPanel
            // 
            this.containerTableLayoutPanel.ColumnCount = 1;
            this.containerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerTableLayoutPanel.Controls.Add(this.grpTitle, 0, 0);
            this.containerTableLayoutPanel.Controls.Add(this.grpOperate, 0, 1);
            this.containerTableLayoutPanel.Controls.Add(this.pnlContainer, 0, 2);
            this.containerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.containerTableLayoutPanel.Name = "containerTableLayoutPanel";
            this.containerTableLayoutPanel.RowCount = 3;
            this.containerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.containerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.containerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.containerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.containerTableLayoutPanel.Size = new System.Drawing.Size(1894, 944);
            this.containerTableLayoutPanel.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 944);
            this.Controls.Add(this.containerTableLayoutPanel);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.grpTitle.ResumeLayout(false);
            this.containerTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlContainer;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel grpTitle;
        public L2Tools.Lib.CustomControls.RoundedRectangularGroupBox grpOperate;
        internal System.Windows.Forms.TableLayoutPanel containerTableLayoutPanel;
    }
}