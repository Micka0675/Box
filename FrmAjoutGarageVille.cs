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
    public partial class FrmAjoutGarageVille : Form
    {
        private MVille laVille;
        public FrmAjoutGarageVille(MVille uneVille)
        {
            InitializeComponent();
            this.laVille = uneVille;
        }
        private void btnValiderG_Click(object sender, EventArgs e)
        {
            //  instancie le bon objet MVille et l'ajoute à la collection de sa section  
            if (this.instancie())
            {
                // cas général :
                // si l'instanciation ville et 
                // son ajout au tableau est OK :
                // - fermeture de la boite de dialogue par validation
                this.DialogResult = DialogResult.OK;
            }
        }
        private Boolean instancie()
        {
            // créer une référence d'objet MGarage
            MGarage nouveauGarage;

            try
            {
                // instancie un garage  et lui affecte toutes ses propriétés
                nouveauGarage = new MGarage(textBoxAjoutNumG.Text, textBoxAjoutAdrG.Text);

                // ajoute le nouveau garage dans la liste lesGarages
                this.laVille.AjouterGarage(nouveauGarage);
                return true;

            }
            catch (Exception ex)
            {
                nouveauGarage = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de garage");
                return false;
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
