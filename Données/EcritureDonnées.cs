using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Données
{
    internal class EcritureDonnées
    {
        private static EcritureDonnées instance;
        private ExecutionDonnees executionDonnees;

        private EcritureDonnées()
        {
            executionDonnees = ExecutionDonnees.GetInstance();
        }

        public static EcritureDonnées GetInstance()
        {
            if (instance == null)
                instance = new EcritureDonnées();

            return instance;
        }

        public void InsererJoueur(string nom)
        {
            string req;
            Dictionary<string, object> param = new Dictionary<string, object>();

            req =
                "INSERT INTO Joueur (nom) " +
                "VALUES (@Nom)";
            param.Add("@Nom", nom);

            executionDonnees.RequeteInsert(req, param);
        }

        public void InsererMonstre(string nom, int expérience, double dangerosité, bool personnalisé)
        {
            string req;
            Dictionary<string, object> param = new Dictionary<string, object>();

            req =
                "INSERT INTO Monstre (nom,experience, dangerosite, personnalise)" +
                "VALUES (@Nom,@Experience,@Dangerosite,@Personnalise)";
            param.Add("@Nom", nom);
            param.Add("@Experience", expérience);
            param.Add("@Dangerosite", dangerosité);
            param.Add("@Personnalise", personnalisé);

            executionDonnees.RequeteInsert(req, param);
        }

    }
}
