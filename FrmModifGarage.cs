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
            DataTable table2 = new DataTable();
            DataRow row = table2.NewRow();
            Int32 i;

            table2.Columns.Add("N°Garage", typeof(string));
            table2.Columns.Add("Adresse", typeof(string));

            for (i = 0; i < DonneesGar.ArrayGarage.Count; i++)
            {
                row = table2.NewRow();
                row[0] = ((MGarage)(DonneesGar.ArrayGarage[i])).NumGarage;
                row[1] = ((MGarage)(DonneesGar.ArrayGarage[i])).Adresse;

                table2.Rows.Add(row);

            }

            dgv_modifGar.DataSource = table2;
            dgv_modifGar.Refresh();
            //table1 = null;
            //row = null;

        }

        private void FrmModifGarage_Load(object sender, EventArgs e)
        {

        }

        private void dgv_modifGar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DonneesGar.ArrayGarage.Clear();
            FrmModifCell frmModifCell = new FrmModifCell();
            frmModifCell.ShowDialog();
        }

        private void btn_modifQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
