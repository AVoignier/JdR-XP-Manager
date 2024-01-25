using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Données;

namespace WindowsFormsApp1.Fenetres
{
    public partial class FenMonstres : Form
    {
        private Form fenetreAppelante;

        private LectureDonnées lectureDonnées;
        private EcritureDonnées ecritureDonnées;
        private SuppressionDonnées suppressionDonnées;

        private List<Monstre> lstMonstres;

        public FenMonstres( Form fenetreAppelante )
        {
            InitializeComponent();

            lectureDonnées = LectureDonnées.GetInstance();
            ecritureDonnées = EcritureDonnées.GetInstance();
            suppressionDonnées = SuppressionDonnées.GetInstance();

            lstMonstres = new List<Monstre>();


            MajLstMonstres();
            MajLsvMonstres();


            this.fenetreAppelante = fenetreAppelante;
            this.fenetreAppelante.Visible = false;

        }

        private void MajLstMonstres()
        {
            lstMonstres.Clear();
            lstMonstres = lectureDonnées.GetMonstres();

        }

        private void MajLsvMonstres()
        {
            lsvMonstres.Items.Clear();

            ListViewItem lsvItem;

            foreach( Monstre monstre in lstMonstres )
            {
                /*string[] ligne =
                {
                    monstre.Nom.ToString(),
                    monstre.Dangerosite.ToString(),
                    monstre.Experience.ToString()
                };*/

                lsvItem = new ListViewItem(monstre.Nom);
                lsvItem.Tag = monstre;
                lsvItem.SubItems.Add(monstre.Dangerosite.ToString());
                lsvItem.SubItems.Add(monstre.Experience.ToString());

                if (monstre.Personnalise)
                {
                    lsvItem.ForeColor = Color.Red;
                }

                lsvMonstres.Items.Add(lsvItem);
            }

        }

        private void btnValider_Click(object sender, EventArgs e)
        {

            if(VérificationDonnées.VérificationDonnéesMonstre(txbNom.Text, txbDangerosite.Text, txbExperience.Text))
            {
                Monstre monstre = new Monstre( txbNom.Text, double.Parse(txbDangerosite.Text), int.Parse(txbExperience.Text), true );

                string str = "Voulez vous créer ce monstre ?\n\n";
                str += "Nom = " + monstre.Nom + "\n";
                str += "Dangerosité = " + monstre.Dangerosite + "\n";
                str += "Expérience = " + monstre.Experience;

                DialogResult dialogResult = MessageBox.Show(str, "Création du monstre", MessageBoxButtons.YesNo);

                if(dialogResult == DialogResult.Yes)
                {
                    ecritureDonnées.InsererMonstre(monstre.Nom, monstre.Experience, monstre.Dangerosite, monstre.Personnalise);

                    MajLstMonstres();
                    MajLsvMonstres();
                }
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txbNom.Text = "";
            txbDangerosite.Text = "";
            txbExperience.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lsvMonstres_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(lsvMonstres.SelectedItems.Count > 0)
            {
                btnSupprimer.Enabled = true;
            }
            else
            {
                btnSupprimer.Enabled = false;
            }
        }

        private void FenMonstres_FormClosing(object sender, FormClosingEventArgs e)
        {
            fenetreAppelante.Visible = true;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if( lsvMonstres.SelectedItems.Count == 1 )
            {
                string str = "Voulez-vous vraiment supprimer le monstre ?\n";
                str += "Nom = " + ((Monstre)lsvMonstres.SelectedItems[0].Tag).Nom + "\n";
                str += "Dangerosité = " + ((Monstre)lsvMonstres.SelectedItems[0].Tag).Dangerosite + "\n";
                str += "Expérience = " + ((Monstre)lsvMonstres.SelectedItems[0].Tag).Experience;

                if ( DialogResult.Yes == MessageBox.Show(str, "Suppression monstre", MessageBoxButtons.YesNo))
                {
                    suppressionDonnées.SupprimerMonstre((Monstre)lsvMonstres.SelectedItems[0].Tag);

                    MajLstMonstres();
                    MajLsvMonstres();
                }
            }
            else if(lsvMonstres.SelectedItems.Count > 1 )
            {
                string str = "Voulez vous vraiment supprimer ces " + lsvMonstres.SelectedItems.Count + " monstres ?";

                if (DialogResult.Yes == MessageBox.Show(str, "Suppression monstre", MessageBoxButtons.YesNo))
                {
                    List<Monstre> monstres = new List<Monstre>();

                    foreach( ListViewItem item in lsvMonstres.SelectedItems)
                    {
                        monstres.Add( (Monstre)item.Tag );
                    }
                    suppressionDonnées.SupprimerMonstres(monstres);

                    MajLstMonstres();
                    MajLsvMonstres();
                }

            }
        }
    }
}
