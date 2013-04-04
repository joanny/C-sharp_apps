using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleVS2005
{
    public partial class FrmAjouterVehicule : Form
    {
        public FrmAjouterVehicule()
        {
            InitializeComponent();
        }

        private void txtModele_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string num = txtImma.Text;
            string modele = txtModele.Text;
            string couleur = txtCouleur.Text;

            try
            {
                TaQuery.pVEHICULE_INSERT(num, modele, couleur);
            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }

        }
    }
}
