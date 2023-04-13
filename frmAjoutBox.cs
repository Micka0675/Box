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
        //private List <Mbox> listCustom;
        //private DataTable boxInfos;
        private frmBox frmBox;
        private Mbox mbox;
        public frmAjoutBox()
        {
           InitializeComponent();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            string numBox = textNumBox.Text;
            int loyerMontant = Decimal.ToInt32(loyer.Value);
            int chargesMontant = Decimal.ToInt32(charges.Value);

            // instanciation de mbox,boxinfos et lisCustom
            
            mbox = new Mbox();
            //boxInfos = new DataTable();
            //listCustom = new List<Mbox>()
            //{
            //    new Mbox(numBox, loyerMontant, chargesMontant)
            //};
            mbox = new Mbox(numBox, loyerMontant, chargesMontant);
            mbox.boxAdd(mbox);
            //unBox.passAdd(listCustom);
            //DataTable boxInfos;

            this.Close();
            
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
