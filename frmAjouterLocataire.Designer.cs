namespace Box
{
    partial class frmAjouterLocataire
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
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbx_ajouter = new System.Windows.Forms.GroupBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_adresse = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.gbx_ajouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(289, 522);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(116, 31);
            this.btn_ajouter.TabIndex = 0;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(432, 522);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(114, 31);
            this.btn_quitter.TabIndex = 1;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numéro Locataire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom Locataire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenom Locataire :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresse Locataire :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ville  Locataire :";
            // 
            // gbx_ajouter
            // 
            this.gbx_ajouter.Controls.Add(this.txt_ville);
            this.gbx_ajouter.Controls.Add(this.txt_adresse);
            this.gbx_ajouter.Controls.Add(this.txt_prenom);
            this.gbx_ajouter.Controls.Add(this.txt_nom);
            this.gbx_ajouter.Controls.Add(this.txt_num);
            this.gbx_ajouter.Controls.Add(this.label4);
            this.gbx_ajouter.Controls.Add(this.label5);
            this.gbx_ajouter.Controls.Add(this.label1);
            this.gbx_ajouter.Controls.Add(this.label2);
            this.gbx_ajouter.Controls.Add(this.label3);
            this.gbx_ajouter.Location = new System.Drawing.Point(38, 33);
            this.gbx_ajouter.Name = "gbx_ajouter";
            this.gbx_ajouter.Size = new System.Drawing.Size(508, 451);
            this.gbx_ajouter.TabIndex = 7;
            this.gbx_ajouter.TabStop = false;
            this.gbx_ajouter.Text = "Ajouter un locataire";
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(251, 317);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(223, 22);
            this.txt_ville.TabIndex = 11;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Location = new System.Drawing.Point(251, 250);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(223, 22);
            this.txt_adresse.TabIndex = 10;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(251, 179);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(223, 22);
            this.txt_prenom.TabIndex = 9;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(251, 112);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(223, 22);
            this.txt_nom.TabIndex = 8;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(251, 49);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(223, 22);
            this.txt_num.TabIndex = 7;
            // 
            // frmAjouterLocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 626);
            this.Controls.Add(this.gbx_ajouter);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_ajouter);
            this.Name = "frmAjouterLocataire";
            this.Text = "frmAjouterLocataire";
            this.gbx_ajouter.ResumeLayout(false);
            this.gbx_ajouter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbx_ajouter;
        public System.Windows.Forms.TextBox txt_ville;
        public System.Windows.Forms.TextBox txt_adresse;
        public System.Windows.Forms.TextBox txt_prenom;
        public System.Windows.Forms.TextBox txt_nom;
        public System.Windows.Forms.TextBox txt_num;
    }
}