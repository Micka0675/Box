namespace Box
{
    partial class frmLocataire
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
            this.btn_quitter = new System.Windows.Forms.Button();
            this.grdLocataire = new System.Windows.Forms.DataGridView();
            this.btn_valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocataire)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(670, 398);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 1;
            this.btn_quitter.Text = "QUITTER";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // grdLocataire
            // 
            this.grdLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLocataire.Location = new System.Drawing.Point(79, 66);
            this.grdLocataire.Name = "grdLocataire";
            this.grdLocataire.Size = new System.Drawing.Size(547, 208);
            this.grdLocataire.TabIndex = 2;
            this.grdLocataire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLocataire_CellContentClick);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(536, 297);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(90, 23);
            this.btn_valider.TabIndex = 3;
            this.btn_valider.Text = "Ajouter";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // frmLocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.grdLocataire);
            this.Controls.Add(this.btn_quitter);
            this.Name = "frmLocataire";
            this.Text = "Locataire";
            ((System.ComponentModel.ISupportInitialize)(this.grdLocataire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.DataGridView grdLocataire;
        private System.Windows.Forms.Button btn_valider;
    }
}