namespace pti_gt
{
    partial class Frm_AdminLesTaches
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.objetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tachesparutilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ma_dataSet = new pti_gt.ma_dataSet();
            this.taches_par_utilTableAdapter = new pti_gt.ma_dataSetTableAdapters.taches_par_utilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tachesparutilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objetDataGridViewTextBoxColumn,
            this.contenuDataGridViewTextBoxColumn,
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tachesparutilBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // objetDataGridViewTextBoxColumn
            // 
            this.objetDataGridViewTextBoxColumn.DataPropertyName = "objet";
            this.objetDataGridViewTextBoxColumn.HeaderText = "objet";
            this.objetDataGridViewTextBoxColumn.Name = "objetDataGridViewTextBoxColumn";
            // 
            // contenuDataGridViewTextBoxColumn
            // 
            this.contenuDataGridViewTextBoxColumn.DataPropertyName = "contenu";
            this.contenuDataGridViewTextBoxColumn.HeaderText = "contenu";
            this.contenuDataGridViewTextBoxColumn.Name = "contenuDataGridViewTextBoxColumn";
            // 
            // dateDebutDataGridViewTextBoxColumn
            // 
            this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "dateDebut";
            this.dateDebutDataGridViewTextBoxColumn.HeaderText = "dateDebut";
            this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
            // 
            // dateFinDataGridViewTextBoxColumn
            // 
            this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "dateFin";
            this.dateFinDataGridViewTextBoxColumn.HeaderText = "dateFin";
            this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            // 
            // tachesparutilBindingSource
            // 
            this.tachesparutilBindingSource.DataMember = "taches_par_util";
            this.tachesparutilBindingSource.DataSource = this.ma_dataSet;
            // 
            // ma_dataSet
            // 
            this.ma_dataSet.DataSetName = "ma_dataSet";
            this.ma_dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taches_par_utilTableAdapter
            // 
            this.taches_par_utilTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_AdminLesTaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 267);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_AdminLesTaches";
            this.Text = "Frm_AdminLesTaches";
            this.Load += new System.EventHandler(this.Frm_AdminLesTaches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tachesparutilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tachesparutilBindingSource;
        private ma_dataSet ma_dataSet;
        private ma_dataSetTableAdapters.taches_par_utilTableAdapter taches_par_utilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn objetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;



    }
}