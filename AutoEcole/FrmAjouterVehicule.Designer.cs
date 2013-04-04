namespace autoEcoleVS2005
{
    partial class FrmAjouterVehicule
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
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImma = new System.Windows.Forms.TextBox();
            this.txtModele = new System.Windows.Forms.TextBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.ma_DataSet1 = new autoEcoleVS2005.ma_DataSet();
            this.TaVehicule = new autoEcoleVS2005.ma_DataSetTableAdapters.VEHICULETableAdapter();
            this.TaQuery = new autoEcoleVS2005.ma_DataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(172, 197);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(118, 36);
            this.btnValider.TabIndex = 0;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Immatriculation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modèle :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Couleur :";
            // 
            // txtImma
            // 
            this.txtImma.Location = new System.Drawing.Point(141, 37);
            this.txtImma.Name = "txtImma";
            this.txtImma.Size = new System.Drawing.Size(149, 20);
            this.txtImma.TabIndex = 4;
            // 
            // txtModele
            // 
            this.txtModele.Location = new System.Drawing.Point(141, 88);
            this.txtModele.Name = "txtModele";
            this.txtModele.Size = new System.Drawing.Size(149, 20);
            this.txtModele.TabIndex = 5;
            this.txtModele.TextChanged += new System.EventHandler(this.txtModele_TextChanged);
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(141, 139);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(149, 20);
            this.txtCouleur.TabIndex = 6;
            // 
            // ma_DataSet1
            // 
            this.ma_DataSet1.DataSetName = "ma_DataSet";
            this.ma_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TaVehicule
            // 
            this.TaVehicule.ClearBeforeFill = true;
            // 
            // FrmAjouterVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 263);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.txtModele);
            this.Controls.Add(this.txtImma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmAjouterVehicule";
            this.Text = "FrmAjouterVehicule";
            ((System.ComponentModel.ISupportInitialize)(this.ma_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImma;
        private System.Windows.Forms.TextBox txtModele;
        private System.Windows.Forms.TextBox txtCouleur;
        private ma_DataSet ma_DataSet1;
        private ma_DataSetTableAdapters.VEHICULETableAdapter TaVehicule;
        private ma_DataSetTableAdapters.QueriesTableAdapter TaQuery;
    }
}