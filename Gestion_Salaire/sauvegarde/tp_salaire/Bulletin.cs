using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace tp_salaire
{
    [System.Serializable]
    public class Bulletin
    {
        private int numMois;
        private double salaireHoraireBase;
        private ArrayList mesReleves = new ArrayList();                
//constructeurs //        
        public Bulletin ( int leNum , double leSalaireHoraireBase  )
        {
            this.numMois = leNum;
            this.salaireHoraireBase = leSalaireHoraireBase;
            this.mesReleves  = new ArrayList();
        }
        public Bulletin()
        {
            this.numMois = 0;
            this.salaireHoraireBase = 0;
             this.mesReleves =  new ArrayList(); 
        }
// Fin constructeurs // 
        public double  salaireBase()
        { 
            double sal = this.salaireHoraireBase * Parametre.horaireMensuelLegal();
            return sal;
        }
        public double nbHS()
        {
            double nbheures;
            nbheures = 0;            
            foreach ( ReleveHebdo b in  this.mesReleves )
            {
                nbheures = nbheures + b.getNbHeure();                 
            }
            nbheures = nbheures - Parametre.horaireMensuelLegal();             
            if (nbheures < 0)
            {
                nbheures = 0;
            }
            return nbheures;
        }
        public double MontantHS()
        {
            double nbH = this.nbHS();
            double montant = 0;
            if (this.nbHS() < Parametre.nbHSTranche1())
            {
                montant = (this.nbHS() * (Parametre.tauxHsTranche1() * this.salaireHoraireBase));
            }
            else
            {               
                montant =  (8  * (Parametre.tauxHsTranche1() * this.salaireHoraireBase));
                montant = montant + ((nbH-8) * (Parametre.tauxHsTranche2() * this.salaireHoraireBase));
            }
            return montant;
        }
        public double salaireBrut()
        {
            double salaireBrut;
            salaireBrut =  salaireBase() + MontantHS();
            return salaireBrut;
        }
        public double retenueSS()
        {
            double retenueSecu = Parametre.tauxRetenuSS() * this.salaireBrut();
            return retenueSecu;
        }
        public double retenueChomage()
        {
            double retenueChomage = Parametre.tauxAssuranceChomage() * this.salaireBrut();
            return retenueChomage;
        }
        public double retenueRetraite()
        {
            double salairebrut = salaireBrut();
            double montantCotisation;
            if (salairebrut < Parametre.plafond1Retraite())
            {
                montantCotisation = salairebrut * Parametre.tauxTranche1Retraite();
            }
            else
            {
                 montantCotisation = Parametre.plafond1Retraite() * Parametre.tauxTranche1Retraite();
                 montantCotisation = montantCotisation  + ((salairebrut - Parametre.plafond1Retraite()) * Parametre.tauxTranche2Retraite());
            }                  
            return montantCotisation;
        }
        public double retenueTotales()
        {
            double totaleRetenues = retenueChomage() + retenueRetraite() + retenueSS() + retenueCSG();
            return totaleRetenues;
        }
        public double salaireNet()
        {
            double salairebrut = this.salaireBrut();
            double salaireNet = salairebrut - this.retenueTotales();
            return salaireNet;
        }
        public double retenueCSG()
        {
            double salairebrut = salaireBrut();
            double retenuecsg = salairebrut * Parametre.tauxRetenueCSG();
            return retenuecsg;
        }
        public void ajouterReleve(int num, double nbHeure)
        {
            ReleveHebdo b = new ReleveHebdo (num,nbHeure);
            this.mesReleves.Add(b);
        }
        public int getNumMois()
        {
            return this.numMois;
        }
    }
}
