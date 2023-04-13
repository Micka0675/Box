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
    /// Classe enfant de la classe native Form. Paramètre la composition du formulaire de modification et ses events
    /// </summary>
    public partial class FrmModifVille : Form
    {
        private MVille laVille;
        public FrmModifVille(MVille uneVille)
        {
            InitializeComponent();
            this.laVille = uneVille;
            this.textBoxNom.Text = this.laVille.NameVille;
            this.textBoxCp.Text = this.laVille.Cp;
        }

        /// <summary>
        /// Méthode permettant de confirmer la modification d'une entrée ville
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                // modifier les valeurs de la ville pointé par la ref temporaire récupérée par la méthode RecupererVille()
                // (sauf id non modifiable et incrémenté)
                this.laVille.NameVille = this.textBoxNom.Text;
                this.laVille.Cp = this.textBoxCp.Text;
                // fermer le form
                this.DialogResult = DialogResult.OK;        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : \n" + ex.Message, "Modification de la ville");

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
