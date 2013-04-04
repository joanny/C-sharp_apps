using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace tp_salaire
{
    public class Parametre
    {
        public static double horaireMensuelLegal()
        {
            return 151.67;
        }
        public static double tauxHsTranche1()
        {
            return 1.25;
        }
        public static double tauxHsTranche2()
        {
            return 1.5;
        }
        public static double nbHSTranche1()
        {
            return 8;
        }
        public static double tauxRetenuSS()
        {
            return 0.074;
        }
        public static double tauxAssuranceChomage()
        {
            return 0.05;
        }
        public static double tauxTranche1Retraite()
        {
            return 0.03;
        }
        public static double tauxTranche2Retraite()
        {
            return 0.07;
        }
        public static double plafond1Retraite()
        {
            return 2476;
        }
        public static double plafond2Retraite()
        {
            return 7296;
        }
        public static double tauxRetenueCSG()
        {
            return 0.029;
        }
    }
}
