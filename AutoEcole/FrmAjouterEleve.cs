using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleVS2005
{
    public partial class FrmAjouterEleve : Form
    {
        public FrmAjouterEleve()
        {
            InitializeComponent();

        }

        private void FrmAjouterEleve_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 45; i = i + 5)
            {
                cmbForfaitH.Items.Add(i);
            }

        }

        private void btnAjouter_Eleve_Click(object sender, EventArgs e)
        {

            string nom = txtNom.Text;
            DateTime? dt = Convert.ToDateTime(txtDateInscription.Text);
            string prenom = txtPrenom.Text;
            int? forfait = Convert.ToInt32(cmbForfaitH.SelectedItem);
            string adresse = txtAdresse.Text;
            int? ok = 0 ; 
            try
            {
                 TaQuery.pEleve_INSERT(nom, dt, prenom, adresse, forfait , ref ok );
                 if (ok != 0)
                 {
                     MessageBox.Show("l'élèves existe.");
                 }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calendrier_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDateInscription.Text = calendrier.SelectionStart.ToShortDateString();
        }


    }
}
