namespace tp_salaire_winForm
{
    partial class leFormulaire
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
            this.lstBulletins = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBulletins
            // 
            this.lstBulletins.FormattingEnabled = true;
            this.lstBulletins.Location = new System.Drawing.Point(44, 97);
            this.lstBulletins.Name = "lstBulletins";
            this.lstBulletins.Size = new System.Drawing.Size(120, 95);
            this.lstBulletins.TabIndex = 0;
            this.lstBulletins.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // leFormulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstBulletins);
            this.Name = "leFormulaire";
            this.Text = "leFormulaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBulletins;
    }
}