using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tp_salaire
{
    public class MesMenus
    {
     
        
        public static void  Menu()
        {
            Console.WriteLine("Ajouter un Salarié :(a)");
            Console.WriteLine("Charger un Salarié :(b)");
            Console.WriteLine("Rechercher un Salarié :(c)");
            Console.WriteLine("Voir tous les Salariés :(d)");
            Console.WriteLine("Supprimer un Salarié :(e)");
        }
  
        public static void afficherMenuSalarie()
        {          
            Console.WriteLine("Ajouter un  bulletin :(a)");
            Console.WriteLine("Consulter un bulletin : (b)");                      
        }

        public static void TraitementSalarie(char c , Salarie salarie)
        {
            switch (c)
            {
                case 'a':
                    {
                        Console.WriteLine("Numero de mois :");
                        int numMois = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Base salariale :");
                        double salaireH = Convert.ToInt32(Console.ReadLine());
                        Bulletin b = new Bulletin(numMois, salaireH);
                        Console.WriteLine("Voici le bulletin n° " + numMois);
                        Ecran.afficher(b);
                        Console.WriteLine("Ajouter les relevés ");
                        char choix = Console.ReadLine()[0];
                        if (choix == 'a')
                        {
                            MesMenus.AjouterRelever(b);
                        }
                        else
                        {
                            MesMenus.afficherMenuSalarie();
                        }
                            break;
                    }
                case 'b':
                    {
                        Console.WriteLine("aaa");
                        break;
                    }
                case 'q':
                    {

                         
                        Console.WriteLine("au revoir...");
                        break;
                    } 
            }
        }
      
        public static void AjouterRelever(Bulletin b)
        {
            int a = 1; 
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Relever n° " + a );
                Console.WriteLine("Saisir le nombre d'heure :");
                double nbh = Convert.ToDouble(Console.ReadLine());
                b.ajouterReleve(i,nbh);
                a++;
            }          
            //PersisteSalarie.sauveEntreprise(uneEntreprise);         
        }
        public static void MenuPrincipale(char c)// menu acceuil
        {             
            string nom;
            char choix;
            Salarie salarie;
            Entreprise uneEntreprise = Donnees.chargeEntreprise();
            
            switch (c)
            {
                case 'a'://ajouter un salarie 
                    {                         
                        Console.WriteLine("Nom :");
                        nom = Console.ReadLine();
                        salarie = new Salarie(nom);
                        uneEntreprise.ajouteSalarie(salarie);
                        Donnees.sauveEntreprise(uneEntreprise);
                        break;
                    }
                case 'b': // charger un salarie 
                    {
                        Console.WriteLine("saisir le nom : ");
                        nom = Console.ReadLine(); 
                        salarie = uneEntreprise.rechercher(nom);
                        while (salarie == null)
                        {
                            Console.WriteLine("nom incorrect: ");
                            Console.WriteLine("saisir le nom  : ");
                            nom = Console.ReadLine();
                            salarie = uneEntreprise.rechercher(nom);                           
                        }                        
                        if (salarie != null)
                        {
                            Console.WriteLine("Le salarie " + salarie.getNomSalarie() + "  à été charger");
                            Ecran.AfficherNomSalarie(salarie);
                            MesMenus.afficherMenuSalarie();
                            choix = Console.ReadLine()[0];
                            MesMenus.TraitementSalarie(choix, salarie);
                        }                                                              
                        break;
                    }
                case 'c':// rechercher un salarié
                    {
                        MesMenus.Menu();
                        Console.WriteLine("Nom du salarie :");
                        nom = Console.ReadLine();
                        salarie = uneEntreprise.rechercher(nom);                       
                        Ecran.AfficherNomSalarie(salarie);
                        Console.WriteLine("Bulletins");
                        foreach ( Bulletin b in salarie.getLesBulletins())
                        {
                            Console.WriteLine(" |   Mois n°" + b.getNumMois() + "|");
                            Console.WriteLine("|_______________________|");
                            Ecran.afficher(b);
                        }
                        break;
                    }
                case 'd': // voir les salaries 
                    {
                        MesMenus.Menu();
                        Console.WriteLine("Tout Les salariés");
                        int i = 0;
                        foreach (Salarie s in uneEntreprise.getMesSalaries())
                        {
                            i++;                            
                            Console.Write("n°:{0}",i +"  " ); 
                            Ecran.AfficherNomSalarie(s);
                        }                         
                        break;
                    }
                case 'e': // supprimer un salarie
                    {
                        MesMenus.Menu();
                        Console.WriteLine("Nom:");
                        nom = Console.ReadLine();                        
                        uneEntreprise.supprimerSalarie(nom);
                        Donnees.sauveEntreprise(uneEntreprise);
                        MesMenus.Menu();
                        choix  = Console.ReadLine()[0];                                           
                        break;
                    }
                case 'q': //quitter
                    {                        
                        Donnees.sauveEntreprise(uneEntreprise);
                        Console.WriteLine("au revoir...");
                        break;                        
                    }                   
            }
        }
    }
}
