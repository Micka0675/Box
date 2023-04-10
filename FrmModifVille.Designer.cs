namespace Box
{
    partial class FrmModifVille
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
            this.lblNomVille = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblTitreModif = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomVille
            // 
            this.lblNomVille.AutoSize = true;
            this.lblNomVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomVille.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNomVille.Location = new System.Drawing.Point(245, 137);
            this.lblNomVille.Name = "lblNomVille";
            this.lblNomVille.Size = new System.Drawing.Size(134, 16);
            this.lblNomVille.TabIndex = 0;
            this.lblNomVille.Text = "Nouvelle désignation";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCp.Location = new System.Drawing.Point(246, 229);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(136, 16);
            this.lblCp.TabIndex = 1;
            this.lblCp.Text = "Nouveau code postal";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(392, 134);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxCp
            // 
            this.textBoxCp.Location = new System.Drawing.Point(392, 225);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(100, 20);
            this.textBoxCp.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValider.Location = new System.Drawing.Point(417, 313);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblTitreModif
            // 
            this.lblTitreModif.AutoSize = true;
            this.lblTitreModif.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreModif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitreModif.Location = new System.Drawing.Point(246, 61);
            this.lblTitreModif.Name = "lblTitreModif";
            this.lblTitreModif.Size = new System.Drawing.Size(177, 24);
            this.lblTitreModif.TabIndex = 6;
            this.lblTitreModif.Text = "MODIFIER LA VILLE";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnuler.Location = new System.Drawing.Point(320, 313);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmModifVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitreModif);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textBoxCp);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.lblNomVille);
            this.Name = "FrmModifVille";
            this.Text = "FrmModifVille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomVille;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblTitreModif;
        private System.Windows.Forms.Button btnAnnuler;
    }
}