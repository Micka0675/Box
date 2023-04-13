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
        private List<Mbox> listCustom;
        private frmAjoutBox frmAjoutBox;
        private Mbox leBox;
        private Mbox mbox;
        public frmBox()
        {
            /// Au chargement du frmBox, initialisation des components
            InitializeComponent();
            leBox = new Mbox();
            mbox = new Mbox("acab", 13, 12);
            leBox.boxAdd(mbox);
            this.afficheBox();


            //instanciation de listCustom
            //List<Mbox> listCustom = new List<Mbox>();

            // creation d'une dataTable utilisable depuis le constructeur de Mbox
            //DataTable boxsInfos = new DataTable();


            //mbox = new Mbox("", 50, 20);
            //listCustom.Add(mbox);
            //mbox.passAdd(listCustom,boxsInfos);
            //dataGridView1.DataSource = listCustom;
        }


        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBox_Load(object sender, EventArgs e)
        {   

        }

        //methode event traitant ajout equipe par admin

        private void Ajouter_Click(object sender, EventArgs e)
        {
            frmAjoutBox frmAjoutBox = new frmAjoutBox();
            frmAjoutBox.Show();
        }

        internal void afficheBox()
        {
            dataGridView1.DataSource = leBox.afficheBox();
            dataGridView1.Refresh();
        }
    }
}
