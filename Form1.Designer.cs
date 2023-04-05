namespace Box
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_locataire = new System.Windows.Forms.Button();
            this.btn_garage = new System.Windows.Forms.Button();
            this.btn_box = new System.Windows.Forms.Button();
            this.btn_ville = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_locataire
            // 
            this.btn_locataire.Location = new System.Drawing.Point(97, 59);
            this.btn_locataire.Name = "btn_locataire";
            this.btn_locataire.Size = new System.Drawing.Size(139, 60);
            this.btn_locataire.TabIndex = 0;
            this.btn_locataire.Text = "LOCATAIRE";
            this.btn_locataire.UseVisualStyleBackColor = true;
            this.btn_locataire.Click += new System.EventHandler(this.btn_locataire_Click);
            // 
            // btn_garage
            // 
            this.btn_garage.Location = new System.Drawing.Point(274, 59);
            this.btn_garage.Name = "btn_garage";
            this.btn_garage.Size = new System.Drawing.Size(139, 60);
            this.btn_garage.TabIndex = 1;
            this.btn_garage.Text = "GARAGE";
            this.btn_garage.UseVisualStyleBackColor = true;
            // 
            // btn_box
            // 
            this.btn_box.Location = new System.Drawing.Point(97, 179);
            this.btn_box.Name = "btn_box";
            this.btn_box.Size = new System.Drawing.Size(139, 60);
            this.btn_box.TabIndex = 2;
            this.btn_box.Text = "BOX";
            this.btn_box.UseVisualStyleBackColor = true;
            this.btn_box.Click += new System.EventHandler(this.btn_box_Click);
            // 
            // btn_ville
            // 
            this.btn_ville.Location = new System.Drawing.Point(274, 179);
            this.btn_ville.Name = "btn_ville";
            this.btn_ville.Size = new System.Drawing.Size(139, 60);
            this.btn_ville.TabIndex = 3;
            this.btn_ville.Text = "VILLE";
            this.btn_ville.UseVisualStyleBackColor = true;
            this.btn_ville.Click += new System.EventHandler(this.btn_ville_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(437, 296);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 4;
            this.btn_quitter.Text = "QUITTER";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_ville);
            this.Controls.Add(this.btn_box);
            this.Controls.Add(this.btn_garage);
            this.Controls.Add(this.btn_locataire);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_locataire;
        private System.Windows.Forms.Button btn_garage;
        private System.Windows.Forms.Button btn_box;
        private System.Windows.Forms.Button btn_ville;
        private System.Windows.Forms.Button btn_quitter;
    }
}

