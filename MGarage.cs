using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class MGarage
    {
        private string numGarage;
        /// <summary>
        /// trouduk
        /// </summary>
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
        private MVille ville;
        public MVille Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public MGarage(string consNumGarage, string consAdresse, MVille consVille)
        { 
            this.numGarage= consNumGarage;
            this.adresse= consAdresse;
            this.ville= consVille;
        }
    }
}
