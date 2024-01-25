using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.ClassesDonnées
{
    internal class Niveau
    {
        protected int niveau;
        protected int experience;

        public Niveau(int niveau, int experience)
        {
           this.niveau = niveau;
           this.experience = experience;
        }

        public int GetNiveau()
        {
            return niveau;
        }

        public int GetExperience()
        {
            return experience;
        }


    }
}
