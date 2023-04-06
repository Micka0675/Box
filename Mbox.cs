using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    internal class Mbox
    {

   

        /// <summary>
        /// Mbox Attributes by Micka
        /// </summary>
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
        }
    }
}
