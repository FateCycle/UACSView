namespace UACSControls
{
    partial class conCrane
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCrane = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStrip_YardToTard = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_DelCraneOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCrab = new System.Windows.Forms.Panel();
            this.panelCrane.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCrane
            // 
            this.panelCrane.AutoSize = true;
            this.panelCrane.BackColor = System.Drawing.Color.Transparent;
            this.panelCrane.BackgroundImage = global::UACSControls.Resource1.行车_Avoid;
            this.panelCrane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCrane.ContextMenuStrip = this.contextMenuStrip1;
            this.panelCrane.Controls.Add(this.panelCrab);
            this.panelCrane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrane.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelCrane.Location = new System.Drawing.Point(0, 0);
            this.panelCrane.Name = "panelCrane";
            this.panelCrane.Size = new System.Drawing.Size(47, 300);
            this.panelCrane.TabIndex = 3;
            this.panelCrane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCrane_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_YardToTard,
            this.ToolStrip_DelCraneOrder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ToolStrip_YardToTard
            // 
            this.ToolStrip_YardToTard.Name = "ToolStrip_YardToTard";
            this.ToolStrip_YardToTard.Size = new System.Drawing.Size(124, 22);
            this.ToolStrip_YardToTard.Text = "倒垛任务";
            this.ToolStrip_YardToTard.Click += new System.EventHandler(this.ToolStrip_YardToTard_Click);
            // 
            // ToolStrip_DelCraneOrder
            // 
            this.ToolStrip_DelCraneOrder.AutoSize = false;
            this.ToolStrip_DelCraneOrder.Name = "ToolStrip_DelCraneOrder";
            this.ToolStrip_DelCraneOrder.Size = new System.Drawing.Size(124, 22);
            this.ToolStrip_DelCraneOrder.Text = "清空指令";
            this.ToolStrip_DelCraneOrder.Click += new System.EventHandler(this.ToolStrip_DelCraneOrder_Click);
            // 
            // panelCrab
            // 
            this.panelCrab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCrab.BackColor = System.Drawing.Color.White;
            this.panelCrab.BackgroundImage = global::UACSControls.Resource1.imgCarCoil;
            this.panelCrab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCrab.Location = new System.Drawing.Point(0, 140);
            this.panelCrab.Name = "panelCrab";
            this.panelCrab.Size = new System.Drawing.Size(47, 27);
            this.panelCrab.TabIndex = 3;
            // 
            // conCrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelCrane);
            this.Name = "conCrane";
            this.Size = new System.Drawing.Size(47, 300);
            this.panelCrane.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCrane;
        private System.Windows.Forms.Panel panelCrab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_YardToTard;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_DelCraneOrder;
    }
}
