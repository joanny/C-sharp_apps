namespace tp_salaire_winForm
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 108);
            this.listBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donnéesToolStripMenuItem,
            this.bulletinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donnéesToolStripMenuItem
            // 
            this.donnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerToolStripMenuItem});
            this.donnéesToolStripMenuItem.Name = "donnéesToolStripMenuItem";
            this.donnéesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.donnéesToolStripMenuItem.Text = "Données";
            this.donnéesToolStripMenuItem.Click += new System.EventHandler(this.donnéesToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // bulletinToolStripMenuItem
            // 
            this.bulletinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem});
            this.bulletinToolStripMenuItem.Name = "bulletinToolStripMenuItem";
            this.bulletinToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.bulletinToolStripMenuItem.Text = "Bulletin";
            // 
            // voirToolStripMenuItem
            // 
            this.voirToolStripMenuItem.Name = "voirToolStripMenuItem";
            this.voirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.voirToolStripMenuItem.Text = "Voir";
            this.voirToolStripMenuItem.Click += new System.EventHandler(this.voirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem donnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulletinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem;
    }
}

