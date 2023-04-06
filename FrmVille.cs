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
    public partial class FrmVille : Form
    {
        private List<MVille> lesVilles = new List<MVille>();
        DataTable dtVille = new DataTable();


        public FrmVille()
        {
            InitializeComponent();
            lesVilles.Add(new MVille("06000", "Nice"));
            lesVilles.Add(new MVille("69000", "Lyon"));
            lesVilles.Add(new MVille("78000", "Versailles"));

            // Créer une DataTable pour stocker les données des villes

            dtVille.Columns.Add("CP", typeof(string));
            dtVille.Columns.Add("Nom", typeof(string));

            //Assignation d'une valeur de départ à la propriété Text de l'élément TextBox afin de l'afficher
            textboxVilles.Text = "Les plus belles villes de fachos:" + Environment.NewLine + Environment.NewLine;

            MajdtVille();

        }

        /// <summary>
        /// Met à jour la dataGridView
        /// </summary>
        public void MajdtVille()
        {
            dtVille.Clear();
            // Remplir la DataTable et le TextBox avec les données des villes
            foreach (MVille ville in lesVilles)
            {
                DataRow row = dtVille.NewRow();
                row[0] = ville.Cp;
                // affecter l'autre colonne 
                row[1] = ville.NameVille;
                // ajouter la ligne à la datatable
                dtVille.Rows.Add(row);

                if (!textboxVilles.Text.Contains(ville.NameVille))
                {
                    //Ajoute chaque élément au contenu du TextBox en utilisant l'opérateur "+=" pour concaténer les éléments. 'Environment.NewLine' permet un retour à la ligne.
                    textboxVilles.Text += "-" + ville.NameVille + Environment.NewLine;
                }      
            }
            dataGridViewVille.DataSource = dtVille;
        }

        public void AjouterVille(MVille ville)
        {
            if (!lesVilles.Contains(ville))
            {
                lesVilles.Add(ville);
            }
        }

        /// <summary>
        /// Supprime unne ville de la liste lesVilles
        /// </summary>
        /// <param name="ville"></param>
        public void SupprimerVille(MVille ville)
        {
            if (lesVilles.Contains(ville))
            {
                lesVilles.Remove(ville);
            }
        }

        /// <summary>
        /// Permet de créer un formulaire d'ajout pour la liste lesVilles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAjoutVille ajouterVille = new FrmAjoutVille(this);         
            ajouterVille.ShowDialog();
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewVille.SelectedRows.Count > 0)
            {
                DataGridViewRow ligneSelection = dataGridViewVille.SelectedRows[0];
                MVille villeASuppr = ligneSelection.DataBoundItem as MVille;

                // Supprimer la ligne sélectionnée
                dataGridViewVille.Rows.Remove(ligneSelection);
                lesVilles.Remove(villeASuppr);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
          
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
