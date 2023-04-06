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
        public List<MVille> lesVilles = new List<MVille>()
        {
            new MVille("06000", "Nice"),
            new MVille("69000", "Lyon"),
            new MVille("78000", "Versailles")
        };

        //public List<string> fafAchieviements = new List<string>()
        //{
        //    "statue commémorant l’Algérie Française, à la mémoire de Roger Degueldre",
        //    "inauguration d'une Boutique Nationaliste par Alexandre Gabriac (exclu du FN pour un salut nazi)"

        //};


        public FrmVille()
        {
            InitializeComponent();
            // Créer une DataTable pour stocker les données des villes
            DataTable dtVille  = new DataTable();
            dtVille.Columns.Add("CP", typeof(string));
            dtVille.Columns.Add("Nom", typeof(string));

            //Assignation d'une valeur de départ à la propriété Text de l'élément TextBox afin de l'afficher
            textboxVilles.Text = "Top 3 des villes de fachos:" + Environment.NewLine + Environment.NewLine;

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

                //Ajoute chaque élément au contenu du TextBox en utilisant l'opérateur "+=" pour concaténer les éléments. 'Environment.NewLine' permet un retour à la ligne.
                textboxVilles.Text += "-" + ville.NameVille + Environment.NewLine;
            }

            // Lier le DataGridView à la DataTable
            dataGridView1.DataSource = dtVille;

            
        }
        public void AjouterVille(MVille ville)
        {
            if (!lesVilles.Contains(ville))
            {
                lesVilles.Add(ville);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            FrmAjoutVille ajouterVille = new FrmAjoutVille(this);
            ajouterVille.ShowDialog();
        }
        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Créer par erreur en cliquant dans une cellule, à supprimer proprement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
