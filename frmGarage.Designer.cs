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
            this.btn_ajoutGar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(12, 399);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(106, 39);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "QUITTER";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ajoutGar
            // 
            this.btn_ajoutGar.Location = new System.Drawing.Point(12, 12);
            this.btn_ajoutGar.Name = "btn_ajoutGar";
            this.btn_ajoutGar.Size = new System.Drawing.Size(106, 47);
            this.btn_ajoutGar.TabIndex = 2;
            this.btn_ajoutGar.Text = "Ajouter un garage";
            this.btn_ajoutGar.UseVisualStyleBackColor = true;
            this.btn_ajoutGar.Click += new System.EventHandler(this.btn_ajoutGar_Click);
            // 
            // frmGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ajoutGar);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmGarage";
            this.Text = "frmGarage";
            this.Load += new System.EventHandler(this.frmGarage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_ajoutGar;
    }
}