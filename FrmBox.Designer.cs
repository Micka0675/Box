namespace Box
{
    partial class frmBox
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
            this.Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(1262, 675);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(111, 46);
            this.Quitter.TabIndex = 0;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // frmBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.Quitter);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBox";
            this.Text = "frmBox";
            this.Load += new System.EventHandler(this.frmBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Quitter;
    }
}