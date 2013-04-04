using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tp_salaire
{
    public class MesMenus
    {
        public static void enTete()
        {
            Console.Clear();
            Entreprise uneEntreprise = Donnees.chargeEntreprise();
            Console.WriteLine("_________________________________" + uneEntreprise.getRaisonSociale() + "_________________________________________");
            Console.WriteLine("");
            Console.WriteLine("________________________***__GESTION DES SALARIES__***_________________________");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("");
        }
        public static void Menu()
        {
            Console.WriteLine("___________________________Ajouter un Salarié:(a)______________________________");
            Console.WriteLine("___________________________Charger un Salarié:(b)______________________________");
            Console.WriteLine("___________________________Rechercher un Salarié:(c)___________________________");
            Console.WriteLine("___________________________Voir tous les Salariés:(d)__________________________");
            Console.WriteLine("___________________________Supprimer un Salarié:(e)____________________________");
            Console.WriteLine("___________________________Sauvegarder et quitter:(q)__________________________");
        }
        public static void afficherMenuSalarie()
        {
            Console.WriteLine("_________________________Ajouter un  bulletin:(a)______________________________");
            Console.WriteLine("_________________________Consulter les bulletins:(b)___________________________");
            Console.WriteLine("_________________________Retour au menu principal:(q)__________________________");
        }
        public static void TraitementSalarie(char c, Salarie salarie, Entreprise e)
        {
            bool continuer = true;
            switch (c)
            {
                //Minuscule 
                case 'a':  // ajouter un bulletin 
                    {
                        while (continuer == true)
                        {
                            Console.WriteLine("Ajouter un bulletin:");
                            int numMois = salarie.mesBulletins.Count;
                            Console.WriteLine("Base salariale :");
                            double salaireH = Convert.ToInt32(Console.ReadLine());

                            Bulletin b = new Bulletin(numMois + 1, salaireH);
                            int n = numMois + 1;
                            Console.WriteLine("Bulletin n° " + n);
                            Console.WriteLine("_________________________Souhaitez vous ajouter les relevés ? (o/n)______________________________");
                            char choix = (char)Console.Read();
                            if (choix == 'o')
                            {
                                MesMenus.AjouterRelever(b);
                                salarie.ajouterBulletin(b);
                                Donnees.sauveEntreprise(e);
                                Ecran.afficher(b);
                            }
                            else
                            {
                                MesMenus.afficherMenuSalarie();
                            }
                            Console.WriteLine("Souhaitez vous ajouter un nouveau bulletin ? (o/n)");
                            choix = Console.ReadLine()[0];
                            if (choix != 'o')
                            {
                                continuer = false;
                                MesMenus.afficherMenuSalarie();
                            }
                        }
                        break;
                    }
                case 'b': // consulter les bulletins 
                    {
                        Console.WriteLine("Les bulletins:");
                        salarie = e.rechercher(salarie.getNomSalarie());
                        Ecran.AfficherNomSalarie(salarie);
                        Console.WriteLine("Bulletins");
                        foreach (Bulletin b in salarie.getLesBulletins())
                        {
                            Console.WriteLine("Mois n°" + b.getNumMois());
                            Console.WriteLine("*******************");
                            Ecran.afficher(b);
                            Console.WriteLine("*******************");
                        }
                        Ecran.afficher(salarie);
                        Console.WriteLine("*******************");
                        Console.WriteLine("Retour au menu principal (q)");
                        Console.WriteLine("Retour au menu salarie (r)");                        
                        char choix = (char)Console.Read();                        
                        MesMenus.TraitementSalarie(choix, salarie, e);                        
                        break;
                    }
                case 'q':  // quitter
                    {
                        Console.Clear();
                        MesMenus.enTete();
                        MesMenus.Menu();
                        char choix = (char)Console.Read(); 
                        MesMenus.MenuPrincipale(choix);
                        break;
                    }
                case 'r':
                    {
                        Console.Clear();
                        MesMenus.enTete();
                        MesMenus.afficherMenuSalarie();
                        char choix = (char)Console.Read();
                        MesMenus.TraitementSalarie(choix, salarie, e);
                        break;
                    }         
                default:
                    {
                        MesMenus.afficherMenuSalarie();
                        char choix = (char)Console.Read();
                        MesMenus.TraitementSalarie(choix, salarie, e);
                        break;
                    }
            }
        }
        public static void AjouterRelever(Bulletin b)
        {
            int a = 1;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("__Relever n° " + a);
                Console.WriteLine("_______Saisir le nombre d'heure :");
                double nbh = Convert.ToDouble(Console.ReadLine());
                b.ajouterReleve(i, nbh);
                a++;
            }
        }
        public static void MenuPrincipale(char c)// menu acceuil
        {
            string nom;
            char choix;
            Salarie salarie;
            Entreprise uneEntreprise = Donnees.chargeEntreprise();
            // entreprise = Donnees.chargeEntreprise();
            //    MesMenus.enTete(); 
            switch (c)
            {
                case 'a':               //ajouter un salarie 
                    {
                        do
                        {
                            MesMenus.enTete();
                            Console.WriteLine("Ajouter un salarie:");
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                        }
                        while (nom == "");

                        Salarie Existesalarie = uneEntreprise.rechercher(nom);
                        while (Existesalarie != null)
                        {
                            Console.WriteLine("Ce salarie à déja été ajouter:");
                            Console.WriteLine("Ressaisir le nom ?(o/n):");
                            choix = (char)Console.Read();
                            if (choix == 'o')
                            {
                                Console.WriteLine("Nom:");
                                nom = Console.ReadLine();
                            }
                            else
                            {
                                MesMenus.Menu();
                                choix = (char)Console.Read();
                                MesMenus.MenuPrincipale(choix);
                            }
                            Existesalarie = uneEntreprise.rechercher(nom);
                        }
                        if (Existesalarie == null)
                        {
                            salarie = new Salarie(nom);
                            uneEntreprise.ajouteSalarie(salarie);
                            Donnees.sauveEntreprise(uneEntreprise);
                            Console.WriteLine("Le salarie " + salarie.getNomSalarie() + "  à été charger avec succès");
                            Ecran.AfficherNomSalarie(salarie);
                            MesMenus.afficherMenuSalarie();
                            choix = Console.ReadLine()[0];
                            MesMenus.TraitementSalarie(choix, salarie, uneEntreprise);
                        }                                   

                        break;
                    }
                case 'b': // charger un salarie 
                    {
                           
                            Console.WriteLine("_________________________________Charger un salarie_____________________________");
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                            salarie = uneEntreprise.rechercher(nom);
                            while (salarie == null)
                            {
                                Console.WriteLine("ressaisir le nom :");
                                nom = Console.ReadLine();
                                salarie = uneEntreprise.rechercher(nom);
                            }
                            if (salarie != null)
                            {
                                Ecran.afficher(salarie);
                            }

                          


                            //if (Existesalarie != null)
                            //{
                            //    MesMenus.enTete();
                            //    Console.WriteLine("_______________________________________________________________________________");
                            //    Console.WriteLine("");
                            //    Console.WriteLine("__________________Le salarie  " + salarie.getNomSalarie() + "   à été charger avec succès_________________");
                            //    Console.WriteLine("_______________________________________________________________________________");
                            //    //Ecran.AfficherNomSalarie(salarie);
                            //    Console.WriteLine("");
                            //    MesMenus.afficherMenuSalarie();
                            //    choix = (char)Console.Read();
                            //    MesMenus.TraitementSalarie(choix, salarie, uneEntreprise);
                            //}
                        
                           break;

                        
                       
                    }
                case 'c': // rechercher un salarié
                    {
                        #region 
                        Console.WriteLine("_________________________________Rechercher un salarie_____________________________");
                        bool continuer = true;
                        bool exec = false;
                        salarie = new Salarie("aa");
                        Console.WriteLine("Nom:");
                        do
                        {                         
                            nom = Console.ReadLine();
                            salarie = uneEntreprise.rechercher(nom);
                            if ((salarie == null) && ( exec == true))
                            {
                                Console.WriteLine("Voulez vous ressaisir ?");
                                choix = (char)Console.Read();
                                if (choix == 'o')
                                {
                                    Console.WriteLine("Nom:");
                                    nom = Console.ReadLine();
                                }
                                else
                                {
                                    MesMenus.enTete();
                                    MesMenus.Menu();
                                    choix = (char)Console.Read();
                                    MesMenus.MenuPrincipale(choix);
                                }
                            }
                            exec = true;
                        }
                        while (( salarie == null) && (continuer == true) && (nom == " "));                                                     
                        
                        #endregion
                        #region commentaire
                        //     Console.WriteLine("Aucun salarie porte ce nom , ressaisir (o/n):");
                        //           choix = (char)Console.Read();
                        //           if (choix == 'o')
                        //           {
                        //               Console.WriteLine("Saisir le nom: ");
                        //               nom = Console.ReadLine();
                        //               salarie = uneEntreprise.rechercher(nom);
                        //           }
                        //           else
                        //           {
                        //               Console.Clear();
                        //               MesMenus.enTete();
                        //               MesMenus.Menu();
                        //               choix = (char)Console.Read();
                        //               MesMenus.MenuPrincipale(choix);
                        //           }
                        //}
                        //   while (salarie == null)
                        //   {
                        //       Console.WriteLine("Aucun salarie porte ce nom , ressaisir (o/n):");
                        //       choix = (char)Console.Read();
                        //       if (choix == 'o')
                        //       {
                        //           Console.WriteLine("Nom du salarie:");
                        //           nom = Console.ReadLine();
                        //       }
                        //       else
                        //       {
                        //           MesMenus.Menu();
                        //           choix = (char)Console.Read();
                        //           MesMenus.MenuPrincipale(choix);
                        //       }
                        //       salarie = uneEntreprise.rechercher(nom);
                        //   }
                        //   Ecran.AfficherNomSalarie(salarie);
                        #endregion

                        if (salarie != null)
                        {
                            Console.WriteLine("Le salarie  " + salarie.getNomSalarie() + "   à été charger avec succès");
                            Ecran.AfficherNomSalarie(salarie);
                            MesMenus.afficherMenuSalarie();
                            choix = (char)Console.Read();
                            MesMenus.TraitementSalarie(choix, salarie, uneEntreprise);
                        }
                        break;
                    }
                case 'd': // voir les salaries 
                    {
                        MesMenus.Menu();
                        Console.WriteLine("________________________Tout Les salariés____________________________");
                        int i = 0;
                        foreach (Salarie s in uneEntreprise.getMesSalaries())
                        {
                            i++;
                            if (i <= 9)
                            {
                                Console.Write("_____________________n°:{0}________", i + "_______");
                                Ecran.AfficherNomSalarie(s);
                            }
                            else
                            {
                                Console.Write("_____________________n°:{0}_______", i + "_______");
                                Ecran.AfficherNomSalarie(s);
                            }
                        }

                        break;
                    }
                case 'e': // supprimer un salarie
                    {
                        Console.WriteLine("_________________________________Supprimer un salarie__________________________");
                        nom = Console.ReadLine();
                        salarie = uneEntreprise.rechercher(nom);
                        while (salarie == null) // salarie inexistant
                        {
                            Console.WriteLine("Nom incorrect ressaisissez le nom :");
                            nom = Console.ReadLine();
                            salarie = uneEntreprise.rechercher(nom);
                            Console.WriteLine("Retour au menu principal (q)");
                            choix = (char)Console.Read();
                            if (choix == 'q')
                            {
                                MesMenus.Menu();
                                choix = (char)Console.Read();
                                MesMenus.MenuPrincipale(choix);
                            }
                        }
                        if (salarie != null) // salairie trouver
                        {
                            uneEntreprise.supprimerSalarie(nom);
                            Donnees.sauveEntreprise(uneEntreprise);
                            Console.WriteLine("le salarie " + nom + "à été supprimer ");
                            salarie = uneEntreprise.rechercher(nom);
                            Console.WriteLine("Retour au menu principal (q)");
                            //choix = Console.ReadLine()[0];
                            MesMenus.Menu();
                            choix = (char)Console.Read();
                            MesMenus.MenuPrincipale(choix);
                        }
                        break;
                    }
                case 'q': //quitter
                    {
                        Console.WriteLine("Enregistrez les mises à jours (o/n) ");
                        choix = (char)Console.Read();
                        if (choix == 'o') // oui 
                        {
                            Donnees.sauveEntreprise(uneEntreprise);
                            Console.WriteLine("Données enregistrées");
                        }
                        else // non
                        {
                            Console.WriteLine("les données n'ont pas été mis à jour");
                        }
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        MesMenus.enTete();
                        MesMenus.Menu();
                        choix = (char)Console.Read();
                        MesMenus.MenuPrincipale(choix);
                        break;
                    }


            }
        }
    }
}
