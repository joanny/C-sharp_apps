using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autoEcoleVS2005
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void menuLecon_Click(object sender, EventArgs e)
        {          
            FrmLeconParEleve f = new FrmLeconParEleve();
            f.ShowDialog();
        }
 

        private void menuNouvelleLecon_Click(object sender, EventArgs e)
        {
             FrmAjouterLecon f = new FrmAjouterLecon();
             f.ShowDialog();
        }

        private void menuListe_Click(object sender, EventArgs e)
        {
            FrmToutLesVehicules f = new FrmToutLesVehicules();
            f.ShowDialog();
        }

        private void menuQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuNouveau_Click(object sender, EventArgs e)
        {
            FrmAjouterEleve f = new FrmAjouterEleve();
            f.ShowDialog();
        }

        private void menuGestion_Click(object sender, EventArgs e)
        {
            FrmAjouterVehicule f = new FrmAjouterVehicule();
            f.ShowDialog();
        }

        private void vehiculeIndispoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Fm_Vehiculedispo pl = new Fm_Vehiculedispo();
            pl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show("ok");
        }
    }
}