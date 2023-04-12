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
    public partial class frmGarage : Form
    {

        public frmGarage()
        {
            InitializeComponent();

            MGarage Dgarages = new MGarage("1", "Impasse du Git");
            DonneesGar.ArrayGarage.Add(Dgarages);
            afficherGarage();
        }

        private void afficherGarage()
        {
            DataTable table1 = new DataTable();
            DataRow row = table1.NewRow();
            Int32 i;

            table1.Columns.Add("N°Garage", typeof(string));
            table1.Columns.Add("Adresse", typeof(string));

            for (i = 0; i < DonneesGar.ArrayGarage.Count; i++)
            {
                row = table1.NewRow();
                row[0] = ((MGarage)(DonneesGar.ArrayGarage[i])).NumGarage;
                row[1] = ((MGarage)(DonneesGar.ArrayGarage[i])).Adresse;

                table1.Rows.Add(row);

            }
            dataGridView1.DataSource = table1;
            dataGridView1.Refresh();
            table1 = null;
            row = null;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGarage_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ajoutGar_Click(object sender, EventArgs e)
        {
            FrmAjoutGarage frmAjoutGarage = new FrmAjoutGarage();
            frmAjoutGarage.ShowDialog();
            afficherGarage();
        }
    }
}
