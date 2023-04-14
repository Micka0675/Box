namespace Box
{
    partial class FrmModifCell
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
            this.txt_numModifCell = new System.Windows.Forms.TextBox();
            this.txt_adrModifCell = new System.Windows.Forms.TextBox();
            this.btn_valModif = new System.Windows.Forms.Button();
            this.btn_annulerModif = new System.Windows.Forms.Button();
            this.lbl_numModif = new System.Windows.Forms.Label();
            this.lbl_adrModif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_numModifCell
            // 
            this.txt_numModifCell.Location = new System.Drawing.Point(336, 133);
            this.txt_numModifCell.Name = "txt_numModifCell";
            this.txt_numModifCell.Size = new System.Drawing.Size(100, 20);
            this.txt_numModifCell.TabIndex = 0;
            // 
            // txt_adrModifCell
            // 
            this.txt_adrModifCell.Location = new System.Drawing.Point(336, 197);
            this.txt_adrModifCell.Name = "txt_adrModifCell";
            this.txt_adrModifCell.Size = new System.Drawing.Size(171, 20);
            this.txt_adrModifCell.TabIndex = 1;
            // 
            // btn_valModif
            // 
            this.btn_valModif.Location = new System.Drawing.Point(336, 309);
            this.btn_valModif.Name = "btn_valModif";
            this.btn_valModif.Size = new System.Drawing.Size(111, 47);
            this.btn_valModif.TabIndex = 2;
            this.btn_valModif.Text = "VALIDER MODIFICATION";
            this.btn_valModif.UseVisualStyleBackColor = true;
            this.btn_valModif.Click += new System.EventHandler(this.btn_valModif_Click);
            // 
            // btn_annulerModif
            // 
            this.btn_annulerModif.Location = new System.Drawing.Point(678, 391);
            this.btn_annulerModif.Name = "btn_annulerModif";
            this.btn_annulerModif.Size = new System.Drawing.Size(110, 47);
            this.btn_annulerModif.TabIndex = 3;
            this.btn_annulerModif.Text = "ANNULER";
            this.btn_annulerModif.UseVisualStyleBackColor = true;
            this.btn_annulerModif.Click += new System.EventHandler(this.btn_annulerModif_Click);
            // 
            // lbl_numModif
            // 
            this.lbl_numModif.AutoSize = true;
            this.lbl_numModif.Location = new System.Drawing.Point(255, 136);
            this.lbl_numModif.Name = "lbl_numModif";
            this.lbl_numModif.Size = new System.Drawing.Size(44, 13);
            this.lbl_numModif.TabIndex = 4;
            this.lbl_numModif.Text = "Numero";
            // 
            // lbl_adrModif
            // 
            this.lbl_adrModif.AutoSize = true;
            this.lbl_adrModif.Location = new System.Drawing.Point(255, 203);
            this.lbl_adrModif.Name = "lbl_adrModif";
            this.lbl_adrModif.Size = new System.Drawing.Size(45, 13);
            this.lbl_adrModif.TabIndex = 5;
            this.lbl_adrModif.Text = "Adresse";
            // 
            // FrmModifCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_adrModif);
            this.Controls.Add(this.lbl_numModif);
            this.Controls.Add(this.btn_annulerModif);
            this.Controls.Add(this.btn_valModif);
            this.Controls.Add(this.txt_adrModifCell);
            this.Controls.Add(this.txt_numModifCell);
            this.Name = "FrmModifCell";
            this.Text = "FrmModifCell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numModifCell;
        private System.Windows.Forms.TextBox txt_adrModifCell;
        private System.Windows.Forms.Button btn_valModif;
        private System.Windows.Forms.Button btn_annulerModif;
        private System.Windows.Forms.Label lbl_numModif;
        private System.Windows.Forms.Label lbl_adrModif;
    }
}