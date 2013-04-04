namespace autoEcoleVS2005
{
    partial class FrmLeconParEleve
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
            this.cmbEleve = new System.Windows.Forms.ComboBox();
            this.bdgEleve = new System.Windows.Forms.BindingSource(this.components);
            this.ma_DataSet1 = new autoEcoleVS2005.ma_DataSet();
            this.lblEleve = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.TaEleve = new autoEcoleVS2005.ma_DataSetTableAdapters.ELEVETableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectueeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numImmaVehiculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKLECONELEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECONTableAdapter = new autoEcoleVS2005.ma_DataSetTableAdapters.LECONTableAdapter();
            this.TaLecon = new autoEcoleVS2005.ma_DataSetTableAdapters.LECONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLECONELEVEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEleve
            // 
            this.cmbEleve.DataSource = this.bdgEleve;
            this.cmbEleve.DisplayMember = "nom";
            this.cmbEleve.FormattingEnabled = true;
            this.cmbEleve.Location = new System.Drawing.Point(93, 34);
            this.cmbEleve.Name = "cmbEleve";
            this.cmbEleve.Size = new System.Drawing.Size(86, 21);
            this.cmbEleve.TabIndex = 0;
            this.cmbEleve.ValueMember = "code";
            this.cmbEleve.ValueMemberChanged += new System.EventHandler(this.l_SelectedIndexChanged);
            // 
            // bdgEleve
            // 
            this.bdgEleve.DataMember = "ELEVE";
            this.bdgEleve.DataSource = this.ma_DataSet1;
            // 
            // ma_DataSet1
            // 
            this.ma_DataSet1.DataSetName = "ma_DataSet";
            this.ma_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEleve
            // 
            this.lblEleve.AutoSize = true;
            this.lblEleve.Location = new System.Drawing.Point(36, 34);
            this.lblEleve.Name = "lblEleve";
            this.lblEleve.Size = new System.Drawing.Size(34, 13);
            this.lblEleve.TabIndex = 1;
            this.lblEleve.Text = "Elève";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(498, 238);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(86, 32);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // TaEleve
            // 
            this.TaEleve.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.effectueeDataGridViewCheckBoxColumn,
            this.numImmaVehiculeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKLECONELEVEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "duree";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            // 
            // effectueeDataGridViewCheckBoxColumn
            // 
            this.effectueeDataGridViewCheckBoxColumn.DataPropertyName = "effectuee";
            this.effectueeDataGridViewCheckBoxColumn.HeaderText = "effectuee";
            this.effectueeDataGridViewCheckBoxColumn.Name = "effectueeDataGridViewCheckBoxColumn";
            // 
            // numImmaVehiculeDataGridViewTextBoxColumn
            // 
            this.numImmaVehiculeDataGridViewTextBoxColumn.DataPropertyName = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.HeaderText = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.Name = "numImmaVehiculeDataGridViewTextBoxColumn";
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
            // TaLecon
            // 
            this.TaLecon.ClearBeforeFill = true;
            // 
            // FrmLeconParEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 282);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblEleve);
            this.Controls.Add(this.cmbEleve);
            this.Name = "FrmLeconParEleve";
            this.Text = "Gestion des leçons";
            this.Load += new System.EventHandler(this.FrmLeconParEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLECONELEVEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEleve;
        private System.Windows.Forms.Label lblEleve;

        private System.Windows.Forms.Button btnValider;
    
        private ma_DataSet ma_DataSet1;
        private System.Windows.Forms.BindingSource bdgEleve;
        private ma_DataSetTableAdapters.ELEVETableAdapter TaEleve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKLECONELEVEBindingSource;
        private ma_DataSetTableAdapters.LECONTableAdapter lECONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn effectueeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numImmaVehiculeDataGridViewTextBoxColumn;
        private ma_DataSetTableAdapters.LECONTableAdapter TaLecon;
    }
}