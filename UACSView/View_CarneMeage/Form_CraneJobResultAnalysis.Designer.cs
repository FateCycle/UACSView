namespace UACSView.View_CarneMeage
{
    partial class Form_CraneJobResultAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Code2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDER_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butIMport = new System.Windows.Forms.Button();
            this.butSelect = new System.Windows.Forms.Button();
            this.combType = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.butWeek = new System.Windows.Forms.Button();
            this.butMonth = new System.Windows.Forms.Button();
            this.butQuarter = new System.Windows.Forms.Button();
            this.butYear = new System.Windows.Forms.Button();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.labDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code2,
            this.ORDER_TYPE,
            this.Zu,
            this.Class,
            this.Mode3,
            this.Num3,
            this.Sum3,
            this.Percent3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.Location = new System.Drawing.Point(-5, 219);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1287, 414);
            this.dataGridView3.TabIndex = 17;
            // 
            // Code2
            // 
            this.Code2.DataPropertyName = "CRANE_NO";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            this.Code2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Code2.HeaderText = "行车号";
            this.Code2.Name = "Code2";
            // 
            // ORDER_TYPE
            // 
            this.ORDER_TYPE.DataPropertyName = "ORDER_TYPE";
            this.ORDER_TYPE.HeaderText = "指令类型";
            this.ORDER_TYPE.Name = "ORDER_TYPE";
            // 
            // Zu
            // 
            this.Zu.DataPropertyName = "Zu";
            this.Zu.HeaderText = "组别";
            this.Zu.Name = "Zu";
            this.Zu.Visible = false;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "班次";
            this.Class.Name = "Class";
            this.Class.Visible = false;
            // 
            // Mode3
            // 
            this.Mode3.DataPropertyName = "Mode3";
            this.Mode3.HeaderText = "模式";
            this.Mode3.Name = "Mode3";
            // 
            // Num3
            // 
            this.Num3.DataPropertyName = "Num3";
            this.Num3.HeaderText = "执行数";
            this.Num3.Name = "Num3";
            // 
            // Sum3
            // 
            this.Sum3.DataPropertyName = "Sum3";
            this.Sum3.HeaderText = "总数";
            this.Sum3.Name = "Sum3";
            // 
            // Percent3
            // 
            this.Percent3.DataPropertyName = "Percent3";
            this.Percent3.HeaderText = "百分比";
            this.Percent3.Name = "Percent3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1276, 87);
            this.panel3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(545, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "行车作业结果分析";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.butIMport);
            this.panel1.Controls.Add(this.butSelect);
            this.panel1.Controls.Add(this.combType);
            this.panel1.Controls.Add(this.labType);
            this.panel1.Controls.Add(this.butWeek);
            this.panel1.Controls.Add(this.butMonth);
            this.panel1.Controls.Add(this.butQuarter);
            this.panel1.Controls.Add(this.butYear);
            this.panel1.Controls.Add(this.dateTimeEnd);
            this.panel1.Controls.Add(this.dateTimeStart);
            this.panel1.Controls.Add(this.labDate);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(-5, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 123);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // butIMport
            // 
            this.butIMport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butIMport.ForeColor = System.Drawing.Color.Black;
            this.butIMport.Location = new System.Drawing.Point(955, 59);
            this.butIMport.Name = "butIMport";
            this.butIMport.Size = new System.Drawing.Size(96, 51);
            this.butIMport.TabIndex = 17;
            this.butIMport.Text = "导出";
            this.butIMport.UseVisualStyleBackColor = false;
            this.butIMport.Click += new System.EventHandler(this.butIMport_Click);
            // 
            // butSelect
            // 
            this.butSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butSelect.ForeColor = System.Drawing.Color.Black;
            this.butSelect.Location = new System.Drawing.Point(1117, 59);
            this.butSelect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(96, 51);
            this.butSelect.TabIndex = 16;
            this.butSelect.Text = "查询";
            this.butSelect.UseVisualStyleBackColor = false;
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // combType
            // 
            this.combType.DisplayMember = "ORDER_TYPE";
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.FormattingEnabled = true;
            this.combType.Location = new System.Drawing.Point(564, 16);
            this.combType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(164, 30);
            this.combType.TabIndex = 14;
            this.combType.ValueMember = "ORDER_TYPE";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(464, 20);
            this.labType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(90, 22);
            this.labType.TabIndex = 10;
            this.labType.Text = "指令类型：";
            // 
            // butWeek
            // 
            this.butWeek.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butWeek.ForeColor = System.Drawing.Color.Black;
            this.butWeek.Location = new System.Drawing.Point(347, 64);
            this.butWeek.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butWeek.Name = "butWeek";
            this.butWeek.Size = new System.Drawing.Size(96, 51);
            this.butWeek.TabIndex = 6;
            this.butWeek.Text = "周数";
            this.butWeek.UseVisualStyleBackColor = false;
            this.butWeek.Visible = false;
            this.butWeek.Click += new System.EventHandler(this.butWeek_Click);
            // 
            // butMonth
            // 
            this.butMonth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butMonth.ForeColor = System.Drawing.Color.Black;
            this.butMonth.Location = new System.Drawing.Point(232, 64);
            this.butMonth.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butMonth.Name = "butMonth";
            this.butMonth.Size = new System.Drawing.Size(96, 51);
            this.butMonth.TabIndex = 5;
            this.butMonth.Text = "月度";
            this.butMonth.UseVisualStyleBackColor = false;
            this.butMonth.Visible = false;
            this.butMonth.Click += new System.EventHandler(this.butMonth_Click);
            // 
            // butQuarter
            // 
            this.butQuarter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butQuarter.ForeColor = System.Drawing.Color.Black;
            this.butQuarter.Location = new System.Drawing.Point(126, 64);
            this.butQuarter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butQuarter.Name = "butQuarter";
            this.butQuarter.Size = new System.Drawing.Size(96, 51);
            this.butQuarter.TabIndex = 4;
            this.butQuarter.Text = "季度";
            this.butQuarter.UseVisualStyleBackColor = false;
            this.butQuarter.Visible = false;
            this.butQuarter.Click += new System.EventHandler(this.butQuarter_Click);
            // 
            // butYear
            // 
            this.butYear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.butYear.ForeColor = System.Drawing.Color.Black;
            this.butYear.Location = new System.Drawing.Point(20, 64);
            this.butYear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.butYear.Name = "butYear";
            this.butYear.Size = new System.Drawing.Size(96, 51);
            this.butYear.TabIndex = 3;
            this.butYear.Text = "年度";
            this.butYear.UseVisualStyleBackColor = false;
            this.butYear.Visible = false;
            this.butYear.Click += new System.EventHandler(this.butYear_Click);
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(298, 18);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(145, 29);
            this.dateTimeEnd.TabIndex = 2;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(85, 17);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(158, 29);
            this.dateTimeStart.TabIndex = 1;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(16, 21);
            this.labDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(58, 22);
            this.labDate.TabIndex = 0;
            this.labDate.Text = "日期：";
            // 
            // Form_CraneJobResultAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel3);
            this.Name = "Form_CraneJobResultAnalysis";
            this.Text = "行车作业结果分析";
            this.Load += new System.EventHandler(this.Form_CraneJobResultAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butIMport;
        private System.Windows.Forms.Button butSelect;
        private System.Windows.Forms.ComboBox combType;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Button butWeek;
        private System.Windows.Forms.Button butMonth;
        private System.Windows.Forms.Button butQuarter;
        private System.Windows.Forms.Button butYear;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label labDate;
    }
}