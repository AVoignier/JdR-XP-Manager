using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WindowsFormsApp1.ClassesDonnées;

namespace WindowsFormsApp1
{
    internal class LectureDonnées
    {
        private static LectureDonnées instance;
        private ExecutionDonnees executionDonnees;
        SqlDataReader reader;

        private LectureDonnées()
        {
            executionDonnees = ExecutionDonnees.GetInstance();
        }

        public static LectureDonnées GetInstance()
        {
            if (instance == null)
                instance = new LectureDonnées();
            return instance;
        }

        public List<Equipe> GetEquipes()
        {
            List<Equipe> equipes = new List<Equipe>();

            string req =
                "SELECT * " +
                "FROM Equipe " +
                "ORDER BY nom";
            reader = executionDonnees.RequeteReader(req);

            while (reader.Read())
            {
                equipes.Add(new Equipe( (int)reader["id"], (string)reader["Nom"]));
            }

            reader.Close();

            return equipes;
        }

        public List<Personnage> GetPersonnages(bool pVivant)
        {
            List<Personnage> personnages = new List<Personnage>();

            string req =
                "SELECT *" +
                "FROM Personnage ";
            if (pVivant)
                req +=
                "WHERE vivant = 1 ";

            req += "ORDER BY nom ";

            reader = executionDonnees.RequeteReader(req);

            int id;
            int idJoueur;
            string nom;
            int experience;
            bool vivant;

            while (reader.Read())
            {
                id = (int)reader["id"];
                idJoueur = (int)reader["idJoueur"];
                nom = (string)reader["nom"];
                experience = (int)reader["experience"];
                vivant = (bool)reader["vivant"];
                personnages.Add(new Personnage(id, idJoueur, nom, vivant, experience));
            }

            reader.Close();

            return personnages;
        }

        public List<Personnage> GetPersonnagesParJoueur(Joueur joueur, bool pVivant)
        {
            List<Personnage> personnages = new List<Personnage>();
            string req =
                "SELECT * " +
                "FROM Personnage " +
                "WHERE idJoueur = @IdJoueur ";
            if (pVivant)
                req += "AND vivant = 1 ";

            req +=
                "ORDER BY nom";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@IdJoueur", joueur.GetId());
            reader = executionDonnees.RequeteReader(req, param);

            int id;
            int idJoueur;
            string nom;
            int experience;
            bool vivant;

            while (reader.Read())
            {
                id = (int)reader["id"];
                idJoueur = (int)reader["idJoueur"];
                nom = (string)reader["nom"];
                experience = (int)reader["experience"];
                vivant = (bool)reader["vivant"];
                personnages.Add(new Personnage(id, idJoueur, nom, vivant, experience));
            }

            reader.Close();

            return personnages;

        }

        public List<Personnage> GetPersonnagesParEquipe(Equipe equipe, bool pVivant)
        {
            List<Personnage> personnages = new List<Personnage>();

            string req =
                "SELECT Personnage.id,Personnage.idJoueur,Personnage.nom,Personnage.experience,Personnage.vivant " +
                "FROM FaitParti " +
                "LEFT JOIN Personnage ON " +
                "   Personnage.id = FaitParti.idPersonnage " +
                "WHERE " +
                "   idEquipe = @IdEquipe ";
            if (pVivant)
            {
                req +=
                "   AND vivant = 1 ";
            }
            req += 
                "ORDER BY nom ";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@IdEquipe", equipe.GetId());
            reader = executionDonnees.RequeteReader(req,param);

            int id;
            int idJoueur;
            string nom;
            int experience;
            bool vivant;

            while (reader.Read())
            {
                id = (int)reader["id"];
                idJoueur = (int)reader["idJoueur"];
                nom = (string)reader["nom"];
                experience = (int)reader["experience"];
                vivant = (bool)reader["vivant"];
                personnages.Add(new Personnage(id, idJoueur, nom, vivant, experience));
            }

            reader.Close();

            return personnages;
        }

        public List<Joueur> GetJoueurs()
        {
            List<Joueur> joueurs = new List<Joueur>();

            string req =
                "SELECT * " +
                "FROM Joueur " +
                "ORDER BY nom";

            reader = executionDonnees.RequeteReader(req);

            int id;
            string nom;

            while (reader.Read())
            {
                id = (int)reader["id"];
                nom = (string)reader["nom"];
                joueurs.Add(new Joueur(id, nom));
            }

            reader.Close();

            return joueurs;
        }

