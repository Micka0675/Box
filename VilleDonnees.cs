using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    /// <summary>
    /// Gère les données qui seront utilisées dans les formulaires relatifs aux villes
    /// </summary>
    public class VilleDonnees
    {
        /// <summary>
        /// Liste qui stocke des objets de type MVille
        /// </summary>
        private List<MVille> lesVilles;
        /// <summary>
        /// Table de données permettant la structruration de l'affichage des informations
        /// </summary>
        private DataTable dtVille;

        /// <summary>
        /// Constructeur de la classe VilleDonnees
        /// </summary>
        public VilleDonnees()
        {
            lesVilles = new List<MVille>();
            dtVille = new DataTable();
            // Création des colonnes de la DataTable
            dtVille.Columns.Add("ID", typeof(int));        
            dtVille.Columns.Add("Nom", typeof(string));
            dtVille.Columns.Add("CP", typeof(string));
        }

        /// <summary>
        /// Méthode pour ajouter une ville à la lis lesVilles
        /// </summary>
        /// <param name="uneVille"></param>
        public void AjouterVille(MVille uneVille)
        {
            if (!lesVilles.Contains(uneVille))
            {
                this.lesVilles.Add(uneVille);
            }
        }

        /// <summary>
        /// Permet de supprimer une ville en vérifiant si l'int passé en paramètre correspond 
        /// à l'un des Id des éléments MVille de la liste lesVilles
        /// </summary>
        /// <param name="idVilleSuppr"></param>
        public void SupprimerVille(int idVilleSuppr)
        {
            /// Vérifier si un objet a un ID égal à la valeur passée en paramètre
            bool idExiste = lesVilles.Any(objet => objet.GetId() == idVilleSuppr);
            if (idExiste)
            {
                lesVilles.RemoveAll(objet => objet.GetId() == idVilleSuppr);
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
            foreach (MVille uneVille in lesVilles)
            {
                ///Vérifie si l'id d'un des éléments de la liste correspond à l'id de la ville passée en paramètre
                if (uneVille.GetId() == idVilleModif)
                {
                    return uneVille;
                }
            }
            // Si la ville recherchée n'a pas été trouvée dans la boucle, génére une exception
            throw new Exception("Aucune ville pour le numéro " + idVilleModif.ToString());
         
        }

        /// <summary>
        /// Créer et rempli les lignes de la DatagridViiew
        /// </summary>
        /// <returns></returns>
        public DataTable ListerVille()
        {
            dtVille.Clear();
            // Remplir la DataTable avec les données des villes
            foreach (MVille ville in lesVilles)
            {
                DataRow row = dtVille.NewRow();
                row[0] = ville.GetId();
                row[1] = ville.NameVille;
                row[2] = ville.Cp;       
                // ajouter la ligne à la datatable
                dtVille.Rows.Add(row);
            }
            // retourne la référence à la datatable
            return this.dtVille;
        }
    }
}
