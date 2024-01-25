using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.ClassesDonnées;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialisation données statiques
            Personnage.InitialiserListeNiveaux();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenPrincipale());
        }
    }
}
