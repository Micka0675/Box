using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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
            new MVille("69000", "Lyon")
        };


        public FrmVille()
        {
            InitializeComponent();
            // Créer une DataTable pour stocker les données des villes
            DataTable dtVille  = new DataTable();
            dtVille.Columns.Add("CP", typeof(string));
            dtVille.Columns.Add("Nom", typeof(string));

            // Remplir la DataTable avec les données des villes
            foreach (MVille ville in lesVilles)
            {
                DataRow row = dtVille.NewRow();
                row[0] = ville.Cp;
                // affecter l'autre colonne 
                row[1] = ville.NameVille;
                // ajouter la ligne à la datatable
                dtVille.Rows.Add(row);
            }

            // Lier le DataGridView à la DataTable
            dataGridView1.DataSource = dtVille;

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
