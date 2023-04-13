namespace Box
{
    partial class FrmVille
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
            this.dataGridViewVille = new System.Windows.Forms.DataGridView();
            this.Quitter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnGarageVille = new System.Windows.Forms.Button();
            this.lblTitreAffichVille = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVille)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVille
            // 
            this.dataGridViewVille.AllowUserToAddRows = false;
            this.dataGridViewVille.AllowUserToDeleteRows = false;
            this.dataGridViewVille.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVille.Location = new System.Drawing.Point(177, 137);
            this.dataGridViewVille.Name = "dataGridViewVille";
            this.dataGridViewVille.ReadOnly = true;
            this.dataGridViewVille.Size = new System.Drawing.Size(470, 150);
            this.dataGridViewVille.TabIndex = 0;
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.SystemColors.Control;
            this.Quitter.Location = new System.Drawing.Point(658, 381);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 1;
            this.Quitter.Text = "QUITTER";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(75, 160);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.Control;
            this.btnModifier.Location = new System.Drawing.Point(75, 209);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.Control;
            this.btnSupprimer.Location = new System.Drawing.Point(75, 262);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnGarageVille
            // 
            this.btnGarageVille.BackColor = System.Drawing.SystemColors.Control;
            this.btnGarageVille.Location = new System.Drawing.Point(307, 321);
            this.btnGarageVille.Name = "btnGarageVille";
            this.btnGarageVille.Size = new System.Drawing.Size(167, 23);
            this.btnGarageVille.TabIndex = 8;
            this.btnGarageVille.Text = "Afficher la liste des garages";
            this.btnGarageVille.UseVisualStyleBackColor = false;
            this.btnGarageVille.Click += new System.EventHandler(this.btnGarageVille_Click);
            // 
            // lblTitreAffichVille
            // 
            this.lblTitreAffichVille.AutoSize = true;
            this.lblTitreAffichVille.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAffichVille.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitreAffichVille.Location = new System.Drawing.Point(174, 72);
            this.lblTitreAffichVille.Name = "lblTitreAffichVille";
            this.lblTitreAffichVille.Size = new System.Drawing.Size(215, 24);
            this.lblTitreAffichVille.TabIndex = 9;
            this.lblTitreAffichVille.Text = "AFFICHAGE DES VILLES";
            // 
            // FrmVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitreAffichVille);
            this.Controls.Add(this.btnGarageVille);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.dataGridViewVille);
            this.Name = "FrmVille";
            this.Text = "FrmAfficherVille";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVille;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnGarageVille;
        private System.Windows.Forms.Label lblTitreAffichVille;
    }
}