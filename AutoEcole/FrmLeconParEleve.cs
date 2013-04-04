using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleVS2005
{
    public partial class FrmLeconParEleve : Form
    {
        public FrmLeconParEleve()
        {
           InitializeComponent();
 
        }

        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {        
            MessageBox.Show(cmbEleve.SelectedValue.ToString());
        }

        private void FrmLeconParEleve_Load(object sender, EventArgs e)
        {
            this.lECONTableAdapter.Fill(this.ma_DataSet1.LECON);
            this.TaEleve.Fill(this.ma_DataSet1.ELEVE);
           
        }
 
        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {             
                TaLecon.Update(ma_DataSet1.LECON);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
