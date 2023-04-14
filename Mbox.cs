using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box
{
    public class Mbox
    {
        private List <Mbox> listCustom;
        private DataTable boxsInfos;

        private string numBox;

        public string NumBox 
        {
            get { return numBox; } 
            set {  numBox = value; }
        }

        private float montantLoyer;


        public float MontantLoyer
        {
            get { return montantLoyer ;}
            set { montantLoyer = value; }
        }

        private float montantCharges;
        public float MontantCharges
        {
            get { return montantCharges ;}
            set { montantCharges = value; }
        }



        public Mbox(string NumBox, float MontantLoyer, float MontantCharges)
        {
            this.numBox = NumBox;
            this.montantLoyer = MontantLoyer;
            this.montantCharges = MontantCharges;
            listCustom = new List<Mbox>();
            boxsInfos = new DataTable();
            boxsInfos = new DataTable();
        }

        public Mbox()
        {
            listCustom = new List<Mbox>();
            boxsInfos = new DataTable();
            boxsInfos.Columns.Add("numero box", typeof(string));
            boxsInfos.Columns.Add("loyer", typeof(float));
            boxsInfos.Columns.Add("charges", typeof(float));
            boxsInfos.Columns.Add("total", typeof(float));
        }

        internal void boxAdd(Mbox mbox)
        {
            this.listCustom.Add(mbox);
            
        }

        internal DataTable afficheBox() 
        {
            this.boxsInfos.Clear();
            foreach (Mbox box in listCustom)
            {
                DataRow row = boxsInfos.NewRow();
                row[0] = box.NumBox;
                row[1] = box.MontantLoyer;
                row[2] = box.MontantCharges;
                boxsInfos.Rows.Add(row);
            }
            return boxsInfos;
        }
    }
}
