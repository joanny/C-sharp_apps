namespace autoEcoleVS2005
{
    partial class FrmAjouterEleve
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtDateInscription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbForfaitH = new System.Windows.Forms.ComboBox();
            this.calendrier = new System.Windows.Forms.MonthCalendar();
            this.btnAjouter_Eleve = new System.Windows.Forms.Button();
            this.ma_DataSet1 = new autoEcoleVS2005.ma_DataSet();
            this.TaQuery = new autoEcoleVS2005.ma_DataSetTableAdapters.QueriesTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(122, 33);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(327, 33);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtDateInscription
            // 
            this.txtDateInscription.Location = new System.Drawing.Point(122, 150);
            this.txtDateInscription.Name = "txtDateInscription";
            this.txtDateInscription.Size = new System.Drawing.Size(66, 20);
            this.txtDateInscription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date inscription :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forfait horaire :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(122, 68);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(305, 20);
            this.txtAdresse.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adresse :";
            // 
            // cmbForfaitH
            // 
            this.cmbForfaitH.FormattingEnabled = true;
            this.cmbForfaitH.Location = new System.Drawing.Point(122, 115);
            this.cmbForfaitH.Name = "cmbForfaitH";
            this.cmbForfaitH.Size = new System.Drawing.Size(66, 21);
            this.cmbForfaitH.TabIndex = 9;
            // 
            // calendrier
            // 
            this.calendrier.Location = new System.Drawing.Point(200, 150);
            this.calendrier.Name = "calendrier";
            this.calendrier.TabIndex = 10;
            this.calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendrier_DateChanged);
            // 
            // btnAjouter_Eleve
            // 
            this.btnAjouter_Eleve.Location = new System.Drawing.Point(33, 265);
            this.btnAjouter_Eleve.Name = "btnAjouter_Eleve";
            this.btnAjouter_Eleve.Size = new System.Drawing.Size(131, 46);
            this.btnAjouter_Eleve.TabIndex = 11;
            this.btnAjouter_Eleve.Text = "Sauvegarder";
            this.btnAjouter_Eleve.UseVisualStyleBackColor = true;
            this.btnAjouter_Eleve.Click += new System.EventHandler(this.btnAjouter_Eleve_Click);
            // 
            // ma_DataSet1
            // 
            this.ma_DataSet1.DataSetName = "ma_DataSet";
            this.ma_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prénom :";
            // 
            // FrmAjouterEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAjouter_Eleve);
            this.Controls.Add(this.calendrier);
            this.Controls.Add(this.cmbForfaitH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateInscription);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjouterEleve";
            this.Text = "Nouvel Elève";
            this.Load += new System.EventHandler(this.FrmAjouterEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtDateInscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbForfaitH;
        private System.Windows.Forms.MonthCalendar calendrier;
        private System.Windows.Forms.Button btnAjouter_Eleve;
        private ma_DataSet ma_DataSet1;
        private ma_DataSetTableAdapters.QueriesTableAdapter TaQuery;
        private System.Windows.Forms.Label label5;
        
    }
}