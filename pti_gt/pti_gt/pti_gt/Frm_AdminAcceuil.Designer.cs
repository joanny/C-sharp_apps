namespace pti_gt
{
    partial class Frm_AdminAcceuil
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesTacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelTacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesTachesEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ma_dataSet = new pti_gt.ma_dataSet();
            this.tACHESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tACHESTableAdapter = new pti_gt.ma_dataSetTableAdapters.TACHESTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACHESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUtilisateurToolStripMenuItem,
            this.gestionDesTacheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionUtilisateurToolStripMenuItem
            // 
            this.gestionUtilisateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelEmployéToolStripMenuItem});
            this.gestionUtilisateurToolStripMenuItem.Name = "gestionUtilisateurToolStripMenuItem";
            this.gestionUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.gestionUtilisateurToolStripMenuItem.Text = "&Gestion employé";
            // 
            // nouvelEmployéToolStripMenuItem
            // 
            this.nouvelEmployéToolStripMenuItem.Name = "nouvelEmployéToolStripMenuItem";
            this.nouvelEmployéToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nouvelEmployéToolStripMenuItem.Text = "Nouvel employé";
            this.nouvelEmployéToolStripMenuItem.Click += new System.EventHandler(this.nouvelEmployéToolStripMenuItem_Click);
            // 
            // gestionDesTacheToolStripMenuItem
            // 
            this.gestionDesTacheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelTacheToolStripMenuItem,
            this.voirLesTachesEnCoursToolStripMenuItem});
            this.gestionDesTacheToolStripMenuItem.Name = "gestionDesTacheToolStripMenuItem";
            this.gestionDesTacheToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionDesTacheToolStripMenuItem.Text = "Gestion des &Taches";
            // 
            // nouvelTacheToolStripMenuItem
            // 
            this.nouvelTacheToolStripMenuItem.Name = "nouvelTacheToolStripMenuItem";
            this.nouvelTacheToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nouvelTacheToolStripMenuItem.Text = "Nouvel tache";
            this.nouvelTacheToolStripMenuItem.Click += new System.EventHandler(this.nouvelTacheToolStripMenuItem_Click);
            // 
            // voirLesTachesEnCoursToolStripMenuItem
            // 
            this.voirLesTachesEnCoursToolStripMenuItem.Name = "voirLesTachesEnCoursToolStripMenuItem";
            this.voirLesTachesEnCoursToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.voirLesTachesEnCoursToolStripMenuItem.Text = "&Evolution des  taches";
            this.voirLesTachesEnCoursToolStripMenuItem.Click += new System.EventHandler(this.voirLesTachesEnCoursToolStripMenuItem_Click);
            // 
            // ma_dataSet
            // 
            this.ma_dataSet.DataSetName = "ma_dataSet";
            this.ma_dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tACHESBindingSource
            // 
            this.tACHESBindingSource.DataMember = "TACHES";
            this.tACHESBindingSource.DataSource = this.ma_dataSet;
            // 
            // tACHESTableAdapter
            // 
            this.tACHESTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_AdminAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 306);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_AdminAcceuil";
            this.Text = "Menu Administrateur";
            this.Load += new System.EventHandler(this.Frm_AdminAcceuil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACHESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionUtilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesTacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelTacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesTachesEnCoursToolStripMenuItem;
        private ma_dataSet ma_dataSet;
        private System.Windows.Forms.BindingSource tACHESBindingSource;
        private ma_dataSetTableAdapters.TACHESTableAdapter tACHESTableAdapter;


    }
}