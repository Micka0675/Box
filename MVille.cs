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

        /// <summary>
        /// Liste qui stocke des objets de type MVille
        /// </summary>
        private Dictionary<int, MVille> lesVilles;
        /// <summary>
        /// Table de données permettant la structruration de l'affichage des informations
        /// </summary>
        private DataTable dtVille;

        /// <summary>
        /// Constructeur de la classe MVille
        /// </summary>
        public MVille()
        {
            lesVilles = new Dictionary<int, MVille>();
            dtVille = new DataTable();
            // Création des colonnes de la DataTable
            dtVille.Columns.Add(new DataColumn("ID", typeof(int)));
            dtVille.Columns.Add(new DataColumn("Nom", typeof(string)));
            dtVille.Columns.Add(new DataColumn("CP", typeof(string)));
        }

        /// <summary>
        /// Méthode pour ajouter une ville à la lis lesVilles
        /// </summary>
        /// <param name="uneVille"></param>
        public void AjouterVille(MVille uneVille)
        {

            this.lesVilles.Add(uneVille.GetId(), uneVille);

        }

        /// <summary>
        /// Permet de supprimer une ville en vérifiant si l'int passé en paramètre correspond 
        /// à l'un des Id des éléments MVille de la liste lesVilles
        /// </summary>
        /// <param name="idVilleSuppr"></param>
        public void SupprimerVille(int idVilleSuppr)
        {
            if (this.lesVilles.ContainsKey(idVilleSuppr))
            {
                this.lesVilles.Remove(idVilleSuppr);
            }
            else
            {
                throw new Exception("Erreur : id ville non trouvé dans la collection");
            }
        }

        /// <summary>
        /// Récupère la ville de la liste si un id correspond à celui de la ville sélectionnée en vue d'être modifiée
        /// et retourne l'objet MVille en question
        /// </summary>
        /// <param name="idVilleModif"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public MVille RecupererVille(int idVilleModif)
        {
            //foreach (MVille uneVille in lesVilles)
            //{
            //    ///Vérifie si l'id d'un des éléments de la liste correspond à l'id de la ville passée en paramètre
            //    if (uneVille.GetId() == idVilleModif)
            //    {
            //        return uneVille;
            //    }
            //}
            //// Si la ville recherchée n'a pas été trouvée dans la boucle, génére une exception
            //throw new Exception("Aucune ville pour le numéro " + idVilleModif.ToString());
            MVille uneVille;
            uneVille = this.lesVilles[idVilleModif] as MVille;
            if (uneVille == null)
            {
                throw new Exception("Aucune ville trouvée pour l'id " + idVilleModif);
            }
            else
            {
                return uneVille;
            }

        }

        /// <summary>
        /// Créer et rempli les lignes de la DatagridViiew
        /// </summary>
        /// <returns></returns>
        public DataTable ListerVille()
        {
            DataRow row;
            this.dtVille.Clear();

            // Remplir la DataTable avec les données des villes
            foreach (MVille ville in this.lesVilles.Values)
            {
                row = this.dtVille.NewRow();
                row[0] = ville.GetId();
                row[1] = ville.NameVille;
                row[2] = ville.Cp;

                this.dtVille.Rows.Add(row);
            }
            // retourne la référence à la datatable
            return this.dtVille;
        }

        private List<MGarage> lesGarages = new List<MGarage>();
        //public List<MGarage> LesGarages
        //{
        //    get { return lesGarages; }
        //    set { lesGarages = value; }
        //}

        private DataTable dtGarage;

        public MVille(int IdVille, string NomVille, string Cp)
        {
            this.idVille = IdVille;
            nomVille = NomVille;
            this.cp = Cp;
            lesGarages = new List<MGarage>();
            dtGarage = new DataTable();
            this.dtGarage.Columns.Add(new DataColumn("Nom", typeof(string)));
            this.dtGarage.Columns.Add(new DataColumn("Adresse", typeof(string)));
        }
        public void AjouterGarage(MGarage unGarage)
        {
            this.lesGarages.Add(unGarage);
        }

        public void SupprimerGarage(string nomGarageSuppr)
        {
            bool nomExiste = lesGarages.Any(objet => objet.NumGarage == nomGarageSuppr);
            if (nomExiste)
            {
                lesGarages.RemoveAll(objet => objet.NumGarage == nomGarageSuppr);
            }
        }
        public MGarage RecupererGarage(string nomGarageModif)
        {

            bool nomExiste = lesGarages.Any(objet => objet.NumGarage == nomGarageModif);
        
            if (!nomExiste)
            {
                throw new Exception("Aucune ville trouvée pour l'id " + nomGarageModif);
            }
            else
            {
                return lesGarages.FirstOrDefault();
            }

        }
        //public DataTable ListerGarage()
        //{
        //    this.dtGarage.Clear();
        //    foreach (MGarage unGarage in lesGarages)
        //    {
        //        DataRow row;
        //        row = dtGarage.NewRow();
        //        row[0] = unGarage.NumGarage;
        //        row[1] = unGarage.Adresse;
        //        this.dtGarage.Rows.Add(row);

        //    }
        //    return this.dtGarage;
        //}
        public DataTable ListerGarage()
        {
            if (this.dtGarage == null)
            {
                this.dtGarage = new DataTable();
                this.dtGarage.Columns.Add("Numéro garage", typeof(string));
                this.dtGarage.Columns.Add("Adresse", typeof(string));
            }
            else
            {
                this.dtGarage.Clear();
            }
            foreach (MGarage unGarage in lesGarages)
            {
                DataRow row = this.dtGarage.NewRow();
                row[0] = unGarage.NumGarage;
                row[1] = unGarage.Adresse;
                this.dtGarage.Rows.Add(row);
            }
            return this.dtGarage;
        }

    }
}
