namespace UACSView.View_CraneMonitor
{
    partial class Form2
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
            this.c1EditorToolStripObjects1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects();
            this.c1EditorToolStripMain1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain();
            this.SuspendLayout();
            // 
            // c1EditorToolStripObjects1
            // 
            this.c1EditorToolStripObjects1.Editor = null;
            this.c1EditorToolStripObjects1.Location = new System.Drawing.Point(0, 0);
            this.c1EditorToolStripObjects1.Name = "c1EditorToolStripObjects1";
            this.c1EditorToolStripObjects1.Size = new System.Drawing.Size(800, 25);
            this.c1EditorToolStripObjects1.TabIndex = 1;
            this.c1EditorToolStripObjects1.Text = "c1EditorToolStripObjects1";
            // 
            // c1EditorToolStripMain1
            // 
            this.c1EditorToolStripMain1.Editor = null;
            this.c1EditorToolStripMain1.Location = new System.Drawing.Point(0, 25);
            this.c1EditorToolStripMain1.Name = "c1EditorToolStripMain1";
            this.c1EditorToolStripMain1.Size = new System.Drawing.Size(800, 25);
            this.c1EditorToolStripMain1.TabIndex = 2;
            this.c1EditorToolStripMain1.Text = "c1EditorToolStripMain1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1EditorToolStripMain1);
            this.Controls.Add(this.c1EditorToolStripObjects1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects c1EditorToolStripObjects1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain c1EditorToolStripMain1;
    }
}