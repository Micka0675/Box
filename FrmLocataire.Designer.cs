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
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.grdLocataire = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdLocataire)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(599, 383);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(100, 37);
            this.btn_quitter.TabIndex = 1;
            this.btn_quitter.Text = "QUITTER";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(448, 383);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(100, 37);
            this.btn_ajouter.TabIndex = 2;
            this.btn_ajouter.Text = "AJOUTER";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // grdLocataire
            // 
            this.grdLocataire.AllowUserToAddRows = false;
            this.grdLocataire.AllowUserToDeleteRows = false;
            this.grdLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLocataire.Location = new System.Drawing.Point(64, 64);
            this.grdLocataire.Name = "grdLocataire";
            this.grdLocataire.ReadOnly = true;
            this.grdLocataire.RowHeadersWidth = 51;
            this.grdLocataire.RowTemplate.Height = 24;
            this.grdLocataire.Size = new System.Drawing.Size(738, 278);
            this.grdLocataire.TabIndex = 3;
            this.grdLocataire.DoubleClick += new System.EventHandler(this.grdLocataire_DoubleClick);
            // 
            // frmLocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 480);
            this.Controls.Add(this.grdLocataire);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_quitter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLocataire";
            this.Text = "Locataire";
            ((System.ComponentModel.ISupportInitialize)(this.grdLocataire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DataGridView grdLocataire;
    }
}