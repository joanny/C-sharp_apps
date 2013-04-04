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
    public partial class Frm_AdminAcceuil : Form
    {
        private short? numAdmin;


        public Frm_AdminAcceuil(short? numAdmin)
        {
            InitializeComponent();
            this.numAdmin = numAdmin;                       
        }

        private void nouvelEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjouterUtilisateur f = new FrmAjouterUtilisateur();
            f.ShowDialog();
        }

        private void voirLesTachesEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Frm_ProgessionTaches fd = new Frm_ProgessionTaches(this.numAdmin);
            fd.ShowDialog();
        }

        private void nouvelTacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NouvelTaches fr = new Frm_NouvelTaches(this.numAdmin);
            fr.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_AdminAcceuil_Load(object sender, EventArgs e)
        {           
            this.tACHESTableAdapter.Fill(this.ma_dataSet.TACHES);
        }

       
    }
}
