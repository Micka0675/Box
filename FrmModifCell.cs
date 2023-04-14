using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    public partial class FrmModifCell : Form
    {
        public FrmModifCell()
        {
            InitializeComponent();
        }

        private void btn_valModif_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            MGarage nouvGarage = new MGarage(txt_numModifCell.Text, txt_adrModifCell.Text);
            DonneesGar.ArrayGarage.Insert(i,nouvGarage);
            this.Close();
            
        }

        private void btn_annulerModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
