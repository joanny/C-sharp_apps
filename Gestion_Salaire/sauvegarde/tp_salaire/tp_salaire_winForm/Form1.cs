using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tp_salaire;

namespace tp_salaire_winForm
{
    public partial class Form1 : Form
    {
        private Salarie leSalarie;
        
        public Form1(Salarie s)
        {
            InitializeComponent();
            this.leSalarie = s;         
            
        }

        private void bulletinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bulletinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             Salarie s = PersisteSalarie.charge("Salarie.txt");
        }
        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.leSalarie = PersisteSalarie.charge("Salarie.txt");
        }

        private void donnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leFormulaire f = new leFormulaire();
            f.Show();
        }
    }
}
