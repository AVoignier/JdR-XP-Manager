using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    internal class Equipe
    {
        protected int id;
        protected string nom;

        public Equipe(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
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
            return nom;
        }
    }
}
