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
    /// <summary>
    ///  Classe enfant de la classe native Form. Paramètre la composition du formulaire d'ajout et ses events
    /// </summary>
    public partial class FrmAjoutVille : Form
    {
        private static int compteur = 1;
        private MVille laVille;
        public FrmAjoutVille(MVille uneVille)
        {
            InitializeComponent();   
            this.laVille = uneVille;
        }

        private void btnValider_Click(object sender, EventArgs e)
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
            // créer une référence d'objet MVille
            MVille nouvelleVille;
            compteur++;

            try
            {
                // instancie une ville et lui affecte toutes ses propriétés
                nouvelleVille = new MVille(compteur, textBoxAjoutV.Text, textBoxAjoutCp.Text);

                // ajoute la nouvelle ville dans la liste lesVilles
                this.laVille.AjouterVille(nouvelleVille);
                return true;

            }
            catch (Exception ex)
            {
                nouvelleVille = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;
            }

        }

        private void btnAnnulerAjout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }

}
