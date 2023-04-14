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
    public partial class frmVisuLocataires : Form
    {
        private MLocataire leLocataire;
        public frmVisuLocataires(MLocataire unLocataire)
        {
            this.leLocataire = unLocataire;
            InitializeComponent();

        }

        private void frmVisuLocataires_Load(object sender, EventArgs e)
        {
            this.afficheLoc(this.leLocataire);
        }

        private void afficheLoc(MLocataire unLocataire)
        {
            this.txt_numv.Text = unLocataire.IdLoc.ToString();
            this.txt_nomv.Text = unLocataire.NomLoc;
            this.txt_prenomv.Text = unLocataire.PrenLoc;
            this.txt_adressev.Text = unLocataire.Adresse;
            this.txt_villev.Text = unLocataire.Ville;
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            this.leLocataire.NomLoc = this.txt_nomv.Text;
            this.leLocataire.PrenLoc = this.txt_prenomv.Text;
            this.leLocataire.Adresse = this.txt_adressev.Text;
            this.leLocataire.Ville = this.txt_villev.Text;
            this.Close();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.afficheLoc(leLocataire);
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_supprime_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous supprimer définitivement le stagiaire " + leLocataire.NomLoc.Trim() + " - OSIA : " + leLocataire.IdLoc.ToString() + " ?", "confirmer") == DialogResult.OK)
            {
                // supprimer de la collection
                DonneesV.ArrayLoc.Remove(leLocataire);
                // réafficher le datagridview
                this.Close();
            }
        }
    }
}
