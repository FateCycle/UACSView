namespace UACSControls
{
    partial class conUnitSaddle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMatNo1 = new System.Windows.Forms.Label();
            this.lblMatNo2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMatNo1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMatNo2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMatNo1
            // 
            this.lblMatNo1.AutoSize = true;
            this.lblMatNo1.BackColor = System.Drawing.Color.DarkGray;
            this.lblMatNo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatNo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatNo1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMatNo1.Location = new System.Drawing.Point(0, 0);
            this.lblMatNo1.Margin = new System.Windows.Forms.Padding(0);
            this.lblMatNo1.Name = "lblMatNo1";
            this.lblMatNo1.Size = new System.Drawing.Size(470, 77);
            this.lblMatNo1.TabIndex = 0;
            this.lblMatNo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatNo2
            // 
            this.lblMatNo2.AutoSize = true;
            this.lblMatNo2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMatNo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMatNo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatNo2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMatNo2.Location = new System.Drawing.Point(0, 77);
            this.lblMatNo2.Margin = new System.Windows.Forms.Padding(0);
            this.lblMatNo2.Name = "lblMatNo2";
            this.lblMatNo2.Size = new System.Drawing.Size(470, 77);
            this.lblMatNo2.TabIndex = 1;
            this.lblMatNo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conUnitSaddle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "conUnitSaddle";
            this.Size = new System.Drawing.Size(470, 154);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMatNo1;
        private System.Windows.Forms.Label lblMatNo2;
    }
}
