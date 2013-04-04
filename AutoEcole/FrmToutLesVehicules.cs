using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleVS2005
{
    public partial class FrmToutLesVehicules : Form
    {
        public FrmToutLesVehicules()
        {
            InitializeComponent();
        }

        private void FrmToutLesVehicules_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ma_DataSet.VEHICULE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.vEHICULETableAdapter.Fill(this.ma_DataSet.VEHICULE);
            // TODO: cette ligne de code charge les données dans la table 'ma_DataSet1.VEHICULE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.vEHICULETableAdapter.Fill(this.ma_DataSet.VEHICULE);
             

        }

        private void bdgVehicule_CurrentChanged(object sender, EventArgs e)
        {
                    }
    }
}
