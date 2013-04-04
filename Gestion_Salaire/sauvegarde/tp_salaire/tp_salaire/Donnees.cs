using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tp_salaire
{
    class Donnees
    {
        public static Entreprise chargeEntreprise()
        {
            Entreprise uneEntreprise = PersisteSalarie.chargeEntreprise("uneEntreprise.txt");
            return uneEntreprise;
        }
        public static void sauveEntreprise(Entreprise e)
        {
            PersisteSalarie.sauveEntreprise(e);
        }
    }
}
