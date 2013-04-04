using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleVS2005
{
    public partial class FrmAjouterLecon : Form
    {
        public FrmAjouterLecon()
        {
            InitializeComponent();
            TaEleve.Fill(ma_DataSet1.ELEVE);
        }

        private void FrmAjouterLecon_Load(object sender, EventArgs e)
        {
            this.lECONTableAdapter.Fill(this.ma_DataSet1.LECON);
            for (int i = 8; i <= 20; i++)
                cmbHeure.Items.Add(i);
           
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            short num = Convert.ToInt16(cmbEleve.SelectedValue);
            DateTime? laDate = dtpDate.Value;
            short? heure = Convert.ToInt16(cmbHeure.Text);
            bool? effectuer = false;
            string numImma = cmbVehiculeDispo.SelectedValue.ToString();
            short duree;
            if (rdbUneHeure.Checked)
                duree = 1;
            else
                duree = 2;
            try
            {
                QueryTa.pLECON_INSERT(laDate, num, heure, duree, effectuer, numImma);
                MessageBox.Show("Réservation éffectuée ", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Verifier que l'éleve dispose de suffisament de crédit.", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void VehiculeDispo_Click(object sender, EventArgs e)
        {
            //int? heure = Convert.ToInt32(cmbHeure.SelectedItem);
            //DateTime dateLecon = dtpDate.Value;
            //DataTable dt = Ta_VEHICULE_Dispo.GetData(dateLecon, heure);
            //cmbVehiculeDispo.DataSource = dt;
            //cmbVehiculeDispo.DisplayMember = dt.Columns[1].ColumnName;
        }

        private void cmbHeure_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? heure = Convert.ToInt32(cmbHeure.SelectedItem);
            DateTime dateLecon = dtpDate.Value;
            DataTable dt = Ta_VEHICULE_Dispo.GetData(dateLecon, heure);
            cmbVehiculeDispo.DataSource = dt;
            cmbVehiculeDispo.DisplayMember = dt.Columns[1].ColumnName;
            lblNb.Text = dt.Rows.Count.ToString();
        }
    }
}
