using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp1.ClassesDonnées;

namespace WindowsFormsApp1.Données
{
    internal class SuppressionDonnées
    {
        private static SuppressionDonnées instance;
        private static ExecutionDonnees executionDonnees;

        private SuppressionDonnées()
        {
            executionDonnees = ExecutionDonnees.GetInstance();
        }

        public static SuppressionDonnées GetInstance()
        {
            if (instance == null)
                instance = new SuppressionDonnées();
            return instance;
        }

        public void SupprimerFaitParti(Personnage personnage )
        {
            string req =
                "DELETE FROM FaitParti " +
                "WHERE " +
                "   idJoueur = @IdJoueur AND " +
                "   idPersonnage = @IdPersonnage ";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@IdJoueur", personnage.GetIdJoueur());
            param.Add("@IdPersonnage", personnage.GetId());

            executionDonnees.RequeteDelete(req, param);
        }

        public void SupprimerPersonnage(Personnage personnage)
        {
            SupprimerFaitParti(personnage);

            string req =
                "DELETE FROM Personnage " +
                "WHERE " +
                "   id = @Id AND " +
                "   idJoueur = @IdJoueur ";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@Id", personnage.GetId());
            param.Add("@IdJoueur", personnage.GetIdJoueur());

            executionDonnees.RequeteInsert(req, param);
        }

        public void SupprimerJoueur(Joueur joueur)
        {
            string req;
            Dictionary<string, object> param = new Dictionary<string, object>();

            //Suppréssion des FaitParti des personnages du joueur

            req =
                "DELETE FROM FaitParti " +
                "WHERE idJoueur = @IdJoueur ";

            param.Clear();
            param.Add("@IdJoueur", joueur.GetId());

            executionDonnees.RequeteDelete(req, param);

            // Suppréssion des Personnages du joueur

            req =
                "DELETE FROM Personnage " +
                "WHERE " +
                "   idJoueur = @IdJoueur ";

            param.Clear();
            param.Add("@IdJoueur", joueur.GetId());

            executionDonnees.RequeteDelete(req, param);

            // Suppréssion du Joueur
            req =
                "DELETE FROM Joueur " +
                "WHERE " +
                "   id = @IdJoueur ";

            param.Clear();
            param.Add("@IdJoueur", joueur.GetId());

            executionDonnees.RequeteDelete(req, param);

        }

        public void SupprimerMonstre(Monstre monstre)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();

            string req =
                "DELETE FROM Monstre " +
                "WHERE id = @Id;";

            param.Add("@Id", monstre.Id);

            executionDonnees.RequeteDelete(req, param);
        }

        public void SupprimerMonstres( List<Monstre> monstres)
        {
            foreach(Monstre monstre in monstres)
            {
                SupprimerMonstre(monstre);
            }
        }

    }
}
