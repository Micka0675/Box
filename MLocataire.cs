using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class MLocataire
    {
        private int idLoc;
        private string nomLoc;
        private string prenLoc;
        private string adresse;
        private MVille ville;

        public int IdLoc
        {
            get { return idLoc; }
            set { idLoc = value; }
        }
        public string NomLoc
        {
            get { return nomLoc; }
            set { nomLoc = value; }
        }
        public string PrenLoc
        {
            get { return prenLoc; }
            set { prenLoc = value; }
        }
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public MVille Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        public MLocataire(string consNomLoc, string consPrenLoc)
        {
            this.nomLoc = consNomLoc;
            this.nomLoc = consPrenLoc;
        }
        public MLocataire(string consNomLoc, string consPrenLoc, string adresse)
        {
            this.nomLoc = consNomLoc;
            this.nomLoc = consPrenLoc;
            this.adresse = adresse;
        }
    }
}
