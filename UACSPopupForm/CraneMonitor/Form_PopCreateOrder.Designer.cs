namespace UACSPopupForm.CraneMonitor
{
    partial class Form_PopCreateOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbCraneNo = new System.Windows.Forms.ComboBox();
            this.cbbOrderType = new System.Windows.Forms.ComboBox();
            this.cbbFromStockNo = new System.Windows.Forms.ComboBox();
            this.cbbToStockNo = new System.Windows.Forms.ComboBox();
            this.lblMatNo = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblOutdia = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 749);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.83562F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.16438F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateOrder, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMatNo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblWeight, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblOutdia, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblWidth, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "行车号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = "作业类型：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 73);
            this.label3.TabIndex = 2;
            this.label3.Text = "起始鞍座：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 73);
            this.label4.TabIndex = 3;
            this.label4.Text = "目标鞍座：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1, 371);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 73);
            this.label5.TabIndex = 4;
            this.label5.Text = "材料号：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1, 445);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 73);
            this.label6.TabIndex = 5;
            this.label6.Text = "重量：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1, 519);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 73);
            this.label7.TabIndex = 6;
            this.label7.Text = "外径：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1, 593);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 73);
            this.label8.TabIndex = 7;
            this.label8.Text = "宽度：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(101)))), ((int)(((byte)(175)))));
            this.btnCreateOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Location = new System.Drawing.Point(259, 669);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(322, 77);
            this.btnCreateOrder.TabIndex = 8;
            this.btnCreateOrder.Text = "提交";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.cbbCraneNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbOrderType, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbFromStockNo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbbToStockNo, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(259, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(322, 290);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // cbbCraneNo
            // 
            this.cbbCraneNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbCraneNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbCraneNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCraneNo.DropDownHeight = 250;
            this.cbbCraneNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCraneNo.Font = new System.Drawing.Font("宋体", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbCraneNo.FormattingEnabled = true;
            this.cbbCraneNo.IntegralHeight = false;
            this.cbbCraneNo.Location = new System.Drawing.Point(4, 7);
            this.cbbCraneNo.Margin = new System.Windows.Forms.Padding(4, 7, 3, 3);
            this.cbbCraneNo.Name = "cbbCraneNo";
            this.cbbCraneNo.Size = new System.Drawing.Size(315, 55);
            this.cbbCraneNo.TabIndex = 0;
            // 
            // cbbOrderType
            // 
            this.cbbOrderType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbOrderType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbOrderType.DropDownHeight = 250;
            this.cbbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbOrderType.Font = new System.Drawing.Font("宋体", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbOrderType.FormattingEnabled = true;
            this.cbbOrderType.IntegralHeight = false;
            this.cbbOrderType.Location = new System.Drawing.Point(4, 79);
            this.cbbOrderType.Margin = new System.Windows.Forms.Padding(4, 7, 3, 3);
            this.cbbOrderType.Name = "cbbOrderType";
            this.cbbOrderType.Size = new System.Drawing.Size(315, 55);
            this.cbbOrderType.TabIndex = 1;
            // 
            // cbbFromStockNo
            // 
            this.cbbFromStockNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbFromStockNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbFromStockNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbFromStockNo.DropDownHeight = 250;
            this.cbbFromStockNo.Font = new System.Drawing.Font("宋体", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbFromStockNo.FormattingEnabled = true;
            this.cbbFromStockNo.IntegralHeight = false;
            this.cbbFromStockNo.Location = new System.Drawing.Point(4, 151);
            this.cbbFromStockNo.Margin = new System.Windows.Forms.Padding(4, 7, 3, 3);
            this.cbbFromStockNo.Name = "cbbFromStockNo";
            this.cbbFromStockNo.Size = new System.Drawing.Size(315, 55);
            this.cbbFromStockNo.TabIndex = 2;
            // 
            // cbbToStockNo
            // 
            this.cbbToStockNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbToStockNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbToStockNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbToStockNo.DropDownHeight = 250;
            this.cbbToStockNo.Font = new System.Drawing.Font("宋体", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbToStockNo.FormattingEnabled = true;
            this.cbbToStockNo.IntegralHeight = false;
            this.cbbToStockNo.Location = new System.Drawing.Point(4, 223);
            this.cbbToStockNo.Margin = new System.Windows.Forms.Padding(4, 7, 3, 3);
            this.cbbToStockNo.Name = "cbbToStockNo";
            this.cbbToStockNo.Size = new System.Drawing.Size(315, 55);
            this.cbbToStockNo.TabIndex = 3;
            // 
            // lblMatNo
            // 
            this.lblMatNo.AutoSize = true;
            this.lblMatNo.BackColor = System.Drawing.Color.White;
            this.lblMatNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatNo.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMatNo.ForeColor = System.Drawing.Color.White;
            this.lblMatNo.Location = new System.Drawing.Point(257, 371);
            this.lblMatNo.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lblMatNo.Name = "lblMatNo";
            this.lblMatNo.Size = new System.Drawing.Size(327, 73);
            this.lblMatNo.TabIndex = 10;
            this.lblMatNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.White;
            this.lblWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeight.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(257, 445);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(327, 73);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutdia
            // 
            this.lblOutdia.AutoSize = true;
            this.lblOutdia.BackColor = System.Drawing.Color.White;
            this.lblOutdia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutdia.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOutdia.ForeColor = System.Drawing.Color.White;
            this.lblOutdia.Location = new System.Drawing.Point(257, 519);
            this.lblOutdia.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lblOutdia.Name = "lblOutdia";
            this.lblOutdia.Size = new System.Drawing.Size(327, 73);
            this.lblOutdia.TabIndex = 12;
            this.lblOutdia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.White;
            this.lblWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWidth.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWidth.ForeColor = System.Drawing.Color.White;
            this.lblWidth.Location = new System.Drawing.Point(257, 593);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(327, 73);
            this.lblWidth.TabIndex = 13;
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(578, 74);
            this.label9.TabIndex = 14;
            this.label9.Text = "创建指令画面";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_PopCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PopCreateOrder";
            this.Text = "行车指令生成画面";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbbCraneNo;
        private System.Windows.Forms.ComboBox cbbOrderType;
        private System.Windows.Forms.ComboBox cbbFromStockNo;
        private System.Windows.Forms.ComboBox cbbToStockNo;
        private System.Windows.Forms.Label lblMatNo;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblOutdia;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label9;
    }
}