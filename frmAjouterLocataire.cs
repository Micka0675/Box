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
    public partial class frmAjouterLocataire : Form
    {
        public frmAjouterLocataire()
        {
            InitializeComponent();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            if (this.controle())
            {
                MLocataire nvLoc = new MLocataire();
                nvLoc.IdLoc = Int32.Parse(txt_num.Text);
                nvLoc.NomLoc = txt_nom.Text;
                nvLoc.PrenLoc = txt_nom.Text;
                nvLoc.PrenLoc = txt_prenom.Text;
                nvLoc.Adresse = txt_adresse.Text;
                nvLoc.Ville = txt_ville.Text;
                DonneesV.ArrayLoc.Add(nvLoc);



                DialogResult = DialogResult.OK;
            }
        }

        private Boolean controle()
        {
            Boolean code = true;

            if (!(Outils.EstEntier(this.txt_num.Text))) // appel fonction générique de contrôle
            {
                // la chaîne reçue n'est pas convertible
                code = false;
                MessageBox.Show("Le numéro locataire saisi n'est pas un entier valide !!!", "ERREUR", MessageBoxButtons.OK);
            }
            return code;

        }
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
