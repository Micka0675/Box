﻿namespace Box
{
    partial class FrmModifGarage
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
            this.dgv_modifGar = new System.Windows.Forms.DataGridView();
            this.btn_modifQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifGar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_modifGar
            // 
            this.dgv_modifGar.AllowUserToAddRows = false;
            this.dgv_modifGar.AllowUserToDeleteRows = false;
            this.dgv_modifGar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modifGar.Location = new System.Drawing.Point(307, 61);
            this.dgv_modifGar.Name = "dgv_modifGar";
            this.dgv_modifGar.ReadOnly = true;
            this.dgv_modifGar.Size = new System.Drawing.Size(423, 330);
            this.dgv_modifGar.TabIndex = 0;
            this.dgv_modifGar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modifGar_CellClick);
            // 
            // btn_modifQuit
            // 
            this.btn_modifQuit.Location = new System.Drawing.Point(688, 425);
            this.btn_modifQuit.Name = "btn_modifQuit";
            this.btn_modifQuit.Size = new System.Drawing.Size(106, 43);
            this.btn_modifQuit.TabIndex = 1;
            this.btn_modifQuit.Text = "QUITTER";
            this.btn_modifQuit.UseVisualStyleBackColor = true;
            this.btn_modifQuit.Click += new System.EventHandler(this.btn_modifQuit_Click);
            // 
            // FrmModifGarage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 480);
            this.Controls.Add(this.btn_modifQuit);
            this.Controls.Add(this.dgv_modifGar);
            this.Name = "FrmModifGarage";
            this.Text = "FrmModifGarage";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifGar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_modifGar;
        private System.Windows.Forms.Button btn_modifQuit;
    }
}