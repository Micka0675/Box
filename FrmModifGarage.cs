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
    public partial class FrmModifGarage : Form
    {
        public FrmModifGarage()
        {
            InitializeComponent();
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

            dgv_modifGar.DataSource = table1;
            dgv_modifGar.Refresh();
            table1 = null;
            row = null;

        }

        private void dgv_modifGar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
