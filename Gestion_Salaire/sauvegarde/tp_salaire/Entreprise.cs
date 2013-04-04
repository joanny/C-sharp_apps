using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tp_salaire
{
    [System.Serializable]
    public class Entreprise
    {
        private string RaisonSociale;
        private ArrayList mesSalaries;

        public Entreprise( string leNom)
        {
            this.RaisonSociale = leNom; 
            this.mesSalaries = new ArrayList() ;
        }

        public Entreprise()
        {
            this.RaisonSociale = " ";
            this.mesSalaries = new ArrayList();
        }

        public ArrayList getMesSalaries()
        {
            return this.mesSalaries;
        }
        public string getRaisonSociale()
        {
            return this.RaisonSociale;
        }

        public void ajouteSalarie(Salarie leSalarie)
        {
           
            this.mesSalaries.Add(leSalarie);
        }

        public bool supprimerSalarie(string nomSalarie )
        {          
            bool exec = false;
            Salarie s = rechercher(nomSalarie);
             
                 if (s != null)
                 {                 
                    this.mesSalaries.Remove(s);
                    exec = true;
                 }
             
            return exec;
        }

        public Salarie rechercher(string Nom)
        {  
            Salarie leSalarie = null ;
            bool trouve = false;
            int i = 0;
            int nbSalaries =  this.mesSalaries.Count;
            while ((trouve != true) && (i < nbSalaries))
            {
                leSalarie = (Salarie)this.mesSalaries[i];
                if (leSalarie.getNomSalarie() == Nom)
                {
                    trouve = true;
                }
                else
                {
                    i++;
                }
            }
            if (trouve)
            {
                return leSalarie;
            }
            else
            {
                return null;
            } 
        }        
    }
}