        public Joueur GetJoueursDerniereEntrée()
        {
            Joueur joueur;

            string req =
                "SELECT TOP 1 * " +
                "FROM Joueur " +
                "ORDER BY id DESC";

            reader = executionDonnees.RequeteReader(req);

            int id;
            string nom;

            reader.Read();

            id = (int)reader["id"];
            nom = (string)reader["nom"];
            joueur = new Joueur(id, nom);

            reader.Close();

            return joueur;
        }

        public Joueur GetJoueursParPersonnage(Personnage personnage)
        {
            Joueur joueur;

            string req =
                "SELECT * " +
                "FROM Joueur " +
                "WHERE id = @IdJoueur";

            Console.WriteLine(personnage.GetIdJoueur());

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@IdJoueur", personnage.GetIdJoueur());
            reader = executionDonnees.RequeteReader(req, param);

            reader.Read();

            int id = (int)reader["id"];
            string nom = (string)reader["nom"];

            joueur = new Joueur(id,nom);

            reader.Close();

            return joueur;
        }

        public List<Joueur> GetJoueursParEquipe(Equipe equipe)
        {
            List<Joueur> joueurs = new List<Joueur>();

            string req =
                "SELECT DISTINCT Joueur.nom, Joueur.id " +
                "FROM FaitParti " +
                "LEFT JOIN Joueur ON " +
                "   Joueur.id = FaitParti.idJoueur " +
                "WHERE idEquipe = @IdEquipe";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@IdEquipe", equipe.GetId());
            reader = executionDonnees.RequeteReader(req, param);

            int id;
            string nom;

            while (reader.Read())
            {
                id = (int)reader["id"];
                nom = (string)reader["nom"];
                joueurs.Add(new Joueur(id, nom));
            }

            reader.Close();

            return joueurs;
        }

        public Joueur GetJoueur(Personnage personnage)
        {
            string req =
                "SELECT *" +
                "FROM Joueur" +
                "WHERE id = @IdJoueur";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("@IdJoueur", personnage.GetIdJoueur());
            reader = executionDonnees.RequeteReader(req, param);

            reader.Read();
            Joueur joueur = new Joueur((int)reader["id,"], (string)reader["nom"]);
            
            reader.Close();
            return joueur;

        }



        public List<Monstre> GetMonstres()
        {
            List<Monstre> monstres = new List<Monstre>();

            string req =
                "SELECT *" +
                "FROM Monstre " +
                "ORDER BY nom";

            reader = executionDonnees.RequeteReader(req);

            int id;
            string nom;
            int experience;
            double dangerosite;
            bool personnalise;

            while (reader.Read())
            {
                id = (int)reader["id"];
                nom = (string)reader["nom"];
                experience = (int)reader["experience"];
                dangerosite = (double)reader["dangerosite"];
                personnalise = (bool)reader["personnalise"].Equals(1);
                monstres.Add(new Monstre(id, nom,dangerosite,experience,personnalise));
            }

            reader.Close();

            return monstres;
        }

        public void InsererMonstre(Monstre monstre)
        {
            string req = 
                "INSERT INTO Monstre(id, nom, experience, dangerosite, personnalise)" +
                "VALUES (@Nom,@Experience,@Dangerosite,@Personnalise)";

            Dictionary<string, object> param = new Dictionary<string, object>();

            param.Add("@Nom", monstre.Nom);
            param.Add("@Experience", monstre.Experience);
            param.Add("@Dangerosite", monstre.Dangerosite);
            param.Add("@Personnalise", monstre.Personnalise);

            executionDonnees.RequeteInsert(req, param);
        }

        public List<Niveau> GetNiveaux()
        {
            List<Niveau> niveaux = new List<Niveau>();

            string req =
                "SELECT *" +
                "FROM Niveau " +
                "ORDER BY niveau";
            reader = executionDonnees.RequeteReader(req);

            while (reader.Read())
            {
                niveaux.Add(new Niveau((int)reader["niveau"], (int)reader["experience"]));
            }

            reader.Close();

            return niveaux;
        }

    }
}
