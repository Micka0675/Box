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
        private VilleDonnees villeDonnees;
        public FrmAjoutVille(VilleDonnees uneVilleDonnee)
        {
            InitializeComponent();   
            this.villeDonnees = uneVilleDonnee;
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

            try
            {
                // instancie une ville et lui affecte toutes ses propriétés
                nouvelleVille = new MVille(textBoxAjoutV.Text, textBoxAjoutCp.Text);

                // ajoute la nouvelle ville dans la liste lesVilles
                this.villeDonnees.AjouterVille(nouvelleVille);
                return true;

            }
            catch (Exception ex)
            {
                nouvelleVille = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;
            }

        }
    }

}
