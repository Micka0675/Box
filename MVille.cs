using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class MVille
    {
        private static int compteur = 0;
        private int idVille;
        public int GetId()
        {
           return idVille;
        }
        private string nomVille;
        public string NameVille
        {
            get { return nomVille; }
            set { nomVille = value; }
        }
        private string cp;
        public string Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        private List<MGarage> garages = new List<MGarage>();
        public List<MGarage> Garages
        {
            get { return garages; }
            set { garages = value; }

        }

        public MVille(string NomVille, string Cp)
        {
            compteur++;
            this.idVille = compteur;
            nomVille = NomVille;
            this.cp = Cp;          
        }

    }
}
