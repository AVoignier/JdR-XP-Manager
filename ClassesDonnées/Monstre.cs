using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    internal class Monstre
    {
        protected int _id;
        public int Id 
        { 
            get =>_id;
        }

        protected string _nom;
        public string Nom
        {
            get => _nom;
        }

        protected double _dangerosite;
        public double Dangerosite
        {
            get => _dangerosite;
        }

        protected int _experience;
        public int Experience
        {
            get => _experience;
        }

        protected bool _personnalise;
        public bool Personnalise
        {
            get => _personnalise;
        }

        public Monstre(int id, string nom, double dangerosite, int experience, bool personnalise)
        {
            this._id = id;
            this._nom = nom;
            this._dangerosite = dangerosite;
            this._experience = experience;
            this._personnalise = personnalise;
        }

        public Monstre( string nom, double dangerosité, int expérience, bool personnalise)
        {
            this._id = -1;
            this._nom = nom;
            this._dangerosite = dangerosité;
            this._experience = expérience;
            this._personnalise = personnalise;

        }

        public override string ToString()
        {
            return _nom;
        }

    }
}
