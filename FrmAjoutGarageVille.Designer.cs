namespace Box
{
    partial class FrmAjoutGarageVille
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
            this.textBoxAjoutIdG = new System.Windows.Forms.TextBox();
            this.textBoxAjoutNumG = new System.Windows.Forms.TextBox();
            this.lblIdG = new System.Windows.Forms.Label();
            this.lblNumG = new System.Windows.Forms.Label();
            this.btnValiderG = new System.Windows.Forms.Button();
            this.lblAdresseG = new System.Windows.Forms.Label();
            this.textBoxAjoutAdrG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxAjoutIdG
            // 
            this.textBoxAjoutIdG.Location = new System.Drawing.Point(398, 88);
            this.textBoxAjoutIdG.Name = "textBoxAjoutIdG";
            this.textBoxAjoutIdG.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjoutIdG.TabIndex = 0;
            // 
            // textBoxAjoutNumG
            // 
            this.textBoxAjoutNumG.Location = new System.Drawing.Point(398, 183);
            this.textBoxAjoutNumG.Name = "textBoxAjoutNumG";
            this.textBoxAjoutNumG.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjoutNumG.TabIndex = 1;
            // 
            // lblIdG
            // 
            this.lblIdG.AutoSize = true;
            this.lblIdG.Location = new System.Drawing.Point(274, 91);
            this.lblIdG.Name = "lblIdG";
            this.lblIdG.Size = new System.Drawing.Size(18, 13);
            this.lblIdG.TabIndex = 2;
            this.lblIdG.Text = "ID";
            // 
            // lblNumG
            // 
            this.lblNumG.AutoSize = true;
            this.lblNumG.Location = new System.Drawing.Point(279, 190);
            this.lblNumG.Name = "lblNumG";
            this.lblNumG.Size = new System.Drawing.Size(80, 13);
            this.lblNumG.TabIndex = 3;
            this.lblNumG.Text = "Numéro garage";
            // 
            // btnValiderG
            // 
            this.btnValiderG.Location = new System.Drawing.Point(462, 389);
            this.btnValiderG.Name = "btnValiderG";
            this.btnValiderG.Size = new System.Drawing.Size(75, 23);
            this.btnValiderG.TabIndex = 4;
            this.btnValiderG.Text = "Valider";
            this.btnValiderG.UseVisualStyleBackColor = true;
            this.btnValiderG.Click += new System.EventHandler(this.btnValiderG_Click);
            // 
            // lblAdresseG
            // 
            this.lblAdresseG.AutoSize = true;
            this.lblAdresseG.Location = new System.Drawing.Point(279, 287);
            this.lblAdresseG.Name = "lblAdresseG";
            this.lblAdresseG.Size = new System.Drawing.Size(45, 13);
            this.lblAdresseG.TabIndex = 5;
            this.lblAdresseG.Text = "Adresse";
            // 
            // textBoxAjoutAdrG
            // 
            this.textBoxAjoutAdrG.Location = new System.Drawing.Point(398, 280);
            this.textBoxAjoutAdrG.Name = "textBoxAjoutAdrG";
            this.textBoxAjoutAdrG.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjoutAdrG.TabIndex = 6;
            // 
            // FrmAjoutGarageVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAjoutAdrG);
            this.Controls.Add(this.lblAdresseG);
            this.Controls.Add(this.btnValiderG);
            this.Controls.Add(this.lblNumG);
            this.Controls.Add(this.lblIdG);
            this.Controls.Add(this.textBoxAjoutNumG);
            this.Controls.Add(this.textBoxAjoutIdG);
            this.Name = "FrmAjoutGarageVille";
            this.Text = "FrmAjoutGarageVille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAjoutIdG;
        private System.Windows.Forms.TextBox textBoxAjoutNumG;
        private System.Windows.Forms.Label lblIdG;
        private System.Windows.Forms.Label lblNumG;
        private System.Windows.Forms.Button btnValiderG;
        private System.Windows.Forms.Label lblAdresseG;
        private System.Windows.Forms.TextBox textBoxAjoutAdrG;
    }
}