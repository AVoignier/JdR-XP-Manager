using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.ClassesDonnées
{
    internal class Personnage
    {
        protected int id;
        protected int idJoueur;
        protected string nom;
        protected bool vivant;
        protected int experience;
        protected int niveau;

        protected static List<Niveau> niveaux;


        public Personnage( int id, int idJoueur, string nom, bool vivant, int experience )
        {
            

            this.id = id;
            this.idJoueur = idJoueur;
            this.nom = nom; 
            this.vivant = vivant;
            this.experience = experience;
            this.niveau = CalculNiveau();
        }

        public static void InitialiserListeNiveaux()
        {
            LectureDonnées donnees = LectureDonnées.GetInstance();

            if (niveaux == null)
            {
                niveaux = donnees.GetNiveaux();
            }
        }

        private int CalculNiveau()
        {
            bool cherche = true;

            foreach( Niveau niveauTemp in niveaux)
            {
                if (niveauTemp.GetExperience() > experience)
                {
                    niveau = niveauTemp.GetNiveau() -1;
                    cherche = false;
                }
                
                if(!cherche)
                    break;
            }

            return niveau;
        }

        public int GetId()
        {
            return id;
        }

        public int GetIdJoueur()
        {
            return idJoueur;
        }

        public string GetNom()
        {
            return nom;
        }

        public bool GetVivant()
        {
            return vivant;
        }

        public int GetExperience()
        {
            return experience;
        }

        public int GetNiveau()
        {
            return niveau;
        }

        public List<Niveau> GetListNiveaux()
        {
            return niveaux;
        }

        public int GetExpérienceParNiveau(int niveau)
        {
            if(niveau >= 0 && niveau < niveaux.Count)
            {
                return (niveaux[niveau].GetExperience());
            }

            return 0;
            
        }

        public override string ToString()
        {
            return nom + " Niv : " + niveau + " XP : " + experience;
        }

    }
}
