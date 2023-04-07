using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    public partial class frmBox : Form
    {
        

        public frmBox()
        {
            /// Au chargement du frmBox, initialisation des components
            InitializeComponent();

            DataTable boxsInfos = new DataTable();
            boxsInfos.Columns.Add("numero box",typeof(string));
            boxsInfos.Columns.Add("loyer", typeof(float));
            boxsInfos.Columns.Add("charges", typeof(float));
            boxsInfos.Columns.Add("total", typeof(float));

            List<Mbox> boxList = new List<Mbox>()
            {
                new Mbox("1", 90, 35),
                new Mbox("2", 50 , 74)
            };

            foreach (Mbox box in boxList)
            {
                textBox1.Text += "Numéro de box:  " + box.NumBox + " Montant du loyer:  " + box.MontantLoyer + " Montant des charges:  " + box.MontantCharges + Environment.NewLine;
                DataRow row = boxsInfos.NewRow();
                row[0] = box.NumBox;
                row[1] = box.MontantLoyer;
                row[2] = box.MontantCharges;
                row[3] = box.MontantCharges + box.MontantLoyer;//faux
                boxsInfos.Rows.Add(row);
            }
            //lier le datagridview aux données
            dataGridView1.DataSource = boxsInfos;
                 
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBox_Load(object sender, EventArgs e)
        {   

        }
    }
}
