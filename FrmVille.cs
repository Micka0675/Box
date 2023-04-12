using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    /// <summary>
    /// Classe enfant de la classe native Form. Paramètre la composition du formulaire de gestion des villes et ses events
    /// </summary>
    public partial class FrmVille : Form
    {
       
         private MVille uneVille;

        /// <summary>
        /// Constructeur pour le formulaire FrmVille
        /// </summary>
        public FrmVille()
        {
            InitializeComponent();

            MVille uneVille = new MVille(1, "Nice", "06000");
            this.uneVille = new MVille();
            this.uneVille.AjouterVille(uneVille);
            this.afficheVilles();

        }

        /// <summary>
        /// Méthode mettant à jour la dataGridView
        /// </summary>
        public void afficheVilles()
        {
            this.dataGridViewVille.DataSource = uneVille.ListerVille();
            this.dataGridViewVille.Refresh();

            this.btnSupprimer.Enabled = (this.dataGridViewVille.CurrentRow == null ? false : true);

        }

        /// <summary>
        /// Permet de créer un formulaire d'ajout pour la liste lesVilles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjoutVille ajouterVille = new FrmAjoutVille(this.uneVille);
            if (ajouterVille.ShowDialog() == DialogResult.OK)
            {
                // régénère l'affichage du dataGridView 
                afficheVilles();
            }
        }

        /// <summary>
        /// Supprime l'entrée dans la liste lesVilles correspondant à la ligne sélectionnée et regénère l'affichage de la dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewVille.CurrentRow != null)
            {
                string nom;
                int cle; 
                cle = (int)this.dataGridViewVille.CurrentRow.Cells[0].Value;
                nom = (string)this.dataGridViewVille.CurrentRow.Cells[1].Value;
                // demander confirmation de la suppression
                // NB: messagebox retourne une valeur exploitable !
                if (MessageBox.Show("Voulez-vous supprimer la ville : " + nom.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.uneVille.SupprimerVille(cle);
                    // réaffiche la datagridview
                    afficheVilles();
                }
            }
        }

        /// <summary>
        ///  Modifie l'entrée dans la liste lesVilles correspondant à la ligne sélectionnée et regénère l'affichage de la dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            MVille laVille;
            int laCle;
            laCle = (int)this.dataGridViewVille.CurrentRow.Cells[0].Value;
            laVille = this.uneVille.RecupererVille(laCle);

            FrmModifVille frmModif = new FrmModifVille(laVille);
            frmModif.Text = laVille.ToString();
            frmModif.ShowDialog();
            this.afficheVilles();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGarageVille_Click(object sender, EventArgs e)
        {
            FrmAfficherGarageVille afficherGarageVille = new FrmAfficherGarageVille();
            afficherGarageVille.ShowDialog();
        }
    }
}
