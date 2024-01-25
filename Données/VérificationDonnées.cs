using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class VérificationDonnées
    {
        public static bool VérificationDonnéesJoueur(string nom)
        {
            bool paramsOk = true;

            // Vérification si le nom n'est pas vide
            if (nom == "")
            {
                string msg = "Le nom ne doit pas être vide";
                MessageBox.Show(msg, "Ajout Joueur", MessageBoxButtons.OK);

                paramsOk = false;
            }           

            // Vérification si le nom existe déjà
            if (paramsOk)
            {
                ExecutionDonnees données = ExecutionDonnees.GetInstance();
                SqlDataReader reader;

                string req =
                    "SELECT * " +
                    "FROM Joueur " +
                    "WHERE nom = @Nom";

                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("@Nom", nom);
                reader = données.RequeteReader(req, param);

                if (reader.Read())
                {
                    string msg = "Un joueur de même nom exite déjà, voulez vous l'ajouter quand même ?";
                    if (MessageBox.Show(msg, "Ajouter Joueur", MessageBoxButtons.YesNo) == DialogResult.No)
                        paramsOk = false;

                }

                reader.Close();

            }

            return paramsOk;

        }

        public static bool VérificationDonnéesJoueurAvecException(string nom,Joueur joueurException)
        {
            ExecutionDonnees données = ExecutionDonnees.GetInstance();
            SqlDataReader reader;

            bool paramsOk = true;

            // Vérification si le nom n'est pas vide
            if (nom == "")
            {
                string msg = "Le nom ne doit pas être vide";
                MessageBox.Show(msg, "Ajout Joueur", MessageBoxButtons.OK);

                paramsOk = false;
            }

            // Vérification si le nom existe déjà
            if (paramsOk)
            {
                string req =
                    "SELECT * " +
                    "FROM Joueur " +
                    "WHERE " +
                    "   nom = @Nom AND " +
                    "   id <> @IdException ";

                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("@Nom", nom);
                param.Add("@IdException", joueurException.GetId());
                reader = données.RequeteReader(req, param);

                if (reader.Read())
                {
                    string msg = "Un joueur de même nom exite déjà, voulez vous l'ajouter quand même ?";
                    if (MessageBox.Show(msg, "Ajouter Joueur", MessageBoxButtons.YesNo) == DialogResult.No)
                        paramsOk = false;

                }

                reader.Close();

            }

            return paramsOk;

        }


        public static bool VérificationDonnéesMonstre(string nom, string dangerosité, string expérience)
        {
            bool paramsOk = true;

            int experienceOut;
            float dangerositeOut;

            if (nom == "")
            {
                MessageBox.Show("Le nom ne doit pas être vide");
                paramsOk = false;
            }

            if (!int.TryParse(expérience, out experienceOut) && paramsOk)
            {
                MessageBox.Show("L'experience doit être un nombre entier");
                paramsOk = false;
            }

            if (!float.TryParse(dangerosité, out dangerositeOut ) && paramsOk)
            {
                MessageBox.Show("La dangerosité doit être un nombre réel");
                paramsOk = false;
            }

            if (paramsOk)
            {
                ExecutionDonnees données = ExecutionDonnees.GetInstance();
                SqlDataReader reader;

                string req =
                    "SELECT * " +
                    "FROM Monstre " +
                    "WHERE nom = @Nom";

                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("@Nom", nom);
                reader = données.RequeteReader(req, param);

                if (reader.Read())
                {
                    string msg = "Un monstre de même nom exite déjà, voulez vous l'ajouter quand même ?";
                    if (MessageBox.Show(msg, "Ajouter Joueur", MessageBoxButtons.YesNo) == DialogResult.No)
                        paramsOk = false;

                }

                reader.Close();
            }

            return paramsOk;
        }

        public static bool VérificationDonnéesMonstreAvecException(string nom, string dangerosité, string expérience, Monstre monstreException)
        {
            bool paramsOk = true;

            int experienceOut;
            double dangerositeOut;

            if (nom == "")
            {
                MessageBox.Show("Le nom ne doit pas être vide");
                paramsOk = false;
            }

            if (!double.TryParse(dangerosité, out dangerositeOut) && paramsOk)
            {
                MessageBox.Show("La dangerosité doit être un nombre réel");
                paramsOk = false;
            }

            if (!int.TryParse(expérience, out experienceOut) && paramsOk)
            {
                MessageBox.Show("L'experience doit être un nombre entier");
                paramsOk = false;
            }

            if (paramsOk)
            {
                ExecutionDonnees données = ExecutionDonnees.GetInstance();
                SqlDataReader reader;

                string req =
                    "SELECT * " +
                    "FROM Monstre " +
                    "WHERE " +
                    "   nom = @Nom AND " +
                    "   id <> @IdMonstre";

                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("@Nom", nom);
                param.Add("@IdMonstre", monstreException.Id);
                reader = données.RequeteReader(req, param);

                if (reader.Read())
                {
                    string msg = "Un monstre de même nom exite déjà, voulez vous l'ajouter quand même ?";
                    if (MessageBox.Show(msg, "Ajouter Joueur", MessageBoxButtons.YesNo) == DialogResult.No)
                        paramsOk = false;

                }

                reader.Close();
            }

            return paramsOk;
        }

        public static bool VérificationDonnéesPersonnage(string nom, string expérience)
        {
            bool paramsOk = true;

            // Vérification si le nom n'est pas vide
            if (nom == "")
            {
                string msg = "Le nom ne doit pas être vide";
                MessageBox.Show(msg, "Ajout Personnage", MessageBoxButtons.OK);

                paramsOk = false;
            }

            // Vérification si l'expérience n'est pas vide
            if (expérience == "")
            {
                string msg = "L'expérience ne doit pas être vide";
                MessageBox.Show(msg, "Ajout Personnage", MessageBoxButtons.OK);

                paramsOk = false;
            }

            // Vérification si le nom existe déjà
            if (paramsOk)
            {
                ExecutionDonnees données = ExecutionDonnees.GetInstance();
                SqlDataReader reader;

                string req =
                    "SELECT * " +
                    "FROM Personnage " +
                    "WHERE nom = @Nom";

                Dictionary<string, object> param = new Dictionary<string, object>();
                param.Add("@Nom", nom);
                reader = données.RequeteReader(req, param);

                if (reader.Read())
                {
                    string msg = "Un personnage de même nom exite déjà, voulez vous l'ajouter quand même ?";
                    if (MessageBox.Show(msg, "Ajouter Joueur", MessageBoxButtons.YesNo) == DialogResult.No)
                        paramsOk = false;

                }



                reader.Close();

            }



            return paramsOk;

        }

    }
}
