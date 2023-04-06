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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Quitter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textboxVilles = new System.Windows.Forms.TextBox();
            this.chkedListBoxFaf = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Quitter
            // 
            this.Quitter.Location = new System.Drawing.Point(671, 377);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 1;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textboxVilles
            // 
            this.textboxVilles.Location = new System.Drawing.Point(57, 107);
            this.textboxVilles.Multiline = true;
            this.textboxVilles.Name = "textboxVilles";
            this.textboxVilles.Size = new System.Drawing.Size(146, 98);
            this.textboxVilles.TabIndex = 3;
            // 
            // chkedListBoxFaf
            // 
            this.chkedListBoxFaf.FormattingEnabled = true;
            this.chkedListBoxFaf.Location = new System.Drawing.Point(67, 243);
            this.chkedListBoxFaf.Name = "chkedListBoxFaf";
            this.chkedListBoxFaf.Size = new System.Drawing.Size(120, 94);
            this.chkedListBoxFaf.TabIndex = 4;
            // 
            // FrmVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkedListBoxFaf);
            this.Controls.Add(this.textboxVilles);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmVille";
            this.Text = "FrmAfficherVille";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textboxVilles;
        private System.Windows.Forms.CheckedListBox chkedListBoxFaf;
    }
}