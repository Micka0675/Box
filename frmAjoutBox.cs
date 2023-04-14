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
    public partial class frmAjoutBox : Form
    {
        private Mbox leBox;
        private Mbox mbox;
        private frmBox frmBox1;
        public frmAjoutBox(frmBox frmBox,Mbox leBox)
        {
           InitializeComponent();
            this.frmBox1 = frmBox;
            this.leBox = leBox;
        }

        private void valider_Click(object sender, EventArgs e)
        {
            string numBox = textNumBox.Text;
            int loyerMontant = Decimal.ToInt32(loyer.Value);
            int chargesMontant = Decimal.ToInt32(charges.Value);


            
            mbox = new Mbox();
            mbox = new Mbox(numBox, loyerMontant, chargesMontant);
            leBox.boxAdd(mbox);
            frmBox1.affiche();
            this.Close();
            
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
