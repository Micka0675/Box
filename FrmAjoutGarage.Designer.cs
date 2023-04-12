namespace Box
{
    partial class FrmAjoutGarage
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
            this.lbl_ajoutNum = new System.Windows.Forms.Label();
            this.lbl_ajoutAdr = new System.Windows.Forms.Label();
            this.txt_ajoutNum = new System.Windows.Forms.TextBox();
            this.txt_ajoutAdr = new System.Windows.Forms.TextBox();
            this.btn_ajoutValid = new System.Windows.Forms.Button();
            this.btn_ajoutAnnul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ajoutNum
            // 
            this.lbl_ajoutNum.AutoSize = true;
            this.lbl_ajoutNum.Location = new System.Drawing.Point(234, 147);
            this.lbl_ajoutNum.Name = "lbl_ajoutNum";
            this.lbl_ajoutNum.Size = new System.Drawing.Size(101, 13);
            this.lbl_ajoutNum.TabIndex = 0;
            this.lbl_ajoutNum.Text = "Numéro du garage :";
            // 
            // lbl_ajoutAdr
            // 
            this.lbl_ajoutAdr.AutoSize = true;
            this.lbl_ajoutAdr.Location = new System.Drawing.Point(233, 237);
            this.lbl_ajoutAdr.Name = "lbl_ajoutAdr";
            this.lbl_ajoutAdr.Size = new System.Drawing.Size(102, 13);
            this.lbl_ajoutAdr.TabIndex = 1;
            this.lbl_ajoutAdr.Text = "Adresse du garage :";
            // 
            // txt_ajoutNum
            // 
            this.txt_ajoutNum.Location = new System.Drawing.Point(341, 147);
            this.txt_ajoutNum.Name = "txt_ajoutNum";
            this.txt_ajoutNum.Size = new System.Drawing.Size(100, 20);
            this.txt_ajoutNum.TabIndex = 2;
            // 
            // txt_ajoutAdr
            // 
            this.txt_ajoutAdr.Location = new System.Drawing.Point(341, 237);
            this.txt_ajoutAdr.Name = "txt_ajoutAdr";
            this.txt_ajoutAdr.Size = new System.Drawing.Size(172, 20);
            this.txt_ajoutAdr.TabIndex = 3;
            // 
            // btn_ajoutValid
            // 
            this.btn_ajoutValid.Location = new System.Drawing.Point(341, 323);
            this.btn_ajoutValid.Name = "btn_ajoutValid";
            this.btn_ajoutValid.Size = new System.Drawing.Size(107, 39);
            this.btn_ajoutValid.TabIndex = 4;
            this.btn_ajoutValid.Text = "VALIDER";
            this.btn_ajoutValid.UseVisualStyleBackColor = true;
            this.btn_ajoutValid.Click += new System.EventHandler(this.btn_ajoutValid_Click);
            // 
            // btn_ajoutAnnul
            // 
            this.btn_ajoutAnnul.Location = new System.Drawing.Point(696, 399);
            this.btn_ajoutAnnul.Name = "btn_ajoutAnnul";
            this.btn_ajoutAnnul.Size = new System.Drawing.Size(92, 39);
            this.btn_ajoutAnnul.TabIndex = 5;
            this.btn_ajoutAnnul.Text = "ANNULER";
            this.btn_ajoutAnnul.UseVisualStyleBackColor = true;
            this.btn_ajoutAnnul.Click += new System.EventHandler(this.btn_ajoutAnnul_Click);
            // 
            // FrmAjoutGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ajoutAnnul);
            this.Controls.Add(this.btn_ajoutValid);
            this.Controls.Add(this.txt_ajoutAdr);
            this.Controls.Add(this.txt_ajoutNum);
            this.Controls.Add(this.lbl_ajoutAdr);
            this.Controls.Add(this.lbl_ajoutNum);
            this.Name = "FrmAjoutGarage";
            this.Text = "FrmAjoutGarage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ajoutNum;
        private System.Windows.Forms.Label lbl_ajoutAdr;
        private System.Windows.Forms.TextBox txt_ajoutNum;
        private System.Windows.Forms.TextBox txt_ajoutAdr;
        private System.Windows.Forms.Button btn_ajoutValid;
        private System.Windows.Forms.Button btn_ajoutAnnul;
    }
}