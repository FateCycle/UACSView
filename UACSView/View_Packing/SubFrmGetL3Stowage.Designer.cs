namespace UACSView.View_Packing
{
    partial class SubFrmGetL3Stowage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmGetL3Stowage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvStowage = new System.Windows.Forms.DataGridView();
            this.CHECK_COLUMN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SHIP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHIP_SEQ_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAY_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OUTDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WIDTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAN_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAN_TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z_CENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStowage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvStowage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "配载号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 74);
            this.panel2.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(722, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 40;
            this.button2.Text = "取消";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.btnQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuery.BackgroundImage")));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(595, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(103, 38);
            this.btnQuery.TabIndex = 39;
            this.btnQuery.Text = "提交";
            this.btnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvStowage
            // 
            this.dgvStowage.AllowUserToAddRows = false;
            this.dgvStowage.AllowUserToDeleteRows = false;
            this.dgvStowage.AllowUserToOrderColumns = true;
            this.dgvStowage.AllowUserToResizeRows = false;
            this.dgvStowage.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvStowage.ColumnHeadersHeight = 30;
            this.dgvStowage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStowage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHECK_COLUMN,
            this.SHIP_NAME,
            this.SHIP_SEQ_NO,
            this.PICK_NO,
            this.MAT_NO,
            this.STOCK_NO,
            this.BAY_NO,
            this.OUTDIA,
            this.WEIGHT,
            this.WIDTH,
            this.INDIA,
            this.PLAN_NO,
            this.PLAN_TIME,
            this.X_CENTER,
            this.Y_CENTER,
            this.Z_CENTER});
            this.dgvStowage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStowage.Location = new System.Drawing.Point(3, 66);
            this.dgvStowage.Name = "dgvStowage";
            this.dgvStowage.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvStowage.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStowage.RowTemplate.Height = 23;
            this.dgvStowage.Size = new System.Drawing.Size(850, 312);
            this.dgvStowage.TabIndex = 26;
            this.dgvStowage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStowage_CellContentClick_1);
            // 
            // CHECK_COLUMN
            // 
            this.CHECK_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CHECK_COLUMN.DataPropertyName = "CHECK_COLUMN";
            this.CHECK_COLUMN.FalseValue = "0";
            this.CHECK_COLUMN.Frozen = true;
            this.CHECK_COLUMN.HeaderText = "选择";
            this.CHECK_COLUMN.Name = "CHECK_COLUMN";
            this.CHECK_COLUMN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHECK_COLUMN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHECK_COLUMN.TrueValue = "1";
            this.CHECK_COLUMN.Width = 80;
            // 
            // SHIP_NAME
            // 
            this.SHIP_NAME.DataPropertyName = "SHIP_NAME";
            this.SHIP_NAME.HeaderText = "船名";
            this.SHIP_NAME.Name = "SHIP_NAME";
            // 
            // SHIP_SEQ_NO
            // 
            this.SHIP_SEQ_NO.DataPropertyName = "SHIP_SEQ_NO";
            this.SHIP_SEQ_NO.HeaderText = "船批号";
            this.SHIP_SEQ_NO.Name = "SHIP_SEQ_NO";
            this.SHIP_SEQ_NO.Width = 140;
            // 
            // PICK_NO
            // 
            this.PICK_NO.DataPropertyName = "PICK_NO";
            this.PICK_NO.HeaderText = "提单号";
            this.PICK_NO.Name = "PICK_NO";
            this.PICK_NO.ReadOnly = true;
            this.PICK_NO.Width = 140;
            // 
            // MAT_NO
            // 
            this.MAT_NO.DataPropertyName = "MAT_NO";
            this.MAT_NO.HeaderText = "材料号";
            this.MAT_NO.Name = "MAT_NO";
            this.MAT_NO.ReadOnly = true;
            this.MAT_NO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MAT_NO.Width = 150;
            // 
            // STOCK_NO
            // 
            this.STOCK_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.STOCK_NO.DataPropertyName = "STOCK_NO";
            this.STOCK_NO.HeaderText = "库位号";
            this.STOCK_NO.Name = "STOCK_NO";
            this.STOCK_NO.ReadOnly = true;
            this.STOCK_NO.Width = 83;
            // 
            // BAY_NO
            // 
            this.BAY_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BAY_NO.DataPropertyName = "BAY_NO";
            this.BAY_NO.HeaderText = "跨号";
            this.BAY_NO.Name = "BAY_NO";
            this.BAY_NO.ReadOnly = true;
            this.BAY_NO.Width = 67;
            // 
            // OUTDIA
            // 
            this.OUTDIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OUTDIA.DataPropertyName = "OUTDIA";
            this.OUTDIA.HeaderText = "外径";
            this.OUTDIA.Name = "OUTDIA";
            this.OUTDIA.ReadOnly = true;
            this.OUTDIA.Width = 67;
            // 
            // WEIGHT
            // 
            this.WEIGHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WEIGHT.DataPropertyName = "WEIGHT";
            this.WEIGHT.HeaderText = "重量";
            this.WEIGHT.Name = "WEIGHT";
            this.WEIGHT.ReadOnly = true;
            this.WEIGHT.Width = 67;
            // 
            // WIDTH
            // 
            this.WIDTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WIDTH.DataPropertyName = "WIDTH";
            this.WIDTH.HeaderText = "宽度";
            this.WIDTH.Name = "WIDTH";
            this.WIDTH.ReadOnly = true;
            this.WIDTH.Width = 67;
            // 
            // INDIA
            // 
            this.INDIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.INDIA.DataPropertyName = "INDIA";
            this.INDIA.HeaderText = "内径";
            this.INDIA.Name = "INDIA";
            this.INDIA.ReadOnly = true;
            this.INDIA.Width = 67;
            // 
            // PLAN_NO
            // 
            this.PLAN_NO.DataPropertyName = "PLAN_NO";
            this.PLAN_NO.HeaderText = "发货单号";
            this.PLAN_NO.Name = "PLAN_NO";
            this.PLAN_NO.ReadOnly = true;
            this.PLAN_NO.Width = 140;
            // 
            // PLAN_TIME
            // 
            this.PLAN_TIME.DataPropertyName = "PLAN_TIME";
            this.PLAN_TIME.HeaderText = "开始执行日期";
            this.PLAN_TIME.Name = "PLAN_TIME";
            this.PLAN_TIME.Width = 200;
            // 
            // X_CENTER
            // 
            this.X_CENTER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.X_CENTER.DataPropertyName = "X_CENTER";
            this.X_CENTER.HeaderText = "X";
            this.X_CENTER.Name = "X_CENTER";
            this.X_CENTER.ReadOnly = true;
            this.X_CENTER.Width = 45;
            // 
            // Y_CENTER
            // 
            this.Y_CENTER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Y_CENTER.DataPropertyName = "Y_CENTER";
            this.Y_CENTER.HeaderText = "Y";
            this.Y_CENTER.Name = "Y_CENTER";
            this.Y_CENTER.ReadOnly = true;
            this.Y_CENTER.Width = 45;
            // 
            // Z_CENTER
            // 
            this.Z_CENTER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Z_CENTER.DataPropertyName = "Z_CENTER";
            this.Z_CENTER.HeaderText = "Z";
            this.Z_CENTER.Name = "Z_CENTER";
            this.Z_CENTER.ReadOnly = true;
            this.Z_CENTER.Width = 45;
            // 
            // SubFrmGetL3Stowage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SubFrmGetL3Stowage";
            this.Text = "获取配载";
            this.Load += new System.EventHandler(this.SubFrmGetL3Stowage_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStowage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvStowage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHECK_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIP_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHIP_SEQ_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAY_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OUTDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEIGHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WIDTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn INDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAN_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAN_TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_CENTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_CENTER;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z_CENTER;
    }
}