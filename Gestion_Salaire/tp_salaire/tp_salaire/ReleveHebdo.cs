using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace tp_salaire
{
    [System.Serializable] 
   public class ReleveHebdo
    {
        private int NumReleve;
        private double nbHeure;

        public ReleveHebdo(int num, double nbHeure)
        {
            this.NumReleve = num;
            this.nbHeure = nbHeure;
        }
         public double getNbHeure()
        {
            return nbHeure;
        }       
    }
}
