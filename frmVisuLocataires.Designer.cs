namespace Box
{
    partial class frmVisuLocataires
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
            this.gbx_locataire = new System.Windows.Forms.GroupBox();
            this.txt_villev = new System.Windows.Forms.TextBox();
            this.txt_adressev = new System.Windows.Forms.TextBox();
            this.txt_prenomv = new System.Windows.Forms.TextBox();
            this.txt_nomv = new System.Windows.Forms.TextBox();
            this.txt_numv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_supprime = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.gbx_locataire.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_locataire
            // 
            this.gbx_locataire.Controls.Add(this.txt_villev);
            this.gbx_locataire.Controls.Add(this.txt_adressev);
            this.gbx_locataire.Controls.Add(this.txt_prenomv);
            this.gbx_locataire.Controls.Add(this.txt_nomv);
            this.gbx_locataire.Controls.Add(this.txt_numv);
            this.gbx_locataire.Controls.Add(this.label5);
            this.gbx_locataire.Controls.Add(this.label4);
            this.gbx_locataire.Controls.Add(this.label3);
            this.gbx_locataire.Controls.Add(this.label2);
            this.gbx_locataire.Controls.Add(this.label1);
            this.gbx_locataire.Location = new System.Drawing.Point(35, 32);
            this.gbx_locataire.Name = "gbx_locataire";
            this.gbx_locataire.Size = new System.Drawing.Size(490, 391);
            this.gbx_locataire.TabIndex = 0;
            this.gbx_locataire.TabStop = false;
            this.gbx_locataire.Text = "Locataire";
            // 
            // txt_villev
            // 
            this.txt_villev.Location = new System.Drawing.Point(158, 333);
            this.txt_villev.Name = "txt_villev";
            this.txt_villev.Size = new System.Drawing.Size(282, 22);
            this.txt_villev.TabIndex = 9;
            // 
            // txt_adressev
            // 
            this.txt_adressev.Location = new System.Drawing.Point(158, 266);
            this.txt_adressev.Name = "txt_adressev";
            this.txt_adressev.Size = new System.Drawing.Size(282, 22);
            this.txt_adressev.TabIndex = 8;
            // 
            // txt_prenomv
            // 
            this.txt_prenomv.Location = new System.Drawing.Point(158, 197);
            this.txt_prenomv.Name = "txt_prenomv";
            this.txt_prenomv.Size = new System.Drawing.Size(282, 22);
            this.txt_prenomv.TabIndex = 7;
            // 
            // txt_nomv
            // 
            this.txt_nomv.Location = new System.Drawing.Point(158, 134);
            this.txt_nomv.Name = "txt_nomv";
            this.txt_nomv.Size = new System.Drawing.Size(282, 22);
            this.txt_nomv.TabIndex = 6;
            // 
            // txt_numv
            // 
            this.txt_numv.Location = new System.Drawing.Point(158, 69);
            this.txt_numv.Name = "txt_numv";
            this.txt_numv.ReadOnly = true;
            this.txt_numv.Size = new System.Drawing.Size(282, 22);
            this.txt_numv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ville :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro :";
            // 
            // btn_supprime
            // 
            this.btn_supprime.Location = new System.Drawing.Point(73, 464);
            this.btn_supprime.Name = "btn_supprime";
            this.btn_supprime.Size = new System.Drawing.Size(94, 34);
            this.btn_supprime.TabIndex = 1;
            this.btn_supprime.Text = "Supprimer";
            this.btn_supprime.UseVisualStyleBackColor = true;
            this.btn_supprime.Click += new System.EventHandler(this.btn_supprime_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(193, 464);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(89, 34);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(307, 464);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(93, 34);
            this.btn_annuler.TabIndex = 3;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(426, 464);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(99, 34);
            this.btn_fermer.TabIndex = 4;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // frmVisuLocataires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 535);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_supprime);
            this.Controls.Add(this.gbx_locataire);
            this.Name = "frmVisuLocataires";
            this.Text = "Locataires";
            this.Load += new System.EventHandler(this.frmVisuLocataires_Load);
            this.gbx_locataire.ResumeLayout(false);
            this.gbx_locataire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_locataire;
        private System.Windows.Forms.TextBox txt_villev;
        private System.Windows.Forms.TextBox txt_adressev;
        private System.Windows.Forms.TextBox txt_prenomv;
        private System.Windows.Forms.TextBox txt_nomv;
        private System.Windows.Forms.TextBox txt_numv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_supprime;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_fermer;
    }
}