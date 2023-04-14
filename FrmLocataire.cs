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
    public partial class frmLocataire : Form
    {
        public frmLocataire()
        {
            InitializeComponent();
            this.afficheLocataires();


        }
        private void afficheLocataires()
        {
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            Int32 i;

            dt.Columns.Add(new DataColumn("Numéro ", System.Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Nom ", System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Prénom ", System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Adresse ", System.Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("Ville ", System.Type.GetType("System.String")));


            for (i = 0; i < DonneesV.ArrayLoc.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = ((MLocataire)(DonneesV.ArrayLoc[i])).IdLoc;
                dr[1] = ((MLocataire)(DonneesV.ArrayLoc[i])).NomLoc;
                dr[2] = ((MLocataire)(DonneesV.ArrayLoc[i])).PrenLoc;
                dr[3] = ((MLocataire)(DonneesV.ArrayLoc[i])).Adresse;
                dr[4] = ((MLocataire)(DonneesV.ArrayLoc[i])).Ville;

                dt.Rows.Add(dr);

            }

            grdLocataire.DataSource = dt;
            grdLocataire.Refresh();
            dt = null;
            dr = null;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            
        }

       

        private void grdLocataire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 iLoc;
            iLoc = grdLocataire.CurrentRow.Index;

            MLocataire leLocataire = DonneesV.ArrayLoc[iLoc] as MLocataire;

            frmVisuLocataires frmvisu = new frmVisuLocataires(leLocataire);
            frmvisu.ShowDialog();
            this.afficheLocataires();

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            frmAjouterLocataire frmajloc = new frmAjouterLocataire();
            if (frmajloc.ShowDialog() == DialogResult.OK)
            {
                afficheLocataires();
            }

        }
    }
}
