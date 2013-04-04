namespace autoEcoleVS2005
{
    partial class FrmAjouterLecon
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEleve = new System.Windows.Forms.ComboBox();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ma_DataSet1 = new autoEcoleVS2005.ma_DataSet();
            this.bdgEleve = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreditH = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHeure = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDeuxHeures = new System.Windows.Forms.RadioButton();
            this.rdbUneHeure = new System.Windows.Forms.RadioButton();
            this.TaEleve = new autoEcoleVS2005.ma_DataSetTableAdapters.ELEVETableAdapter();
            this.cmbVehiculeDispo = new System.Windows.Forms.ComboBox();
            this.bdgVehicule = new System.Windows.Forms.BindingSource(this.components);
            this.Ta_VEHICULE_Dispo = new autoEcoleVS2005.ma_DataSetTableAdapters.VEHICULE_DISPOTableAdapter();
            this.TaVehicule = new autoEcoleVS2005.ma_DataSetTableAdapters.VEHICULETableAdapter();
            this.QueryTa = new autoEcoleVS2005.ma_DataSetTableAdapters.QueriesTableAdapter();
            this.fKLECONELEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECONTableAdapter = new autoEcoleVS2005.ma_DataSetTableAdapters.LECONTableAdapter();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblNb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLECONELEVEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleve:";
            // 
            // cmbEleve
            // 
            this.cmbEleve.DataSource = this.eLEVEBindingSource;
            this.cmbEleve.DisplayMember = "nom";
            this.cmbEleve.FormattingEnabled = true;
            this.cmbEleve.Location = new System.Drawing.Point(70, 31);
            this.cmbEleve.Name = "cmbEleve";
            this.cmbEleve.Size = new System.Drawing.Size(83, 21);
            this.cmbEleve.TabIndex = 1;
            this.cmbEleve.ValueMember = "code";
            // 
            // eLEVEBindingSource
            // 
            this.eLEVEBindingSource.DataMember = "ELEVE";
            this.eLEVEBindingSource.DataSource = this.ma_DataSet1;
            // 
            // ma_DataSet1
            // 
            this.ma_DataSet1.DataSetName = "ma_DataSet";
            this.ma_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdgEleve
            // 
            this.bdgEleve.DataMember = "ELEVE";
            this.bdgEleve.DataSource = this.ma_DataSet1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crédit horaire:";
            // 
            // txtCreditH
            // 
            this.txtCreditH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eLEVEBindingSource, "creditHoraire", true));
            this.txtCreditH.Location = new System.Drawing.Point(325, 36);
            this.txtCreditH.Name = "txtCreditH";
            this.txtCreditH.Size = new System.Drawing.Size(100, 20);
            this.txtCreditH.TabIndex = 3;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(70, 90);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(193, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // cmbHeure
            // 
            this.cmbHeure.FormattingEnabled = true;
            this.cmbHeure.Location = new System.Drawing.Point(325, 93);
            this.cmbHeure.Name = "cmbHeure";
            this.cmbHeure.Size = new System.Drawing.Size(100, 21);
            this.cmbHeure.TabIndex = 6;
            this.cmbHeure.SelectedIndexChanged += new System.EventHandler(this.cmbHeure_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heure";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDeuxHeures);
            this.groupBox1.Controls.Add(this.rdbUneHeure);
            this.groupBox1.Location = new System.Drawing.Point(32, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durée";
            // 
            // rdbDeuxHeures
            // 
            this.rdbDeuxHeures.AutoSize = true;
            this.rdbDeuxHeures.Location = new System.Drawing.Point(107, 30);
            this.rdbDeuxHeures.Name = "rdbDeuxHeures";
            this.rdbDeuxHeures.Size = new System.Drawing.Size(40, 17);
            this.rdbDeuxHeures.TabIndex = 1;
            this.rdbDeuxHeures.TabStop = true;
            this.rdbDeuxHeures.Text = "2 h";
            this.rdbDeuxHeures.UseVisualStyleBackColor = true;
            // 
            // rdbUneHeure
            // 
            this.rdbUneHeure.AutoSize = true;
            this.rdbUneHeure.Location = new System.Drawing.Point(38, 30);
            this.rdbUneHeure.Name = "rdbUneHeure";
            this.rdbUneHeure.Size = new System.Drawing.Size(40, 17);
            this.rdbUneHeure.TabIndex = 0;
            this.rdbUneHeure.TabStop = true;
            this.rdbUneHeure.Text = "1 h";
            this.rdbUneHeure.UseVisualStyleBackColor = true;
            // 
            // TaEleve
            // 
            this.TaEleve.ClearBeforeFill = true;
            // 
            // cmbVehiculeDispo
            // 
            this.cmbVehiculeDispo.DataSource = this.bdgVehicule;
            this.cmbVehiculeDispo.DisplayMember = "modele";
            this.cmbVehiculeDispo.FormattingEnabled = true;
            this.cmbVehiculeDispo.Location = new System.Drawing.Point(32, 228);
            this.cmbVehiculeDispo.Name = "cmbVehiculeDispo";
            this.cmbVehiculeDispo.Size = new System.Drawing.Size(231, 21);
            this.cmbVehiculeDispo.TabIndex = 11;
            this.cmbVehiculeDispo.ValueMember = "numImma";
            // 
            // bdgVehicule
            // 
            this.bdgVehicule.DataMember = "VEHICULE";
            this.bdgVehicule.DataSource = this.ma_DataSet1;
            // 
            // Ta_VEHICULE_Dispo
            // 
            this.Ta_VEHICULE_Dispo.ClearBeforeFill = true;
            // 
            // TaVehicule
            // 
            this.TaVehicule.ClearBeforeFill = true;
            // 
            // fKLECONELEVEBindingSource
            // 
            this.fKLECONELEVEBindingSource.DataMember = "FK_LECON_ELEVE";
            this.fKLECONELEVEBindingSource.DataSource = this.bdgEleve;
            // 
            // lECONTableAdapter
            // 
            this.lECONTableAdapter.ClearBeforeFill = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(83, 280);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(137, 55);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblNb
            // 
            this.lblNb.AutoSize = true;
            this.lblNb.Location = new System.Drawing.Point(284, 235);
            this.lblNb.Name = "lblNb";
            this.lblNb.Size = new System.Drawing.Size(35, 13);
            this.lblNb.TabIndex = 12;
            this.lblNb.Text = "label5";
            // 
            // FrmAjouterLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 347);
            this.Controls.Add(this.lblNb);
            this.Controls.Add(this.cmbVehiculeDispo);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHeure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtCreditH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEleve);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eLEVEBindingSource, "prenom", true));
            this.Name = "FrmAjouterLecon";
            this.Text = "Nouvelle leçon";
            this.Load += new System.EventHandler(this.FrmAjouterLecon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLECONELEVEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEleve;
       
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreditH;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHeure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDeuxHeures;
        private System.Windows.Forms.RadioButton rdbUneHeure;
        //private ma_dataSetTableAdapters.VEHICULE_DispoTableAdapter Ta_VEHICULE_Dispo;
        private ma_DataSet ma_DataSet1;
        private System.Windows.Forms.BindingSource bdgEleve;
        private ma_DataSetTableAdapters.ELEVETableAdapter TaEleve;
        private System.Windows.Forms.ComboBox cmbVehiculeDispo;
        private ma_DataSetTableAdapters.VEHICULE_DISPOTableAdapter Ta_VEHICULE_Dispo;
        private System.Windows.Forms.BindingSource bdgVehicule;
        private ma_DataSetTableAdapters.VEHICULETableAdapter TaVehicule;
        private ma_DataSetTableAdapters.QueriesTableAdapter QueryTa;
        private System.Windows.Forms.BindingSource fKLECONELEVEBindingSource;
        private ma_DataSetTableAdapters.LECONTableAdapter lECONTableAdapter;
        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblNb;
    }
}