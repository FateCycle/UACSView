namespace UACSControls.CraneMonitor
{
    partial class CustomGrpTitle
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTitle
            // 
            this.grpTitle.BackgroundImage = global::UACSControls.Resource1.title_bg;
            this.grpTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpTitle.Controls.Add(this.lblTitle);
            this.grpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTitle.Location = new System.Drawing.Point(0, 0);
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.Size = new System.Drawing.Size(1204, 151);
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
            this.lblTitle.Size = new System.Drawing.Size(1204, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "标题栏";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CustomGrpTitle
            // 
            this.Controls.Add(this.grpTitle);
            this.Name = "CustomGrpTitle";
            this.Size = new System.Drawing.Size(1204, 151);
            this.grpTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel grpTitle;
    }
}
