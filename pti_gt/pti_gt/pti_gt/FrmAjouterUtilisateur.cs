using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pti_gt
{
    public partial class FrmAjouterUtilisateur : Form
    {
        public FrmAjouterUtilisateur()
        {
            InitializeComponent();
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            short? numService =   Convert.ToInt16(cmbService.SelectedValue);
 
            try
            {
                TaQuery.pUtilisateur_INSERT(txtNom.Text, txtPrenom.Text, txtPoste.Text,numService , txtIdentifiant.Text, txtMdp.Text  );
               
            }
            catch (Exception ex )
            {
                 MessageBox.Show(ex.Message);
            }                         
        }

        private void FrmAjouterUtilisateur_Load(object sender, EventArgs e)
        {           
            this.serviceTableAdapter.Fill(this.ma_dataSet.Service);
        }

    }
}
