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
    public partial class Frm_menuEmployer : Form
    {
        private short? numUtilisateur;
        public Frm_menuEmployer(  short? numUtil )
        {
            InitializeComponent();
            this.numUtilisateur = numUtil;
        }
        public Frm_menuEmployer()
        {
            InitializeComponent();            
        }
        private void consulterMeesTâchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_consulterTaches ft = new Frm_consulterTaches(numUtilisateur);
            ft.ShowDialog();
            //Form2 l = new Form2(this.numUtilisateur);
            //l.Show();
           
          
        }

        private void Frm_menuEmployer_Load(object sender, EventArgs e)
        {
          
        }
    }
}
