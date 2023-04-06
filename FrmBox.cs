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
        /// <summary>
        /// zone de text en vue d'afficher les données contenues dans l'objet
        /// </summary>
        private TextBox textBox1;

        public frmBox()
        {
            InitializeComponent();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBox_Load(object sender, EventArgs e)
        {
            /// Au chargement du frmBox, initialisation du component
            InitializeComponent();

            List<Mbox> boxList = new List<Mbox>()
            {
                new Mbox("1", 90, 35),
                new Mbox("2", 50 , 74)
            };
            
            foreach (Mbox box in boxList) 
            {
                textBox1.Text += box.NumBox + Environment.NewLine;

            }
           
            

           
            

        }
    }
}
