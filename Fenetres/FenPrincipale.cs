using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Fenetres;

namespace WindowsFormsApp1
{
    public partial class FenPrincipale : Form
    {
        private LectureDonnées données;

        private List<Equipe> equipes;

        public FenPrincipale()
        {
            InitializeComponent();

            données = LectureDonnées.GetInstance();

            equipes = new List<Equipe>();

            ReccupEquipe();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReccupEquipe()
        {
            equipes.Clear();
            equipes = données.GetEquipes();

            ListViewItem item;

            foreach (Equipe equipe in equipes)
            {
                item = new ListViewItem(equipe.GetNom());
                cmbEquipe.Items.Add(item.Text);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FenPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void btnMonstres_Click(object sender, EventArgs e)
        {
            Fenetres.FenMonstres fenMonstre = new Fenetres.FenMonstres(this);
            fenMonstre.Show();
        }

        private void btnEquipe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnJoueurs_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPersonnages_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCombat_Click(object sender, EventArgs e)
        {

        }

        private void cmbEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
