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
    public partial class FrmModifierGarageVille : Form
    {
        private MGarage leGarage;
        public FrmModifierGarageVille(MGarage unGarage)
        {
            InitializeComponent();
            this.leGarage = unGarage;
            this.textBoxNumGV.Text = this.leGarage.NumGarage;
            this.textBoxAdrGV.Text = this.leGarage.Adresse;
        } 

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                // modifie les valeurs du garage pointé par la ref temporaire récupérée par la méthode RecupererGarage()
                this.leGarage.NumGarage = this.textBoxNumGV.Text;
                this.leGarage.Adresse = this.textBoxAdrGV.Text;
                // fermer le form
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : \n" + ex.Message, "Modification du garage");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
