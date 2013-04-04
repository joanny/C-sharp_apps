namespace autoEcoleVS2005
{
    partial class FrmToutLesVehicules
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
            this.ma_DataSet = new autoEcoleVS2005.ma_DataSet();
            this.vEHICULEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICULETableAdapter = new autoEcoleVS2005.ma_DataSetTableAdapters.VEHICULETableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.vEHICULEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(342, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // ma_DataSet
            // 
            this.ma_DataSet.DataSetName = "ma_DataSet";
            this.ma_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICULEBindingSource
            // 
            this.vEHICULEBindingSource.DataMember = "VEHICULE";
            this.vEHICULEBindingSource.DataSource = this.ma_DataSet;
            // 
            // vEHICULETableAdapter
            // 
            this.vEHICULETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numImma";
            this.dataGridViewTextBoxColumn1.HeaderText = "numImma";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "modele";
            this.dataGridViewTextBoxColumn2.HeaderText = "modele";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "couleur";
            this.dataGridViewTextBoxColumn3.HeaderText = "couleur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FrmToutLesVehicules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 251);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmToutLesVehicules";
            this.Text = "FrmToutLesVehicules";
            this.Load += new System.EventHandler(this.FrmToutLesVehicules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICULEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.DataGridViewTextBoxColumn numImmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ma_DataSet ma_DataSet;
        private System.Windows.Forms.BindingSource vEHICULEBindingSource;
        private ma_DataSetTableAdapters.VEHICULETableAdapter vEHICULETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}