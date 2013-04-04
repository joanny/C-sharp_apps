namespace pti_gt
{
    partial class Frm_NouvelTaches
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.cmbSalarie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContenu = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtDateDebut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateFin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ma_dataSet = new pti_gt.ma_dataSet();
            this.serviceTableAdapter = new pti_gt.ma_dataSetTableAdapters.ServiceTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChargerSalarie = new System.Windows.Forms.Button();
            this.utilisateurTableAdapter1 = new pti_gt.ma_dataSetTableAdapters.UtilisateurTableAdapter();
            this.queriesTableAdapter1 = new pti_gt.ma_dataSetTableAdapters.QueriesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre :";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(101, 88);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(434, 20);
            this.txtTitre.TabIndex = 6;
            // 
            // cmbSalarie
            // 
            this.cmbSalarie.FormattingEnabled = true;
            this.cmbSalarie.Location = new System.Drawing.Point(101, 56);
            this.cmbSalarie.Name = "cmbSalarie";
            this.cmbSalarie.Size = new System.Drawing.Size(120, 21);
            this.cmbSalarie.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salariés :";
            // 
            // txtContenu
            // 
            this.txtContenu.Location = new System.Drawing.Point(101, 128);
            this.txtContenu.Multiline = true;
            this.txtContenu.Name = "txtContenu";
            this.txtContenu.Size = new System.Drawing.Size(434, 107);
            this.txtContenu.TabIndex = 9;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(308, 247);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Location = new System.Drawing.Point(110, 42);
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(100, 20);
            this.txtDateDebut.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date de début :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date de fin :";
            // 
            // txtDateFin
            // 
            this.txtDateFin.Location = new System.Drawing.Point(110, 90);
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(100, 20);
            this.txtDateFin.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDateDebut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDateFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(48, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 168);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Délais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mission :";
            // 
            // cmbService
            // 
            this.cmbService.DataSource = this.serviceBindingSource;
            this.cmbService.DisplayMember = "libelle";
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(100, 26);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(121, 21);
            this.cmbService.TabIndex = 17;
            this.cmbService.ValueMember = "codeService";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.ma_dataSet;
            // 
            // ma_dataSet
            // 
            this.ma_dataSet.DataSetName = "ma_dataSet";
            this.ma_dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Service :";
            // 
            // btnChargerSalarie
            // 
            this.btnChargerSalarie.Location = new System.Drawing.Point(237, 26);
            this.btnChargerSalarie.Name = "btnChargerSalarie";
            this.btnChargerSalarie.Size = new System.Drawing.Size(131, 26);
            this.btnChargerSalarie.TabIndex = 19;
            this.btnChargerSalarie.Text = "Charger les salariés";
            this.btnChargerSalarie.UseVisualStyleBackColor = true;
            this.btnChargerSalarie.Click += new System.EventHandler(this.btnChargerSalarie_Click);
            // 
            // utilisateurTableAdapter1
            // 
            this.utilisateurTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_NouvelTaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 460);
            this.Controls.Add(this.btnChargerSalarie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtContenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSalarie);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Frm_NouvelTaches";
            this.Text = "Nouvelle tache";
            this.Load += new System.EventHandler(this.Frm_NouvelTaches_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.ComboBox cmbSalarie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContenu;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtDateDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateFin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbService;
        private ma_dataSet ma_dataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private ma_dataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChargerSalarie;
        private ma_dataSetTableAdapters.UtilisateurTableAdapter utilisateurTableAdapter1;
        private ma_dataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}