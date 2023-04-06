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
    public partial class FrmAjoutVille : Form
    {
       
        public FrmAjoutVille(FrmVille AjoutMain)
        {
            InitializeComponent();   
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MVille nouvVille = new MVille(textBoxAjoutCp.Text, textBoxAjoutV.Text);

            FrmVille ajoutAffichage = new FrmVille();
            ajoutAffichage.AjouterVille(nouvVille);
            ajoutAffichage.MajdtVille();
            ajoutAffichage.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }
    }
}
