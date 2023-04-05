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
    public partial class FrmVille : Form
    {
        public List<MVille> lesVilles = new List<MVille>()
        {
        new MVille("Nice"),
        new MVille("Lyon")
        };


        public FrmVille()
        {
            InitializeComponent();
            // Créer une DataTable pour stocker les données des locataires
            DataTable dtVille  = new DataTable();
            dtVille.Columns.Add("Nom", typeof(string));

            // Remplir la DataTable avec les données des locataires
            foreach (MVille ville in lesVilles)
            {
                DataRow row = dtVille.NewRow();
                row["Nom"] = ville.NameVille;
                dtVille.Rows.Add(row);
            }

            // Lier le DataGridView à la DataTable
            dataGridView1.DataSource = dtVille;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
