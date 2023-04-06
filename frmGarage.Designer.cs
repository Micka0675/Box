namespace Box
{
    partial class frmGarage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_quit = new System.Windows.Forms.Button();
            this.txt_garages = new System.Windows.Forms.TextBox();
            this.lbl_garages = new System.Windows.Forms.Label();
            this.lbl_numG = new System.Windows.Forms.Label();
            this.lbl_adr = new System.Windows.Forms.Label();
            this.lbl_affNumG = new System.Windows.Forms.Label();
            this.lbl_affAdr = new System.Windows.Forms.Label();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.btn_gSuiv = new System.Windows.Forms.Button();
            this.btn_gPrec = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_GarNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 120);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(682, 399);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(106, 39);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "QUITTER";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_garages
            // 
            this.txt_garages.Location = new System.Drawing.Point(459, 64);
            this.txt_garages.Multiline = true;
            this.txt_garages.Name = "txt_garages";
            this.txt_garages.Size = new System.Drawing.Size(241, 68);
            this.txt_garages.TabIndex = 2;
            this.txt_garages.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_garages
            // 
            this.lbl_garages.AutoSize = true;
            this.lbl_garages.Location = new System.Drawing.Point(395, 71);
            this.lbl_garages.Name = "lbl_garages";
            this.lbl_garages.Size = new System.Drawing.Size(47, 13);
            this.lbl_garages.TabIndex = 4;
            this.lbl_garages.Text = "Garages";
            this.lbl_garages.Click += new System.EventHandler(this.Villes_Click);
            // 
            // lbl_numG
            // 
            this.lbl_numG.AutoSize = true;
            this.lbl_numG.Location = new System.Drawing.Point(12, 245);
            this.lbl_numG.Name = "lbl_numG";
            this.lbl_numG.Size = new System.Drawing.Size(63, 13);
            this.lbl_numG.TabIndex = 5;
            this.lbl_numG.Text = "N° Garage :";
            // 
            // lbl_adr
            // 
            this.lbl_adr.AutoSize = true;
            this.lbl_adr.Location = new System.Drawing.Point(12, 277);
            this.lbl_adr.Name = "lbl_adr";
            this.lbl_adr.Size = new System.Drawing.Size(51, 13);
            this.lbl_adr.TabIndex = 6;
            this.lbl_adr.Text = "Adresse :";
            // 
            // lbl_affNumG
            // 
            this.lbl_affNumG.AutoSize = true;
            this.lbl_affNumG.Location = new System.Drawing.Point(120, 245);
            this.lbl_affNumG.Name = "lbl_affNumG";
            this.lbl_affNumG.Size = new System.Drawing.Size(0, 13);
            this.lbl_affNumG.TabIndex = 8;
            // 
            // lbl_affAdr
            // 
            this.lbl_affAdr.AutoSize = true;
            this.lbl_affAdr.Location = new System.Drawing.Point(120, 277);
            this.lbl_affAdr.Name = "lbl_affAdr";
            this.lbl_affAdr.Size = new System.Drawing.Size(0, 13);
            this.lbl_affAdr.TabIndex = 9;
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(12, 371);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(87, 35);
            this.btn_afficher.TabIndex = 11;
            this.btn_afficher.Text = "Afficher garage";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.btn_afficher_Click);
            // 
            // btn_gSuiv
            // 
            this.btn_gSuiv.Location = new System.Drawing.Point(123, 371);
            this.btn_gSuiv.Name = "btn_gSuiv";
            this.btn_gSuiv.Size = new System.Drawing.Size(87, 35);
            this.btn_gSuiv.TabIndex = 12;
            this.btn_gSuiv.Text = "Garage suivant";
            this.btn_gSuiv.UseVisualStyleBackColor = true;
            this.btn_gSuiv.Click += new System.EventHandler(this.btn_gSuiv_Click);
            // 
            // btn_gPrec
            // 
            this.btn_gPrec.Location = new System.Drawing.Point(228, 371);
            this.btn_gPrec.Name = "btn_gPrec";
            this.btn_gPrec.Size = new System.Drawing.Size(87, 35);
            this.btn_gPrec.TabIndex = 13;
            this.btn_gPrec.Text = "Garage precedent";
            this.btn_gPrec.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_GarNum
            // 
            this.lbl_GarNum.AutoSize = true;
            this.lbl_GarNum.Location = new System.Drawing.Point(12, 194);
            this.lbl_GarNum.Name = "lbl_GarNum";
            this.lbl_GarNum.Size = new System.Drawing.Size(51, 13);
            this.lbl_GarNum.TabIndex = 15;
            this.lbl_GarNum.Text = "Garage : ";
            this.lbl_GarNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_GarNum);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_gPrec);
            this.Controls.Add(this.btn_gSuiv);
            this.Controls.Add(this.btn_afficher);
            this.Controls.Add(this.lbl_affAdr);
            this.Controls.Add(this.lbl_affNumG);
            this.Controls.Add(this.lbl_adr);
            this.Controls.Add(this.lbl_numG);
            this.Controls.Add(this.lbl_garages);
            this.Controls.Add(this.txt_garages);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGarage";
            this.Text = "frmGarage";
            this.Load += new System.EventHandler(this.frmGarage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox txt_garages;
        private System.Windows.Forms.Label lbl_garages;
        private System.Windows.Forms.Label lbl_numG;
        private System.Windows.Forms.Label lbl_adr;
        private System.Windows.Forms.Label lbl_affNumG;
        private System.Windows.Forms.Label lbl_affAdr;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.Button btn_gSuiv;
        private System.Windows.Forms.Button btn_gPrec;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_GarNum;
    }
}