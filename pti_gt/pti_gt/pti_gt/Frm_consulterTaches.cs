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
    public partial class Frm_consulterTaches : Form
    {
        private short? numUtilisateur;
        public Frm_consulterTaches(short?  numUtilisateur)
        {
            InitializeComponent();
            this.numUtilisateur = numUtilisateur;
        }

        private void Frm_consulterTaches_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ma_dataSet.TACHES'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.tACHESTableAdapter.Fill(this.ma_dataSet.TACHES);
            this.taches_par_utilTableAdapter1.Fill(this.ma_dataSet1.taches_par_util, this.numUtilisateur);

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
                short? num = Convert.ToInt16(txtP.Text);
                short? numTache = Convert.ToInt16(txtCodeTache.Text); 
                try
                {                    
                    queriesTableAdapter1.UpdateTache(numTache, num);
                    progressBar1.Value = Convert.ToInt32(num);
                    progressBar1.Maximum = 100;
                    progressBar1.Minimum = 0;
                 }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                taches_par_utilTableAdapter1.Update(ma_dataSet1.taches_par_util);
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message);
            }
        }    
    }
}
