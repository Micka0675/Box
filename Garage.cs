using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Garage
    {
        private string numGarage;
        public string NumGarage
        {
            get { return numGarage; }
            set { numGarage = value; }
        }
        private List<Box> boxes = new List<Box>();
        public List<Box> Boxes
        {
            get { return boxes; }
            set { boxes = value; }
        }
        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        private Ville ville;
        public Ville Ville
        {
            get { return ville; }
            set { ville = value; }
        }
    }
}
