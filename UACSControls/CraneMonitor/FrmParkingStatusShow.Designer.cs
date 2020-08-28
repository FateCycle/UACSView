namespace UACSControls
{
    partial class FrmParkingStatusShow
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
            this.btn_CarneArrive = new System.Windows.Forms.Button();
            this.btn_craneleave = new System.Windows.Forms.Button();
            this.btn_TREATMENT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CarneArrive
            // 
            this.btn_CarneArrive.Location = new System.Drawing.Point(25, 50);
            this.btn_CarneArrive.Name = "btn_CarneArrive";
            this.btn_CarneArrive.Size = new System.Drawing.Size(75, 48);
            this.btn_CarneArrive.TabIndex = 0;
            this.btn_CarneArrive.Text = "车到";
            this.btn_CarneArrive.UseVisualStyleBackColor = true;
            this.btn_CarneArrive.Click += new System.EventHandler(this.btn_CarneArrive_Click);
            // 
            // btn_craneleave
            // 
            this.btn_craneleave.Location = new System.Drawing.Point(157, 50);
            this.btn_craneleave.Name = "btn_craneleave";
            this.btn_craneleave.Size = new System.Drawing.Size(75, 48);
            this.btn_craneleave.TabIndex = 1;
            this.btn_craneleave.Text = "车离";
            this.btn_craneleave.UseVisualStyleBackColor = true;
            this.btn_craneleave.Click += new System.EventHandler(this.btn_craneleave_Click);
            // 
            // btn_TREATMENT
            // 
            this.btn_TREATMENT.Location = new System.Drawing.Point(304, 50);
            this.btn_TREATMENT.Name = "btn_TREATMENT";
            this.btn_TREATMENT.Size = new System.Drawing.Size(75, 48);
            this.btn_TREATMENT.TabIndex = 2;
            this.btn_TREATMENT.Text = "激光扫描";
            this.btn_TREATMENT.UseVisualStyleBackColor = true;
            this.btn_TREATMENT.Click += new System.EventHandler(this.btn_TREATMENT_Click);
            // 
            // FrmParkingStatusShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(419, 279);
            this.Controls.Add(this.btn_TREATMENT);
            this.Controls.Add(this.btn_craneleave);
            this.Controls.Add(this.btn_CarneArrive);
            this.MaximizeBox = false;
            this.Name = "FrmParkingStatusShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "火车操作页面";
            this.Load += new System.EventHandler(this.FrmParkingStatusShow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CarneArrive;
        private System.Windows.Forms.Button btn_craneleave;
        private System.Windows.Forms.Button btn_TREATMENT;
    }
}