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
    /// Classe enfant de la classe native Form. Paramètre la composition du formulaire de gestion des garages par villes et ses events
    /// </summary>
    public partial class FrmAfficherGarageVille : Form
    {
        private MVille laVille;
        /// <summary>
        /// Constructeur pour le formulaire FrmAfficherGarageVille
        /// </summary>
        public FrmAfficherGarageVille(MVille uneVille)
        {
            InitializeComponent();
            DonneesV.desVilles = new MVille();
            this.laVille = new MVille();
            this.laVille.AjouterVille(uneVille);
            DonneesV.desVilles.AjouterVille(this.laVille);

            MGarage unGarage;
            unGarage = new MGarage("N°1", "48 chemin de la Boustifaille");
            this.laVille.AjouterGarage(unGarage);
            this.lblTitreGV.Text = uneVille.NameVille.ToUpper();
            this.AfficheGarage();

        }

        public void AfficheGarage()
        {
            DataTable dtCheck = laVille.ListerGarage();
            if (dtCheck.Rows.Count > 0)
            {
                this.dataGridViewGV.DataSource = dtCheck;
                this.dataGridViewGV.Refresh();
                this.btnSupprimer.Enabled = (this.dataGridViewGV == null ? false : true);
            }
            else
            {
                MessageBox.Show("Aucun garage n'est associé à cette ville");
            }
}

        private void btnAjouterG_Click(object sender, EventArgs e)
        {
            int cle;
            cle = (int)this.dataGridViewGV.CurrentRow.Cells[0].Value;

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
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewGV.CurrentRow != null)
            {
                string nom;
                nom = (string)this.dataGridViewGV.CurrentRow.Cells[0].Value;
                // demander confirmation de la suppression
                // NB: messagebox retourne une valeur exploitable !
                if (MessageBox.Show("Voulez-vous supprimer le garage : " + nom.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.laVille.SupprimerGarage(nom);
                    // réaffiche la datagridview
                    AfficheGarage();
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
            MGarage unGarage;
            if (this.dataGridViewGV.CurrentRow != null)
            {
                string nom; ;
                nom = (string)this.dataGridViewGV.CurrentRow.Cells[0].Value;
                unGarage = this.laVille.RecupererGarage(nom);

                FrmModifierGarageVille frmModif = new FrmModifierGarageVille(unGarage);
                frmModif.Text = unGarage.ToString();
                frmModif.ShowDialog();
                this.AfficheGarage();
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
