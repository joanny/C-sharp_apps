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
    public partial class Frm_NouvelTaches : Form
    {
        private short? numAdmin;

        public Frm_NouvelTaches()
        {
            InitializeComponent();
        }
        public Frm_NouvelTaches(short? numAdmin)
        {
            InitializeComponent();
            this.numAdmin = numAdmin;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if ( txtDateDebut.Text == "" )
            {
                txtDateDebut.Text = monthCalendar1.SelectionStart.ToShortDateString();
            }
            else
            {
                txtDateFin.Text = monthCalendar1.SelectionStart.ToShortDateString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = Convert.ToDateTime(txtDateDebut.Text);
            DateTime dateFin = Convert.ToDateTime(txtDateFin.Text);
            short? numSalarie = Convert.ToInt16(cmbSalarie.SelectedValue.ToString());
            short? etat = Convert.ToInt16(1);
            
            try
            {
                queriesTableAdapter1.pTaches_INSERT(txtTitre.Text, txtContenu.Text, dateDebut, dateFin, numSalarie, etat , this.numAdmin);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                 
            }            
        }

        private void Frm_NouvelTaches_Load(object sender, EventArgs e)
        {            
            this.serviceTableAdapter.Fill(this.ma_dataSet.Service);
        }

        private void btnChargerSalarie_Click(object sender, EventArgs e)
        {
            short? numService = Convert.ToInt16(cmbService.SelectedValue.ToString());
            try
            {                 
                 cmbSalarie.DataSource = utilisateurTableAdapter1.GetDataBy(numService);
                 cmbSalarie.DisplayMember = "nom";
                 cmbSalarie.ValueMember = "codeUtilisateur";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}