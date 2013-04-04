namespace autoEcoleVS2005
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEleveLecon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLecon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVehicule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLeconleçonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNouvelleLecon = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculeIndispoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculeIndispoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.M = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFichier,
            this.menuEleveLecon,
            this.menuVehicule,
            this.menuLeconleçonToolStripMenuItem,
            this.vehiculeIndispoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(630, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFichier
            // 
            this.MenuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuitter});
            this.MenuFichier.Name = "MenuFichier";
            this.MenuFichier.Size = new System.Drawing.Size(54, 20);
            this.MenuFichier.Text = "Fichier";
            // 
            // menuQuitter
            // 
            this.menuQuitter.Name = "menuQuitter";
            this.menuQuitter.Size = new System.Drawing.Size(111, 22);
            this.menuQuitter.Text = "Quitter";
            this.menuQuitter.Click += new System.EventHandler(this.menuQuitter_Click);
            // 
            // menuEleveLecon
            // 
            this.menuEleveLecon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNouveau,
            this.menuLecon});
            this.menuEleveLecon.Name = "menuEleveLecon";
            this.menuEleveLecon.Size = new System.Drawing.Size(46, 20);
            this.menuEleveLecon.Text = "Elève";
            // 
            // menuNouveau
            // 
            this.menuNouveau.Name = "menuNouveau";
            this.menuNouveau.Size = new System.Drawing.Size(122, 22);
            this.menuNouveau.Text = "Nouveau";
            this.menuNouveau.Click += new System.EventHandler(this.menuNouveau_Click);
            // 
            // menuLecon
            // 
            this.menuLecon.Name = "menuLecon";
            this.menuLecon.Size = new System.Drawing.Size(122, 22);
            this.menuLecon.Text = "Leçon";
            this.menuLecon.Click += new System.EventHandler(this.menuLecon_Click);
            // 
            // menuVehicule
            // 
            this.menuVehicule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGestion,
            this.menuListe});
            this.menuVehicule.Name = "menuVehicule";
            this.menuVehicule.Size = new System.Drawing.Size(63, 20);
            this.menuVehicule.Text = "vehicule";
            // 
            // menuGestion
            // 
            this.menuGestion.Name = "menuGestion";
            this.menuGestion.Size = new System.Drawing.Size(114, 22);
            this.menuGestion.Text = "Gestion";
            this.menuGestion.Click += new System.EventHandler(this.menuGestion_Click);
            // 
            // menuListe
            // 
            this.menuListe.Name = "menuListe";
            this.menuListe.Size = new System.Drawing.Size(114, 22);
            this.menuListe.Text = "Liste";
            this.menuListe.Click += new System.EventHandler(this.menuListe_Click);
            // 
            // menuLeconleçonToolStripMenuItem
            // 
            this.menuLeconleçonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNouvelleLecon});
            this.menuLeconleçonToolStripMenuItem.Name = "menuLeconleçonToolStripMenuItem";
            this.menuLeconleçonToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuLeconleçonToolStripMenuItem.Text = "Leçon";
            // 
            // menuNouvelleLecon
            // 
            this.menuNouvelleLecon.Name = "menuNouvelleLecon";
            this.menuNouvelleLecon.Size = new System.Drawing.Size(156, 22);
            this.menuNouvelleLecon.Text = "Nouvelle Leçon";
            this.menuNouvelleLecon.Click += new System.EventHandler(this.menuNouvelleLecon_Click);
            // 
            // vehiculeIndispoToolStripMenuItem
            // 
            this.vehiculeIndispoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculeIndispoToolStripMenuItem1});
            this.vehiculeIndispoToolStripMenuItem.Name = "vehiculeIndispoToolStripMenuItem";
            this.vehiculeIndispoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.vehiculeIndispoToolStripMenuItem.Text = "Vehicule Indispo";
            // 
            // vehiculeIndispoToolStripMenuItem1
            // 
            this.vehiculeIndispoToolStripMenuItem1.Name = "vehiculeIndispoToolStripMenuItem1";
            this.vehiculeIndispoToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.vehiculeIndispoToolStripMenuItem1.Text = "Vehicule Indispo";
            this.vehiculeIndispoToolStripMenuItem1.Click += new System.EventHandler(this.vehiculeIndispoToolStripMenuItem1_Click);
            // 
            // M
            // 
            this.M.BackColor = System.Drawing.Color.Transparent;
            this.M.Location = new System.Drawing.Point(507, 200);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(10, 10);
            this.M.TabIndex = 1;
            this.M.UseVisualStyleBackColor = true;
            this.M.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 481);
            this.Controls.Add(this.M);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Auto Ecole du Pays d\'Ancenis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuQuitter;
        private System.Windows.Forms.ToolStripMenuItem menuEleveLecon;
        private System.Windows.Forms.ToolStripMenuItem menuNouveau;
        private System.Windows.Forms.ToolStripMenuItem menuLecon;
        private System.Windows.Forms.ToolStripMenuItem menuVehicule;
        private System.Windows.Forms.ToolStripMenuItem menuGestion;
        private System.Windows.Forms.ToolStripMenuItem menuListe;
        private System.Windows.Forms.ToolStripMenuItem menuLeconleçonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNouvelleLecon;
        private System.Windows.Forms.ToolStripMenuItem vehiculeIndispoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculeIndispoToolStripMenuItem1;
        private System.Windows.Forms.Button M;
    }
}

