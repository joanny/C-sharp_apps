using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace tp_salaire
{
    class Ecran
    {
        public static void afficher(Bulletin unBulletin)
        {
            string salaireBase = Convert.ToString(unBulletin.salaireBase());
            string nbHeureSup = Convert.ToString(unBulletin.nbHS());
            string montantHs = Convert.ToString(unBulletin.MontantHS());
            string salaireBrut = Convert.ToString(unBulletin.salaireBrut());
            string retenueSS = Convert.ToString(unBulletin.retenueSS());
            string retenueChomage = Convert.ToString(unBulletin.retenueChomage());
            string retenueRetraite = Convert.ToString(unBulletin.retenueRetraite());
            string retenuesTotales = Convert.ToString(unBulletin.retenueTotales());
            string salaireNet = Convert.ToString(unBulletin.salaireNet());
            string retenueCSG = Convert.ToString(unBulletin.retenueCSG());

            Console.WriteLine("salaire de base: " + salaireBase);
            Console.WriteLine("nombre HS:" + nbHeureSup);
            Console.WriteLine("montant HS:" + montantHs);
            Console.WriteLine("salaire brut:" + salaireBrut);
            Console.WriteLine("retenue securite sociale:" + retenueSS);
            Console.WriteLine("retenue chomage: " + retenueChomage);
            Console.WriteLine("retenue Csg :" + retenueCSG);
            Console.WriteLine("retenue retraite :" + retenueRetraite);
            Console.WriteLine("retenues Totales:" + retenuesTotales);
            Console.WriteLine("salaire net :" + salaireNet);
        }
        public static void afficher(Salarie s)
        {
            string leNom = Convert.ToString(s.getNomSalarie());
            string leSalaire = Convert.ToString(s.salaireAnnuel());
            Console.WriteLine("Nom :" + leNom);
            Console.WriteLine("salaraire annuel:"+ leSalaire);
        }
        public static void AfficheEntreprise(Entreprise e)
        {
            int i = 1;
            foreach (Salarie s in e.getMesSalaries())
            {
                string lenom  = (string)s.getNomSalarie();
                Convert.ToString(s.getNomSalarie());
                Console.WriteLine("nom Salarie n°" + i + ":" + lenom );
                i++;
            }
        }
        public static void AfficherNomSalarie( Salarie s)
        {
            string leNom = Convert.ToString(s.getNomSalarie());
            string leSalaire = Convert.ToString(s.salaireAnnuel());
            Console.WriteLine("Nom :" + leNom);             
        }
     }
}
