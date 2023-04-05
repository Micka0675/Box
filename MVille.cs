using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class MVille
    {

        private int idVille;
        public int IdVille
        {
            get { return idVille; }
            set { idVille = value; }
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

        public List<MLocataire> lesLocataires = new List<MLocataire>()
        {
        new MLocataire("Dupont", "Jean"),
        new MLocataire("Martin", "Marie")
        };
        public MVille(string NomVille)
        {
     
            this.nomVille = NomVille;
        }
    }
}
