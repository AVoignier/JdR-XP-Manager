using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Données
{
    internal class ModificationDonnées
    {

        private static ModificationDonnées instance;
        private static ExecutionDonnees executionDonnees;

        private  ModificationDonnées()
        {
            executionDonnees = ExecutionDonnees.GetInstance();
        }

        public static ModificationDonnées GetInstance()
        {
            if (instance == null)
                instance = new ModificationDonnées();
            return instance;
        }

        public void ModificationJoueur( Joueur joueurModele, string nouveauNom)
        {
            string req =
                "UPDATE Joueur " +
                "SET nom = @NouveauNom " +
                "WHERE " +
                "   id = @IdJoueur ";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@NouveauNom", nouveauNom);
            param.Add("@IdJoueur", joueurModele.GetId());

            executionDonnees.RequeteUpdate(req, param);
        }

        public void ModificationMonstre( Monstre monstreModele, string nom, double dangerosite, int experience, bool personnalise)
        {
            string req =
                "UPDATE Monstre " +
                "SET " +
                "   nom = @Nom, " +
                "   dangerosite = @Dangerosite, " +
                "   experience = @Experience, " +
                "   personnalise = @Personnalise " +
                "WHERE " +
                "   id = @IdMonstre ";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Nom", nom);
            param.Add("@Dangerosite", dangerosite);
            param.Add("@Experience", experience);
            param.Add("@Personnalise", personnalise);
            param.Add("@IdMonstre", monstreModele.Id);

            executionDonnees.RequeteUpdate(req, param);
        }

    }
}
