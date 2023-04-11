using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class MLocataire
    {
       
        private Int32 idLoc;
        private string nomLoc;
        private string prenLoc;
        private string adresse;
        private string ville;

        public Int32 IdLoc
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
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

      /*  public MLocataire(Int32 consNumLoc,string consNomLoc, string consPrenLoc, string adresse ,string consVilleLoc)
        {
            this.idLoc = consNumLoc;
            this.nomLoc = consNomLoc;
            this.prenLoc = consPrenLoc;
            this.adresse = adresse;
            this.ville = consVilleLoc;
        }*/

    }
}
