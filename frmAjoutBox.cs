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
        public frmAjoutBox()
        {
            InitializeComponent();

        }

        private void valider_Click(object sender, EventArgs e)
        {
            string numBox = textNumBox.Text;
            int loyerMontant = Decimal.ToInt32(loyer.Value);
            int chargesMontant = Decimal.ToInt32(charges.Value);

            List<Mbox> listCustom = new List<Mbox>()
            {
                new Mbox(numBox,loyerMontant,chargesMontant)
            };

            Mbox unBox = new Mbox(numBox, loyerMontant, chargesMontant);
            unBox.passAdd(listCustom);
            //DataTable boxInfos;
           
            this.Close();
            
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
