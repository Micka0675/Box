namespace Box
{
    partial class FrmAjoutVille
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
            this.lblVille = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblCp = new System.Windows.Forms.Label();
            this.textBoxAjoutV = new System.Windows.Forms.TextBox();
            this.textBoxAjoutCp = new System.Windows.Forms.TextBox();
            this.lblEntree = new System.Windows.Forms.Label();
            this.btnAnnulerAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVille.Location = new System.Drawing.Point(247, 165);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(82, 16);
            this.lblVille.TabIndex = 0;
            this.lblVille.Text = "Désignation:";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(397, 335);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCp.Location = new System.Drawing.Point(248, 260);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(83, 16);
            this.lblCp.TabIndex = 2;
            this.lblCp.Text = "Code postal:";
            // 
            // textBoxAjoutV
            // 
            this.textBoxAjoutV.Location = new System.Drawing.Point(372, 160);
            this.textBoxAjoutV.Name = "textBoxAjoutV";
            this.textBoxAjoutV.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjoutV.TabIndex = 4;
            // 
            // textBoxAjoutCp
            // 
            this.textBoxAjoutCp.Location = new System.Drawing.Point(372, 254);
            this.textBoxAjoutCp.Name = "textBoxAjoutCp";
            this.textBoxAjoutCp.Size = new System.Drawing.Size(100, 20);
            this.textBoxAjoutCp.TabIndex = 5;
            // 
            // lblEntree
            // 
            this.lblEntree.AutoSize = true;
            this.lblEntree.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEntree.Location = new System.Drawing.Point(239, 76);
            this.lblEntree.Name = "lblEntree";
            this.lblEntree.Size = new System.Drawing.Size(332, 24);
            this.lblEntree.TabIndex = 7;
            this.lblEntree.Text = "ENREGISTRER UNE NOUVELLE VILLE";
            // 
            // btnAnnulerAjout
            // 
            this.btnAnnulerAjout.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnnulerAjout.Location = new System.Drawing.Point(290, 335);
            this.btnAnnulerAjout.Name = "btnAnnulerAjout";
            this.btnAnnulerAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerAjout.TabIndex = 8;
            this.btnAnnulerAjout.Text = "Annuler";
            this.btnAnnulerAjout.UseVisualStyleBackColor = false;
            // 
            // FrmAjoutVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnulerAjout);
            this.Controls.Add(this.lblEntree);
            this.Controls.Add(this.textBoxAjoutCp);
            this.Controls.Add(this.textBoxAjoutV);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblVille);
            this.Name = "FrmAjoutVille";
            this.Text = "AjoutVille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.TextBox textBoxAjoutV;
        private System.Windows.Forms.TextBox textBoxAjoutCp;
        private System.Windows.Forms.Label lblEntree;
        private System.Windows.Forms.Button btnAnnulerAjout;
    }
}