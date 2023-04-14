namespace Box
{
    partial class FrmAfficherGarageVille
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
            this.dataGridViewGV = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouterG = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblTitreGV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGV
            // 
            this.dataGridViewGV.AllowUserToAddRows = false;
            this.dataGridViewGV.AllowUserToDeleteRows = false;
            this.dataGridViewGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGV.Location = new System.Drawing.Point(128, 121);
            this.dataGridViewGV.Name = "dataGridViewGV";
            this.dataGridViewGV.ReadOnly = true;
            this.dataGridViewGV.Size = new System.Drawing.Size(498, 150);
            this.dataGridViewGV.TabIndex = 0;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(546, 318);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouterG
            // 
            this.btnAjouterG.Location = new System.Drawing.Point(313, 318);
            this.btnAjouterG.Name = "btnAjouterG";
            this.btnAjouterG.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterG.TabIndex = 2;
            this.btnAjouterG.Text = "Ajouter";
            this.btnAjouterG.UseVisualStyleBackColor = true;
            this.btnAjouterG.Click += new System.EventHandler(this.btnAjouterG_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(431, 318);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(684, 395);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblTitreGV
            // 
            this.lblTitreGV.AutoSize = true;
            this.lblTitreGV.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreGV.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitreGV.Location = new System.Drawing.Point(124, 60);
            this.lblTitreGV.Name = "lblTitreGV";
            this.lblTitreGV.Size = new System.Drawing.Size(72, 24);
            this.lblTitreGV.TabIndex = 5;
            this.lblTitreGV.Text = "Zzzz...";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(690, 405);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmAfficherGarageVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitreGV);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouterG);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.dataGridViewGV);
            this.Name = "FrmAfficherGarageVille";
            this.Text = "FrmAfficherGarageVille";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGV;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouterG;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblTitreGV;
    }
}