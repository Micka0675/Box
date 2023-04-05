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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btn_locataire_Click(object sender, EventArgs e)
        {
            frmLocataire frmLo= new frmLocataire();
            frmLo.ShowDialog();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ville_Click(object sender, EventArgs e)
        {
           FrmVille frmAffiche = new FrmVille();
            frmAffiche.ShowDialog();
        }
    }
}
