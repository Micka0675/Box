﻿using System;
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
       
         private MVille laVille;

        /// <summary>
        /// Constructeur pour le formulaire FrmVille
        /// </summary>
        public FrmVille()
        {
            InitializeComponent();

            MVille uneVille = new MVille(1, "Nice", "06000");
            this.laVille = new MVille();
            this.laVille.AjouterVille(uneVille);
            this.AfficheVilles();

        }

        /// <summary>
        /// Méthode mettant à jour la dataGridView
        /// </summary>
        public void AfficheVilles()
        {
            this.dataGridViewVille.DataSource = laVille.ListerVille();
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
            FrmAjoutVille ajouterVille = new FrmAjoutVille(this.laVille);
            if (ajouterVille.ShowDialog() == DialogResult.OK)
            {
                // régénère l'affichage du dataGridView 
                AfficheVilles();
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
                    this.laVille.SupprimerVille(cle);
                    // réaffiche la datagridview
                    AfficheVilles();
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
            MVille uneVille;
            int laCle;
            laCle = (int)this.dataGridViewVille.CurrentRow.Cells[0].Value;
            uneVille = this.laVille.RecupererVille(laCle);

            FrmModifVille frmModif = new FrmModifVille(uneVille);
            frmModif.Text = uneVille.ToString();
            frmModif.ShowDialog();
            this.AfficheVilles();
        }  

        /// <summary>
        /// Affiche un nouveau formulaire permettant de gérer les garages stockés dans chaque ville
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGarageVille_Click(object sender, EventArgs e)
        {
            MVille uneVille;

            int laCle;
            laCle = (int)this.dataGridViewVille.CurrentRow.Cells[0].Value;
            uneVille = this.laVille.RecupererVille(laCle);

            FrmAfficherGarageVille afficherGarageVille = new FrmAfficherGarageVille(uneVille);
            afficherGarageVille.ShowDialog();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
