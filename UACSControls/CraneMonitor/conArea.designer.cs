
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace UACSControls
{
    partial class conArea
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemUpCover = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDownCover = new System.Windows.Forms.ToolStripMenuItem();
            this.修改盖状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有盖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无盖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUpCover,
            this.toolStripMenuItemDownCover,
            this.修改盖状态ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 82);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripMenuItemUpCover
            // 
            this.toolStripMenuItemUpCover.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItemUpCover.Name = "toolStripMenuItemUpCover";
            this.toolStripMenuItemUpCover.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItemUpCover.Text = "吊盖";
            this.toolStripMenuItemUpCover.Click += new System.EventHandler(this.toolStripMenuItemUpCover_Click);
            // 
            // toolStripMenuItemDownCover
            // 
            this.toolStripMenuItemDownCover.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripMenuItemDownCover.Name = "toolStripMenuItemDownCover";
            this.toolStripMenuItemDownCover.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItemDownCover.Text = "卸盖";
            this.toolStripMenuItemDownCover.Click += new System.EventHandler(this.toolStripMenuItemDownCover_Click);
            // 
            // 修改盖状态ToolStripMenuItem
            // 
            this.修改盖状态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.有盖ToolStripMenuItem,
            this.无盖ToolStripMenuItem});
            this.修改盖状态ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.修改盖状态ToolStripMenuItem.Name = "修改盖状态ToolStripMenuItem";
            this.修改盖状态ToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.修改盖状态ToolStripMenuItem.Text = "修改盖状态";
            this.修改盖状态ToolStripMenuItem.Click += new System.EventHandler(this.修改盖状态ToolStripMenuItem_Click);
            // 
            // 有盖ToolStripMenuItem
            // 
            this.有盖ToolStripMenuItem.Name = "有盖ToolStripMenuItem";
            this.有盖ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.有盖ToolStripMenuItem.Text = "有盖";
            this.有盖ToolStripMenuItem.Click += new System.EventHandler(this.有盖ToolStripMenuItem_Click);
            // 
            // 无盖ToolStripMenuItem
            // 
            this.无盖ToolStripMenuItem.Name = "无盖ToolStripMenuItem";
            this.无盖ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.无盖ToolStripMenuItem.Text = "无盖";
            this.无盖ToolStripMenuItem.Click += new System.EventHandler(this.无盖ToolStripMenuItem_Click);
            // 
            // conArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "conArea";
            this.Size = new System.Drawing.Size(207, 190);
            this.Load += new System.EventHandler(this.conArea_Click);
            this.Click += new System.EventHandler(this.conArea_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.conArea_Paint);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpCover;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDownCover;
        private System.Windows.Forms.ToolStripMenuItem 修改盖状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有盖ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无盖ToolStripMenuItem;
    }
}
