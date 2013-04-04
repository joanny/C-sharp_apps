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
    public partial class Form2 : Form
    {
        private short? numUtilisateur;

        public Form2(short? numUtilisateur)
        {
            InitializeComponent();
            this.numUtilisateur = numUtilisateur;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            MessageBox.Show("ok");
            MessageBox.Show("ko");
            //short n = (short)this.numUtilisateur;
            //int nb = (int)queriesTableAdapter1.getService(n);
            //short? nv = Convert.ToInt16(nb);
            //DataTable dt = tachesTableAdapter1.GetDataByCodeService(nv);
            //MessageBox.Show(dt.Rows.Count.ToString());

            //dataGridView1.Rows.Add("Process 1", "okok", "1");
            //for (int i = 0; i <= 6; i++)
            //{
            //    dataGridView1.Rows.Add("Process 1", "okok", "1");
            //}   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
 
    }
}

 