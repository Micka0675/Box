namespace Box
{
    partial class frmAjoutBox
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
            this.numBox = new System.Windows.Forms.Label();
            this.montLoyer = new System.Windows.Forms.Label();
            this.monCharges = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.loyer = new System.Windows.Forms.NumericUpDown();
            this.charges = new System.Windows.Forms.NumericUpDown();
            this.quitter = new System.Windows.Forms.Button();
            this.textNumBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charges)).BeginInit();
            this.SuspendLayout();
            // 
            // numBox
            // 
            this.numBox.AutoSize = true;
            this.numBox.Location = new System.Drawing.Point(262, 128);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(80, 13);
            this.numBox.TabIndex = 0;
            this.numBox.Text = "Numero de Box";
            // 
            // montLoyer
            // 
            this.montLoyer.AutoSize = true;
            this.montLoyer.Location = new System.Drawing.Point(267, 199);
            this.montLoyer.Name = "montLoyer";
            this.montLoyer.Size = new System.Drawing.Size(75, 13);
            this.montLoyer.TabIndex = 1;
            this.montLoyer.Text = "Montant Loyer";
            // 
            // monCharges
            // 
            this.monCharges.AutoSize = true;
            this.monCharges.Location = new System.Drawing.Point(254, 277);
            this.monCharges.Name = "monCharges";
            this.monCharges.Size = new System.Drawing.Size(88, 13);
            this.monCharges.TabIndex = 2;
            this.monCharges.Text = "Montant Charges";
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(338, 339);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(106, 47);
            this.valider.TabIndex = 6;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // loyer
            // 
            this.loyer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.loyer.Location = new System.Drawing.Point(370, 197);
            this.loyer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.loyer.Name = "loyer";
            this.loyer.Size = new System.Drawing.Size(120, 20);
            this.loyer.TabIndex = 7;
            // 
            // charges
            // 
            this.charges.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.charges.Location = new System.Drawing.Point(370, 275);
            this.charges.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.charges.Name = "charges";
            this.charges.Size = new System.Drawing.Size(120, 20);
            this.charges.TabIndex = 8;
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(648, 382);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(104, 33);
            this.quitter.TabIndex = 10;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // textNumBox
            // 
            this.textNumBox.Location = new System.Drawing.Point(370, 125);
            this.textNumBox.Name = "textNumBox";
            this.textNumBox.Size = new System.Drawing.Size(120, 20);
            this.textNumBox.TabIndex = 11;
            // 
            // frmAjoutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textNumBox);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.charges);
            this.Controls.Add(this.loyer);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.monCharges);
            this.Controls.Add(this.montLoyer);
            this.Controls.Add(this.numBox);
            this.Name = "frmAjoutBox";
            this.Text = "ajoutBox";
            ((System.ComponentModel.ISupportInitialize)(this.loyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numBox;
        private System.Windows.Forms.Label montLoyer;
        private System.Windows.Forms.Label monCharges;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.NumericUpDown loyer;
        private System.Windows.Forms.NumericUpDown charges;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.TextBox textNumBox;
    }
}