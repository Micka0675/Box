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
    public partial class FrmAjoutVille : Form
    {
        private FrmVille ajoutMain;
        public FrmAjoutVille(FrmVille AjoutMain)
        {
            InitializeComponent();
            this.ajoutMain= AjoutMain;
       
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MVille nouvVille = new MVille(textBoxAjoutCp.Text, textBoxAjoutV.Text);      
            ajoutMain.AjouterVille(nouvVille);
            textBoxRead.Text = "Nom :" + textBoxAjoutV.Text + Environment.NewLine + "CP : " + textBoxAjoutCp.Text;
        }
    }
}
