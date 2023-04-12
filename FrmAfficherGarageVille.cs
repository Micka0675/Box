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
    public partial class FrmAfficherGarageVille : Form
    {
        private MVille laVille;

        /// <summary>
        /// Constructeur pour le formulaire FrmVille
        /// </summary>
        public FrmAfficherGarageVille()
        {
            InitializeComponent();
            VilleDonnees villeDonnee = new VilleDonnees();
            this.laVille = new MVille("Nice", "06000");
            villeDonnee.AjouterVille(this.laVille);

            MGarage unGarage;
            unGarage = new MGarage(1, "N°1", "48 chemin de la Boustifaille");
            this.laVille.AjouterGarage(unGarage);
            this.AfficheGarage();

        }

        /// <summary>
        /// Méthode mettant à jour la dataGridView
        /// </summary>
        public void AfficheGarage()
        {
            this.dataGridViewGV.DataSource = laVille.ListerGarage();
            this.dataGridViewGV.Refresh();
            this.btnSupprimer.Enabled = (this.dataGridViewGV == null ? false : true);
        }

        private void btnAjouterG_Click(object sender, EventArgs e)
        {
            FrmAjoutGarageVille ajouterGV = new FrmAjoutGarageVille(this.laVille);
            if (ajouterGV.ShowDialog() == DialogResult.OK)
            {
                // régénère l'affichage du dataGridView 
                AfficheGarage();
            }
        }
        ///// <summary>
        ///// Supprime l'entrée dans la liste lesVilles correspondant à la ligne sélectionnée et regénère l'affichage de la dataGridView
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnSupprimer_Click(object sender, EventArgs e)
        //{
        //    if (this.dataGridViewGV.CurrentRow != null)
        //    {
        //        string nom;
        //        int cle;
        //        cle = (int)this.dataGridViewGV.CurrentRow.Cells[0].Value;
        //        nom = (string)this.dataGridViewGV.CurrentRow.Cells[1].Value;
        //        // demander confirmation de la suppression
        //        // NB: messagebox retourne une valeur exploitable !
        //        if (MessageBox.Show("Voulez-vous supprimer la ville : " + nom.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //        {
        //            this.laVille.SupprimerGarage(cle);
        //            // réaffiche la datagridview
        //            afficheVilles();
        //        }
        //    }
        //}

        ///// <summary>
        /////  Modifie l'entrée dans la liste lesVilles correspondant à la ligne sélectionnée et regénère l'affichage de la dataGridView
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnModifier_Click(object sender, EventArgs e)
        //{
        //    MVille laVille;
        //    int laCle;
        //    laCle = (int)this.dataGridViewVille.CurrentRow.Cells[0].Value;
        //    laVille = this.villeDonnees.RecupererVille(laCle);

        //    FrmModifVille frmModif = new FrmModifVille(laVille);
        //    frmModif.Text = laVille.ToString();
        //    frmModif.ShowDialog();
        //    this.afficheVilles();
        //}

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
