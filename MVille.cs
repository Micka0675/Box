using System;
using System.Collections.Generic;
using System.Data;
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

        private List<MGarage> lesGarages = new List<MGarage>();
        public List<MGarage> LesGarages
        {
            get { return lesGarages; }
            set { lesGarages = value; }
        }

        private DataTable dtGarage;

        public MVille(string NomVille, string Cp)
        {
            compteur++;
            this.idVille = compteur;
            nomVille = NomVille;
            this.cp = Cp;
            lesGarages = new List<MGarage>();
            dtGarage = new DataTable();
            this.dtGarage.Columns.Add(new DataColumn("ID", typeof(int)));
            this.dtGarage.Columns.Add(new DataColumn("Nom", typeof(string)));
            this.dtGarage.Columns.Add(new DataColumn("Adresse", typeof(string)));
        }
        public void AjouterGarage(MGarage unGarage)
        {
            this.lesGarages.Add(unGarage);
        }

        public void SupprimerGarage(int idGarageSuppr)
        {
            bool idExiste = lesGarages.Any(objet => objet.IdGarage == idGarageSuppr);
            if (idExiste)
            {
                lesGarages.RemoveAll(objet => objet.IdGarage == idGarageSuppr);
            }
        }

        public DataTable ListerGarage()
        {
            this.dtGarage.Clear();
            foreach(MGarage unGarage in lesGarages)
            {
                DataRow row;
                row = dtGarage.NewRow();
                row[0] = unGarage.IdGarage;
                row[1] = unGarage.NumGarage;
                row[2] = unGarage.Adresse;
                this.dtGarage.Rows.Add(row);

            }
            return this.dtGarage;
        }

    }
}
