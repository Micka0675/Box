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
            this.textBoxAjoutNumG = new System.Windows.Forms.TextBox();
            this.lblNumG = new System.Windows.Forms.Label();
            this.btnValiderG = new System.Windows.Forms.Button();
            this.lblAdresseG = new System.Windows.Forms.Label();
            this.textBoxAjoutAdrG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAjoutNumG
            // 
            this.textBoxAjoutNumG.Location = new System.Drawing.Point(396, 130);
            this.textBoxAjoutNumG.Name = "textBoxAjoutNumG";
            this.textBoxAjoutNumG.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjoutNumG.TabIndex = 1;
            // 
            // lblNumG
            // 
            this.lblNumG.AutoSize = true;
            this.lblNumG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumG.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumG.Location = new System.Drawing.Point(266, 134);
            this.lblNumG.Name = "lblNumG";
            this.lblNumG.Size = new System.Drawing.Size(102, 16);
            this.lblNumG.TabIndex = 3;
            this.lblNumG.Text = "Numéro garage";
            // 
            // btnValiderG
            // 
            this.btnValiderG.Location = new System.Drawing.Point(360, 324);
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
            this.lblAdresseG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseG.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdresseG.Location = new System.Drawing.Point(278, 234);
            this.lblAdresseG.Name = "lblAdresseG";
            this.lblAdresseG.Size = new System.Drawing.Size(58, 16);
            this.lblAdresseG.TabIndex = 5;
            this.lblAdresseG.Text = "Adresse";
            // 
            // textBoxAjoutAdrG
            // 
            this.textBoxAjoutAdrG.Location = new System.Drawing.Point(397, 227);
            this.textBoxAjoutAdrG.Name = "textBoxAjoutAdrG";
            this.textBoxAjoutAdrG.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjoutAdrG.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(255, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "AJOUTER UN GARAGE";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(459, 324);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(643, 384);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmAjoutGarageVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAjoutAdrG);
            this.Controls.Add(this.lblAdresseG);
            this.Controls.Add(this.btnValiderG);
            this.Controls.Add(this.lblNumG);
            this.Controls.Add(this.textBoxAjoutNumG);
            this.Name = "FrmAjoutGarageVille";
            this.Text = "FrmAjoutGarageVille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAjoutNumG;
        private System.Windows.Forms.Label lblNumG;
        private System.Windows.Forms.Button btnValiderG;
        private System.Windows.Forms.Label lblAdresseG;
        private System.Windows.Forms.TextBox textBoxAjoutAdrG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnQuitter;
    }
}