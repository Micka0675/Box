using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box
    {
        private int idBox;
        public int IdBox
        {
            get { return idBox; }
            set { idBox = value; }
        }

        private string numBox;
        public string NumBox
        {
            get { return numBox; }
            set { numBox = value; }
        }

        private decimal prixLoyer;
        public decimal PrixLoyer
        {
            get { return prixLoyer; }
            set { prixLoyer = value; }
        }
        private decimal charges;
        public decimal Charges
        {
            get { return charges; }
            set { charges = value; }
        }
        private MGarage garage;
        public MGarage Garage
        {
            get { return garage; }
            set { garage = value; }
        }
        private MLocataire locataire;
        public MLocataire Locataire
        {
            get { return locataire; }
            set { locataire = value; }
        }
    }
}
