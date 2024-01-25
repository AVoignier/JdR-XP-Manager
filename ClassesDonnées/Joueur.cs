using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    internal class Joueur
    {
        static LectureDonnées données;

        protected int id;
        protected string nom;

        public Joueur(int id, string nom)
        {
            this.id = id;
            this.nom = nom;

            données = LectureDonnées.GetInstance();
        }

        public int GetId()
        {
            return id;
        }

        public string GetNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return this.nom;
        }

    }
}
