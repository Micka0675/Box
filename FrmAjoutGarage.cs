using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    public partial class FrmAjoutGarage : Form
    {
        public FrmAjoutGarage()
        {
            InitializeComponent();
        }

        private void btn_ajoutValid_Click(object sender, EventArgs e)
        {
            MGarage nouvGarage = new MGarage(txt_ajoutNum.Text, txt_ajoutAdr.Text);
            DonneesGar.ArrayGarage.Add(nouvGarage);
            this.Close(); 
        }

        private void btn_ajoutAnnul_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
