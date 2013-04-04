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
    
    public partial class Form1 : Form
    {

        private short? numUtilisateur;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.serviceTableAdapter.Fill(this.ma_dataSet.Service);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string identifiant = txtIdentifiant.Text;
            string mp = txtMotDePasse.Text;
            int? nbUtil = 0;
            try
            {
                if (rdbEmploye.Checked == true)
                {
                    nbUtil = queriesTableAdapter1.connectionUtilisateur(identifiant, mp);
                    if (nbUtil != 0)
                    {
                        numUtilisateur = queriesTableAdapter1.getCodeUtilisateur(identifiant, mp);
                        Frm_menuEmployer fd = new Frm_menuEmployer(numUtilisateur);
                        fd.ShowDialog(); 
                       
                    }
                }
                else
                {
                    if (rdbAdministrateur.Checked)
                    {
                        nbUtil = queriesTableAdapter1.connectionAdmin(identifiant, mp);
                        if (nbUtil != 0)
                        {
                            numUtilisateur = (short)queriesTableAdapter1.getCodeAdmin(identifiant, mp);
                            Frm_AdminAcceuil fr = new Frm_AdminAcceuil(this.numUtilisateur);
                            fr.ShowDialog();
 
                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (nbUtil == 0)
             {
              
                labelER.Visible = true;
                labelER.Text = "Informations incorrectes.Veuillez recommencer.";
                labelER.ForeColor = Color.Red;
            }
        }   
    }
    
}
