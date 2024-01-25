namespace WindowsFormsApp1.Fenetres
{
    partial class FenMonstres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvMonstres = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Danger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Expérience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDangerosité = new System.Windows.Forms.Label();
            this.lblExpérience = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbDangerosite = new System.Windows.Forms.TextBox();
            this.txbExperience = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grbNouveauMonstre = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.grbNouveauMonstre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvMonstres
            // 
            this.lsvMonstres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Danger,
            this.Expérience});
            this.lsvMonstres.FullRowSelect = true;
            this.lsvMonstres.HideSelection = false;
            this.lsvMonstres.Location = new System.Drawing.Point(12, 12);
            this.lsvMonstres.Name = "lsvMonstres";
            this.lsvMonstres.Size = new System.Drawing.Size(311, 414);
            this.lsvMonstres.TabIndex = 1;
            this.lsvMonstres.UseCompatibleStateImageBehavior = false;
            this.lsvMonstres.View = System.Windows.Forms.View.Details;
            this.lsvMonstres.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lsvMonstres_ItemSelectionChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 97;
            // 
            // Danger
            // 
            this.Danger.Text = "Danger";
            this.Danger.Width = 58;
            // 
            // Expérience
            // 
            this.Expérience.Text = "Expérience";
            this.Expérience.Width = 74;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(444, 403);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(99, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 27);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom";
            // 
            // lblDangerosité
            // 
            this.lblDangerosité.AutoSize = true;
            this.lblDangerosité.Location = new System.Drawing.Point(7, 49);
            this.lblDangerosité.Name = "lblDangerosité";
            this.lblDangerosité.Size = new System.Drawing.Size(64, 13);
            this.lblDangerosité.TabIndex = 5;
            this.lblDangerosité.Text = "Dangerosité";
            // 
            // lblExpérience
            // 
            this.lblExpérience.AutoSize = true;
            this.lblExpérience.Location = new System.Drawing.Point(7, 75);
            this.lblExpérience.Name = "lblExpérience";
            this.lblExpérience.Size = new System.Drawing.Size(60, 13);
            this.lblExpérience.TabIndex = 6;
            this.lblExpérience.Text = "Expérience";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(76, 20);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(138, 20);
            this.txbNom.TabIndex = 7;
            // 
            // txbDangerosite
            // 
            this.txbDangerosite.Location = new System.Drawing.Point(76, 46);
            this.txbDangerosite.Name = "txbDangerosite";
            this.txbDangerosite.Size = new System.Drawing.Size(138, 20);
            this.txbDangerosite.TabIndex = 8;
            // 
            // txbExperience
            // 
            this.txbExperience.Location = new System.Drawing.Point(76, 72);
            this.txbExperience.Name = "txbExperience";
            this.txbExperience.Size = new System.Drawing.Size(138, 20);
            this.txbExperience.TabIndex = 9;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(6, 98);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(103, 23);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(115, 98);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // grbNouveauMonstre
            // 
            this.grbNouveauMonstre.Controls.Add(this.btnValider);
            this.grbNouveauMonstre.Controls.Add(this.btnAnnuler);
            this.grbNouveauMonstre.Controls.Add(this.lblNom);
            this.grbNouveauMonstre.Controls.Add(this.lblDangerosité);
            this.grbNouveauMonstre.Controls.Add(this.txbExperience);
            this.grbNouveauMonstre.Controls.Add(this.lblExpérience);
            this.grbNouveauMonstre.Controls.Add(this.txbDangerosite);
            this.grbNouveauMonstre.Controls.Add(this.txbNom);
            this.grbNouveauMonstre.Location = new System.Drawing.Point(329, 12);
            this.grbNouveauMonstre.Name = "grbNouveauMonstre";
            this.grbNouveauMonstre.Size = new System.Drawing.Size(227, 131);
            this.grbNouveauMonstre.TabIndex = 12;
            this.grbNouveauMonstre.TabStop = false;
            this.grbNouveauMonstre.Text = "NouveauMonstre";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(335, 403);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 23);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FenMonstres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 438);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.grbNouveauMonstre);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.lsvMonstres);
            this.Name = "FenMonstres";
            this.Text = "FenMonstre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FenMonstres_FormClosing);
            this.grbNouveauMonstre.ResumeLayout(false);
            this.grbNouveauMonstre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lsvMonstres;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Danger;
        private System.Windows.Forms.ColumnHeader Expérience;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDangerosité;
        private System.Windows.Forms.Label lblExpérience;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbDangerosite;
        private System.Windows.Forms.TextBox txbExperience;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grbNouveauMonstre;
        private System.Windows.Forms.Button btnSupprimer;
    }
}