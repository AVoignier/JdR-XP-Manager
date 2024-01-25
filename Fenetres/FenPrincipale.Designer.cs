namespace WindowsFormsApp1
{
    partial class FenPrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCombat = new System.Windows.Forms.Button();
            this.btnMonstres = new System.Windows.Forms.Button();
            this.btnHistoCmb = new System.Windows.Forms.Button();
            this.btnEquipe = new System.Windows.Forms.Button();
            this.btnJoueurs = new System.Windows.Forms.Button();
            this.btnPersonnages = new System.Windows.Forms.Button();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.cmbEquipe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCombat
            // 
            this.btnCombat.Location = new System.Drawing.Point(12, 12);
            this.btnCombat.Name = "btnCombat";
            this.btnCombat.Size = new System.Drawing.Size(150, 32);
            this.btnCombat.TabIndex = 0;
            this.btnCombat.Text = "Combat";
            this.btnCombat.UseVisualStyleBackColor = true;
            this.btnCombat.Click += new System.EventHandler(this.btnCombat_Click);
            // 
            // btnMonstres
            // 
            this.btnMonstres.Location = new System.Drawing.Point(168, 126);
            this.btnMonstres.Name = "btnMonstres";
            this.btnMonstres.Size = new System.Drawing.Size(150, 32);
            this.btnMonstres.TabIndex = 1;
            this.btnMonstres.Text = "Monstres";
            this.btnMonstres.UseVisualStyleBackColor = true;
            this.btnMonstres.Click += new System.EventHandler(this.btnMonstres_Click);
            // 
            // btnHistoCmb
            // 
            this.btnHistoCmb.Location = new System.Drawing.Point(12, 50);
            this.btnHistoCmb.Name = "btnHistoCmb";
            this.btnHistoCmb.Size = new System.Drawing.Size(150, 32);
            this.btnHistoCmb.TabIndex = 2;
            this.btnHistoCmb.Text = "Historique Combat";
            this.btnHistoCmb.UseVisualStyleBackColor = true;
            // 
            // btnEquipe
            // 
            this.btnEquipe.Location = new System.Drawing.Point(168, 12);
            this.btnEquipe.Name = "btnEquipe";
            this.btnEquipe.Size = new System.Drawing.Size(150, 32);
            this.btnEquipe.TabIndex = 3;
            this.btnEquipe.Text = "Equipes";
            this.btnEquipe.UseVisualStyleBackColor = true;
            this.btnEquipe.Click += new System.EventHandler(this.btnEquipe_Click);
            // 
            // btnJoueurs
            // 
            this.btnJoueurs.Location = new System.Drawing.Point(168, 88);
            this.btnJoueurs.Name = "btnJoueurs";
            this.btnJoueurs.Size = new System.Drawing.Size(150, 32);
            this.btnJoueurs.TabIndex = 6;
            this.btnJoueurs.Text = "Joueurs";
            this.btnJoueurs.UseVisualStyleBackColor = true;
            this.btnJoueurs.Click += new System.EventHandler(this.btnJoueurs_Click);
            // 
            // btnPersonnages
            // 
            this.btnPersonnages.Location = new System.Drawing.Point(168, 50);
            this.btnPersonnages.Name = "btnPersonnages";
            this.btnPersonnages.Size = new System.Drawing.Size(150, 32);
            this.btnPersonnages.TabIndex = 7;
            this.btnPersonnages.Text = "Personnages";
            this.btnPersonnages.UseVisualStyleBackColor = true;
            this.btnPersonnages.Click += new System.EventHandler(this.btnPersonnages_Click);
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Location = new System.Drawing.Point(12, 85);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(105, 13);
            this.lblEquipe.TabIndex = 4;
            this.lblEquipe.Text = "Equipe Sélectionné :";
            this.lblEquipe.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbEquipe
            // 
            this.cmbEquipe.AccessibleDescription = "";
            this.cmbEquipe.FormattingEnabled = true;
            this.cmbEquipe.Location = new System.Drawing.Point(12, 101);
            this.cmbEquipe.Name = "cmbEquipe";
            this.cmbEquipe.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipe.TabIndex = 5;
            this.cmbEquipe.SelectedIndexChanged += new System.EventHandler(this.cmbEquipe_SelectedIndexChanged);
            // 
            // FenPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 166);
            this.Controls.Add(this.btnPersonnages);
            this.Controls.Add(this.btnJoueurs);
            this.Controls.Add(this.cmbEquipe);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.btnEquipe);
            this.Controls.Add(this.btnHistoCmb);
            this.Controls.Add(this.btnMonstres);
            this.Controls.Add(this.btnCombat);
            this.Name = "FenPrincipale";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FenPrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCombat;
        private System.Windows.Forms.Button btnMonstres;
        private System.Windows.Forms.Button btnHistoCmb;
        private System.Windows.Forms.Button btnEquipe;
        private System.Windows.Forms.Button btnJoueurs;
        private System.Windows.Forms.Button btnPersonnages;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.ComboBox cmbEquipe;
    }
}

