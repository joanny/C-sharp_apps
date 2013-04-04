namespace pti_gt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridViewProgressColumn1 = new Sample.DataGridViewProgressColumn();
            this.queriesTableAdapter1 = new pti_gt.ma_dataSetTableAdapters.QueriesTableAdapter();
            this.tachesTableAdapter1 = new pti_gt.ma_dataSetTableAdapters.TACHESTableAdapter();
            this.SuspendLayout();
            // 
            // dataGridViewProgressColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.dataGridViewProgressColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProgressColumn1.HeaderText = "Progress [%]";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            this.dataGridViewProgressColumn1.ProgressBarColor = System.Drawing.Color.Lime;
            this.dataGridViewProgressColumn1.ReadOnly = true;
            // 
            // tachesTableAdapter1
            // 
            this.tachesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 313);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sample.DataGridViewProgressColumn dataGridViewProgressColumn1;
        private ma_dataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private ma_dataSetTableAdapters.TACHESTableAdapter tachesTableAdapter1;



    }
}