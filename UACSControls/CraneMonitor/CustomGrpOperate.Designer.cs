namespace UACSControls.CraneMonitor
{
    partial class CustomGrpOperate
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
            this.grpOperate = new L2Tools.Lib.CustomControls.RoundedRectangularGroupBox();
            this.SuspendLayout();
            // 
            // grpOperate
            // 
            this.grpOperate.BorderWidth = 0;
            this.grpOperate.ColorScheme = L2Tools.Functions.ColorSln.EnmColorScheme.BlueGray;
            this.grpOperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOperate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpOperate.FontColor = System.Drawing.Color.Black;
            this.grpOperate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpOperate.GroupTitleThick = 0;
            this.grpOperate.Location = new System.Drawing.Point(0, 0);
            this.grpOperate.MoGradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(190)))), ((int)(((byte)(221)))));
            this.grpOperate.MoGradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(211)))), ((int)(((byte)(233)))));
            this.grpOperate.MoInteriorBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grpOperate.MoInteriorTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.grpOperate.Name = "grpOperate";
            this.grpOperate.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.grpOperate.Size = new System.Drawing.Size(1309, 161);
            this.grpOperate.TabIndex = 1;
            this.grpOperate.TabStop = false;
            // 
            // CustomGrpOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpOperate);
            this.Name = "CustomGrpOperate";
            this.Size = new System.Drawing.Size(1309, 161);
            this.ResumeLayout(false);

        }

        #endregion
        public L2Tools.Lib.CustomControls.RoundedRectangularGroupBox grpOperate;
    }
}
