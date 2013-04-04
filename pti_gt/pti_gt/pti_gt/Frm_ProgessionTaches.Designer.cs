namespace pti_gt
{
    partial class Frm_ProgessionTaches
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProgessionTaches));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Progress = new Sample.DataGridViewProgressColumn();
            this.dataGridViewProgressColumn1 = new Sample.DataGridViewProgressColumn();
            this.tachesTableAdapter1 = new pti_gt.ma_dataSetTableAdapters.TACHESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.Contenu,
            this.aa,
            this.Column1,
            this.Progress});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(744, 50);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Objet";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.ReadOnly = true;
            // 
            // Contenu
            // 
            this.Contenu.HeaderText = "Contenu";
            this.Contenu.Name = "Contenu";
            this.Contenu.ReadOnly = true;
            // 
            // aa
            // 
            this.aa.HeaderText = "Date Début ";
            this.aa.Name = "aa";
            this.aa.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date Fin";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Progress
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.Progress.DefaultCellStyle = dataGridViewCellStyle1;
            this.Progress.HeaderText = "Progress [%]";
            this.Progress.Name = "Progress";
            this.Progress.ProgressBarColor = System.Drawing.Color.Lime;
            this.Progress.ReadOnly = true;
            this.Progress.Width = 200;
            // 
            // dataGridViewProgressColumn1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.dataGridViewProgressColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProgressColumn1.HeaderText = "Progress [%]";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            this.dataGridViewProgressColumn1.ProgressBarColor = System.Drawing.Color.Lime;
            this.dataGridViewProgressColumn1.ReadOnly = true;
            this.dataGridViewProgressColumn1.Width = 200;
            // 
            // tachesTableAdapter1
            // 
            this.tachesTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_ProgessionTaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 354);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_ProgessionTaches";
            this.Text = "Evolution des taches";
            this.Load += new System.EventHandler(this.Frm_ProgessionTaches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ma_dataSetTableAdapters.TACHESTableAdapter tachesTableAdapter1;
        private Sample.DataGridViewProgressColumn dataGridViewProgressColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn aa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Sample.DataGridViewProgressColumn Progress;
    }
}