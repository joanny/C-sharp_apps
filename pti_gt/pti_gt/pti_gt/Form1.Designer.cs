namespace pti_gt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAdministrateur = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbEmploye = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ma_dataSet = new pti_gt.ma_dataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new pti_gt.ma_dataSetTableAdapters.ServiceTableAdapter();
            this.queriesTableAdapter1 = new pti_gt.ma_dataSetTableAdapters.QueriesTableAdapter();
            this.labelErreur = new System.Windows.Forms.Label();
            this.labelER = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(154, 23);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.txtIdentifiant.TabIndex = 1;
            this.txtIdentifiant.Text = "az";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(154, 49);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.PasswordChar = '*';
            this.txtMotDePasse.Size = new System.Drawing.Size(100, 20);
            this.txtMotDePasse.TabIndex = 2;
            this.txtMotDePasse.Text = "az";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe :";
            // 
            // rdbAdministrateur
            // 
            this.rdbAdministrateur.AutoSize = true;
            this.rdbAdministrateur.Location = new System.Drawing.Point(172, 13);
            this.rdbAdministrateur.Name = "rdbAdministrateur";
            this.rdbAdministrateur.Size = new System.Drawing.Size(91, 17);
            this.rdbAdministrateur.TabIndex = 5;
            this.rdbAdministrateur.TabStop = true;
            this.rdbAdministrateur.Text = "Administrateur";
            this.rdbAdministrateur.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Statut :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.rdbEmploye);
            this.panel1.Controls.Add(this.rdbAdministrateur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(39, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 82);
            this.panel1.TabIndex = 7;
            // 
            // rdbEmploye
            // 
            this.rdbEmploye.AutoSize = true;
            this.rdbEmploye.Location = new System.Drawing.Point(172, 45);
            this.rdbEmploye.Name = "rdbEmploye";
            this.rdbEmploye.Size = new System.Drawing.Size(65, 17);
            this.rdbEmploye.TabIndex = 7;
            this.rdbEmploye.TabStop = true;
            this.rdbEmploye.Text = "Employé";
            this.rdbEmploye.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Location = new System.Drawing.Point(153, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ma_dataSet
            // 
            this.ma_dataSet.DataSetName = "ma_dataSet";
            this.ma_dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.ma_dataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.Location = new System.Drawing.Point(24, 27);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(0, 13);
            this.labelErreur.TabIndex = 9;
            this.labelErreur.Visible = false;
            // 
            // labelER
            // 
            this.labelER.AutoSize = true;
            this.labelER.Location = new System.Drawing.Point(133, 34);
            this.labelER.Name = "labelER";
            this.labelER.Size = new System.Drawing.Size(17, 13);
            this.labelER.TabIndex = 10;
            this.labelER.Text = "//";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(8, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.labelER);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(653, 304);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMotDePasse);
            this.panel2.Controls.Add(this.txtIdentifiant);
            this.panel2.Location = new System.Drawing.Point(39, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 85);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 334);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.labelErreur);
            this.Name = "Form1";
            this.Text = "Gestionnaire de tâches";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAdministrateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbEmploye;
        private ma_dataSet ma_dataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private ma_dataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Button button1;
        private ma_dataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Label labelER;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
    }
}

