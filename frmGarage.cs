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

        DataTable dtGarage = new DataTable();
            dtGarage.Columns.Add("ID", typeof(int));
            dtGarage.Columns.Add("N°Garage", typeof(string));
            dtGarage.Columns.Add("Adresse", typeof(string));

        List<MGarage> Dgarages = new List<MGarage>()
        {
           new MGarage(1,"1","Impasse du Git"),
           new MGarage(2,"78", "Rue des chaussettes"),
           new MGarage(3,"45", "Allée là")
        };

            foreach (MGarage garage in Dgarages)
            {
                DataRow row = dtGarage.NewRow();
                row[0] = garage.NumGarage;
                row[1] = garage.Adresse;
                dtGarage.Rows.Add(row);

                txt_garages.Text += "N° garage : " + garage.NumGarage + ", Adresse : " + garage.Adresse + Environment.NewLine;
            }

            dataGridView1.DataSource = dtGarage;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Villes_Click(object sender, EventArgs e)
        {

        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            //InitializeComponent();

            //DataTable dtGarage2 = new DataTable();
            //dtGarage2.Columns.Add("ID", typeof(int));
            //dtGarage2.Columns.Add("N°Garage", typeof(string));
            //dtGarage2.Columns.Add("Adresse", typeof(string));

            //foreach (MGarage garage in Dgarages)
            //{
            //    DataRow row = dtGarage2.NewRow();
            //    row[0] = garage.NumGarage;
            //    row[1] = garage.Adresse;
            //    dtGarage2.Rows.Add(row);

            //    lbl_affNumG.Text = garage.NumGarage;
            //    lbl_affAdr.Text = garage.Adresse;

            //}
        }

        private void btn_gSuiv_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGarage_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
