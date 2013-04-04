using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tp_salaire
{
    public class Traitement
    {
        public static void TraitementSalarie(char c, Salarie salarie, Entreprise e)
        {
            string C;
            bool continuer = true;
            switch (c)
            {
                //Minuscule 
                case 'a':  // ajouter un bulletin 
                    {
                        String salaireString;
                        while (continuer == true)
                        {
                            Console.WriteLine("Ajouter un bulletin:");
                            int numMois = salarie.mesBulletins.Count;
                            do
                            {
                                Console.WriteLine("Base salariale :");
                                salaireString = Console.ReadLine();

                            }
                            while ((salaireString == ""));
                             
                            
                            double salaireH = Convert.ToInt32(salaireString);
                            
                            Bulletin b = new Bulletin(numMois + 1, salaireH);
                            int n = numMois + 1;
                            Console.WriteLine("Bulletin n° " + n);

                            char choix;
                            string choixString;
                            do
                            {
                                Console.WriteLine("______________________Souhaitez vous ajouter les relevés ? (o/n)________________________");
                                choixString = Console.ReadLine();
                             //   salaireString = Console.ReadLine();                                 
                            }
                            while (choixString == "");
                            choix = (char)choixString[0];

                            if (choix == 'o')
                            {
                                Traitement.AjouterRelever(b);
                                salarie.ajouterBulletin(b);
                                Donnees.sauveEntreprise(e);
                                Ecran.afficher(b);
                            }
                            else
                            {
                                Affichage.afficherMenuSalarie();
                            }
                            Console.WriteLine("Souhaitez vous ajouter un nouveau bulletin ? (o/n)");
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];

                            if (choix != 'o')
                            {
                                continuer = false;
                                Affichage.afficherMenuSalarie();
                              //  Console.WriteLine("tet");
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
                        char choix = ' ';
                        do
                        {
                            choix = Console.ReadLine()[0];
                        }
                        while (choix == ' ');  
                        Traitement.TraitementSalarie(choix, salarie, e);
                        break;
                    }
                case 'q':  // quitter
                    {
                        Console.Clear();
                        Affichage.enTete();
                        Affichage.Menu();
                        string qw = " ";
                        do
                        {
                            qw = Console.ReadLine();
                        }
                        while (qw == "");
                        char choix = qw[0];
                        Traitement.traitementPrincipale(choix);
                        break;
                    }
                case 'r':
                    {
                        Affichage.enTete();
                        Affichage.afficherMenuSalarie();
                        string qw = " ";
                        do
                        {
                            qw = Console.ReadLine();
                        }
                        while (qw == "");
                        char choix = qw[0];
                        if (salarie.getNomSalarie() != " ")
                        {
                            Traitement.TraitementSalarie(choix, salarie, e);
                        }
                        else
                        {
                            Traitement.traitementPrincipale('q');
                            Console.WriteLine("ok");
                        }
                        break;
                    }
                default:
                    {
                        Affichage.enTete();
                        Affichage.afficherMenuSalarie();
                        char choix = ' ';
                        do
                        {
                             choix = Console.ReadLine()[0];
                        }
                        while (choix == ' ');                     
                        Traitement.TraitementSalarie(choix, salarie, e);
                        break;
                    }
            }
        }

        public static void traitementPrincipale(char c)     //traitement principale
        {
            string nom;
            char choix;
            string C;
            Salarie salarie;
            Entreprise uneEntreprise = Donnees.chargeEntreprise();

            switch (c)
            {
                case 'a':                                                          //ajouter un salarie 
                    {
                        bool exec = false;
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Ajouter un salarie:");
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                            if (nom != "q")
                            {
                                if (nom.Length < 2)
                                {
                                    do
                                    {
                                        Affichage.enTete();
                                        Console.WriteLine("Ajouter un salarie:");
                                        Console.WriteLine("le nom doit contenir deux caractère minimum ,saisir le nom :");
                                        nom = Console.ReadLine();
                                    }
                                    while (nom.Length < 2);
                                }
                            }
                            else
                            {
                                Affichage.enTete();
                                Console.WriteLine("Retourner au menu principal ? (o/n)");
                                string decision = Console.ReadLine();
                                choix = decision[0];
                                if (choix == 'o')
                                {
                                    Affichage.enTete();
                                    Affichage.Menu();
                                    choix = Console.ReadLine()[0];
                                    Traitement.traitementPrincipale(choix);
                                }
                                else
                                {
                                    Traitement.traitementPrincipale('q');
                                }
                            }
                        }
                        while ( nom == "");
                        Salarie Existesalarie = uneEntreprise.rechercher(nom);

                        while ((Existesalarie != null) || (exec == true))
                        {                          
                            do
                            {  Console.WriteLine("Ce salarie a deja été ajouté , Ressaisir (o/n):");
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];

                            if (choix == 'o')
                            {
                                Console.WriteLine("Nom :");
                                nom = Console.ReadLine();
                                Existesalarie = uneEntreprise.rechercher(nom);
                                if (Existesalarie != null)
                                {
                                    exec = false;
                                }
                                else
                                {
                                    exec = true;
                                }
                            }
                            else
                            {
                                Affichage.enTete();
                                Affichage.Menu();
                                do
                                {
                                    C = Console.ReadLine();
                                }
                                while (C == "");
                                choix = C[0];
                                Traitement.traitementPrincipale(choix);
                            }
                        }
                        if (Existesalarie == null)
                        {
                            salarie = new Salarie(nom);
                            uneEntreprise.ajouteSalarie(salarie);
                            Donnees.sauveEntreprise(uneEntreprise);
                            Console.WriteLine("Le salarie " + salarie.getNomSalarie() + "  à été charger avec succès");
                            Ecran.AfficherNomSalarie(salarie);
                            Affichage.afficherMenuSalarie();
                         
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];
                            Traitement.TraitementSalarie(choix, salarie, uneEntreprise);
                        }
                        break;
                    }
                case 'b': // charger un salarie 
                    {
                        Console.WriteLine("_________________________________Charger un salarie_____________________________");
                        bool exec = true;
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                        }
                        while (nom == "");

                        salarie = uneEntreprise.rechercher(nom);
                        while ((salarie == null) && (exec == true))
                        {
                            Console.WriteLine("Ce salarie n'a pas été ajouté, Ressaisir (o/n):");
                            choix = Console.ReadLine()[0];
                            if (choix == 'o')
                            {
                                Console.WriteLine("Nom :");
                                nom = Console.ReadLine();
                                salarie = uneEntreprise.rechercher(nom);
                            }
                            else
                            {
                                Affichage.enTete();
                                Affichage.Menu();
                                choix = Console.ReadLine()[0];
                                Traitement.traitementPrincipale(choix);
                            }
                            exec = true;
                        }
                        if (salarie != null)
                        {
                            Affichage.enTete();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("__________________Le salarie  " + salarie.getNomSalarie() + "   à été chargé avec succès_________________");
                            Console.WriteLine("_______________________________________________________________________________");                          
                            Console.WriteLine("");
                            Affichage.afficherMenuSalarie();                                                      
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];

                            Traitement.TraitementSalarie(choix, salarie, uneEntreprise);
                        }
                        break;
                    }
                case 'c': // rechercher un salarié
                    {
                        Console.WriteLine("_________________________________Rechercher un salarie_____________________________");
                        bool exec = false;
                        salarie = new Salarie("aa");
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                        }
                        while (nom == "");

                        salarie = uneEntreprise.rechercher(nom);

                        while (salarie == null)
                        {
                            if ((salarie == null) && (exec == true))
                            {
                                Console.WriteLine("Salarié inexistant , voulez vous ressaisir(o/n)?");                               
                                do
                                {
                                    C = Console.ReadLine();
                                }
                                while (C == "");
                                choix = C[0];
                                if (choix == 'o')
                                {
                                    Console.WriteLine("Nom:");
                                    nom = Console.ReadLine();
                                }
                                else
                                {
                                    Affichage.enTete();
                                    Affichage.Menu();
                                    do
                                    {
                                        C = Console.ReadLine();
                                    }
                                    while (C == "");
                                    choix = C[0];
                                    Traitement.traitementPrincipale(choix);
                                }
                            }
                            exec = true;
                        }
                        if (salarie != null)
                        {
                            Console.WriteLine("Le salarie  " + salarie.getNomSalarie() + "   à été charger avec succès");
                            Ecran.AfficherNomSalarie(salarie);
                            Affichage.afficherMenuSalarie();
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];
                            Traitement.TraitementSalarie(choix, salarie, uneEntreprise);
                        }
                        break;
                    }
                case 'd': // voir les salaries 
                    {
                        Console.Clear();
                        Affichage.enTete();
                        Affichage.Menu();
                        Console.WriteLine("____________________________Tout Les salariés____________________________");
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
                        Console.WriteLine("*******************");
                        Console.WriteLine("Retour au menu principal (q)");
                        Console.WriteLine("Retour au menu salarie (r)");
                        do
                        {
                            C = Console.ReadLine();
                        }
                        while (C == "");

                        choix = C[0];
                        Traitement.traitementPrincipale(choix);

                        break;
                    }
                case 'e':                                                                       // supprimer un salarie
                    {
                        Console.WriteLine("_________________________________Supprimer un salarie__________________________");
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                        }
                        while (nom == "");
                        salarie = uneEntreprise.rechercher(nom);
                        while (salarie == null) // salarie inexistant
                        {
                            Console.WriteLine("Nom incorrect ressaisissez le nom :");
                            nom = Console.ReadLine();
                            salarie = uneEntreprise.rechercher(nom);
                            Console.WriteLine("Retour au menu principal (q)");
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];

                            if (choix == 'q')
                            {
                                Affichage.Menu();                                 
                                do
                                {
                                    C = Console.ReadLine();
                                }
                                while (C == "");
                                choix = C[0];

                                Traitement.traitementPrincipale(choix);
                            }
                            else
                            {
                                Traitement.traitementPrincipale('d');
                            }
                        }
                        if (salarie != null) // salairie trouver
                        {
                            uneEntreprise.supprimerSalarie(nom);
                            Donnees.sauveEntreprise(uneEntreprise);
                            Console.WriteLine("le salarie " + nom + " à été supprimer ");
                            salarie = uneEntreprise.rechercher(nom);
                            //Console.WriteLine("Retour au menu principal (q)");                             
                            Affichage.Menu();
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];
                            Traitement.traitementPrincipale(choix);
                        }
                        break;
                    }
                case 'q': //quitter
                    {
                        Console.WriteLine("Enregistrez les mises à jours (o/n) ");
                        do
                        {
                            C = Console.ReadLine();
                        }
                        while (C == "");
                        choix = C[0];

                        switch (choix)
                        {
                            case 'o':
                                {
                                    Donnees.sauveEntreprise(uneEntreprise);                                 
                                    Console.WriteLine("Données enregistrées");
                                    Environment.Exit(1);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("les données n'ont pas été mis à jour");
                                    Environment.Exit(1);
                                    break;
                                }                                
                        }

                        break;
                    }
                case 'A':                                                          //ajouter un salarie 
                    {
                        bool exec = false;
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Ajouter un salarie:");
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                            if (nom != "q")
                            {
                                if (nom.Length < 2)
                                {
                                    do
                                    {
                                        Affichage.enTete();
                                        Console.WriteLine("Ajouter un salarie:");
                                        Console.WriteLine("le nom doit contenir deux caractère minimum ,saisir le nom :");
                                        nom = Console.ReadLine();
                                    }
                                    while (nom.Length < 2);
                                }
                            }
                            else
                            {
                                Traitement.traitementPrincipale('q');
                            }
                        }
                        while (nom == "");
                        Salarie Existesalarie = uneEntreprise.rechercher(nom);

                        while ((Existesalarie != null) || (exec == true))
                        {
                            do
                            {
                                Console.WriteLine("Ce salarie a deja été ajouté , Ressaisir (o/n):");
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];

                            if (choix == 'o')
                            {
                                Console.WriteLine("Nom :");
                                nom = Console.ReadLine();
                                Existesalarie = uneEntreprise.rechercher(nom);
                                exec = true;
                            }
                            else
                            {
                                Affichage.enTete();
                                Affichage.Menu();
                                do
                                {
                                    C = Console.ReadLine();
                                }
                                while (C == "");
                                choix = C[0];
                                Traitement.traitementPrincipale(choix);
                            }
                        }
                        if (Existesalarie == null)
                        {
                            salarie = new Salarie(nom);
                            uneEntreprise.ajouteSalarie(salarie);
                            Donnees.sauveEntreprise(uneEntreprise);
                            Console.WriteLine("Le salarie " + salarie.getNomSalarie() + "  à été charger avec succès");
                            Ecran.AfficherNomSalarie(salarie);
                            Affichage.afficherMenuSalarie();
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];
                            Traitement.TraitementSalarie(choix, salarie, uneEntreprise);
                        }

                        break;
                    }
                case 'B': // charger un salarie 
                    {
                        Console.WriteLine("_________________________________Charger un salarie_____________________________");
                        bool exec = true;
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                        }
                        while (nom == "");

                        salarie = uneEntreprise.rechercher(nom);
                        while ((salarie == null) && (exec == true))
                        {
                            Console.WriteLine("Ce salarie n'a pas été ajouté, Ressaisir (o/n):");
                            choix = Console.ReadLine()[0];
                            if (choix == 'o')
                            {
                                Console.WriteLine("Nom :");
                                nom = Console.ReadLine();
                                salarie = uneEntreprise.rechercher(nom);
                            }
                            else
                            {
                                Affichage.enTete();
                                Affichage.Menu();
                                choix = Console.ReadLine()[0];
                                Traitement.traitementPrincipale(choix);
                            }
                            exec = true;
                        }
                        if (salarie != null)
                        {
                            Affichage.enTete();
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("__________________Le salarie  " + salarie.getNomSalarie() + "   à été chargé avec succès_________________");
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("");
                            Affichage.afficherMenuSalarie();
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];

                            Traitement.TraitementSalarie(choix, salarie, uneEntreprise);
                        }
                        break;
                    }
                case 'C': // rechercher un salarié
                    {
                        Console.WriteLine("_________________________________Rechercher un salarie_____________________________");
                        bool exec = false;
                        salarie = new Salarie("aa");
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                        }
                        while (nom == "");

                        salarie = uneEntreprise.rechercher(nom);

                        while (salarie == null)
                        {
                            if ((salarie == null) && (exec == true))
                            {
                                Console.WriteLine("Salarié inexistant , voulez vous ressaisir(o/n)?");
                                do
                                {
                                    C = Console.ReadLine();
                                }
                                while (C == "");
                                choix = C[0];
                                if (choix == 'o')
                                {
                                    Console.WriteLine("Nom:");
                                    nom = Console.ReadLine();
                                }
                                else
                                {
                                    Affichage.enTete();
                                    Affichage.Menu();
                                    do
                                    {
                                        C = Console.ReadLine();
                                    }
                                    while (C == "");
                                    choix = C[0];
                                    Traitement.traitementPrincipale(choix);
                                }
                            }
                            exec = true;
                        }
                        if (salarie != null)
                        {
                            Console.WriteLine("Le salarie  " + salarie.getNomSalarie() + "   à été charger avec succès");
                            Ecran.AfficherNomSalarie(salarie);
                            Affichage.afficherMenuSalarie();
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];
                            Traitement.TraitementSalarie(choix, salarie, uneEntreprise);
                        }
                        break;
                    }
                case 'D': // voir les salaries 
                    {
                        Console.Clear();
                        Affichage.enTete();
                        Affichage.Menu();
                        Console.WriteLine("____________________________Tout Les salariés____________________________");
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
                        Console.WriteLine("*******************");
                        Console.WriteLine("Retour au menu principal (q)");
                        Console.WriteLine("Retour au menu salarie (r)");
                        do
                        {
                            C = Console.ReadLine();
                        }
                        while (C == "");

                        choix = C[0];
                        Traitement.traitementPrincipale(choix);

                        break;
                    }
                case 'E':                                                                       // supprimer un salarie
                    {
                        Console.WriteLine("_________________________________Supprimer un salarie__________________________");
                        do
                        {
                            Affichage.enTete();
                            Console.WriteLine("Nom :");
                            nom = Console.ReadLine();
                        }
                        while (nom == "");
                        salarie = uneEntreprise.rechercher(nom);
                        while (salarie == null) // salarie inexistant
                        {
                            Console.WriteLine("Nom incorrect ressaisissez le nom :");
                            nom = Console.ReadLine();
                            salarie = uneEntreprise.rechercher(nom);
                            Console.WriteLine("Retour au menu principal (q)");
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];

                            if (choix == 'q')
                            {
                                Affichage.Menu();
                                choix = Console.ReadLine()[0];
                                Traitement.traitementPrincipale(choix);
                            }
                            else
                            {
                                Traitement.traitementPrincipale('d');
                            }
                        }
                        if (salarie != null) // salairie trouver
                        {
                            uneEntreprise.supprimerSalarie(nom);
                            Donnees.sauveEntreprise(uneEntreprise);
                            Console.WriteLine("le salarie " + nom + " à été supprimer ");
                            salarie = uneEntreprise.rechercher(nom);
                            //Console.WriteLine("Retour au menu principal (q)");                             
                            Affichage.Menu();
                            do
                            {
                                C = Console.ReadLine();
                            }
                            while (C == "");
                            choix = C[0];
                            Traitement.traitementPrincipale(choix);
                        }
                        break;
                    }
                case 'Q': //quitter
                    {
                        Console.WriteLine("Enregistrez les mises à jours (o/n) ");
                        do
                        {
                            C = Console.ReadLine();
                        }
                        while (C == "");
                        choix = C[0];

                        switch (choix)
                        {
                            case 'o':
                                {
                                    Donnees.sauveEntreprise(uneEntreprise);
                                    Console.WriteLine("Données enregistrées");
                                    Environment.Exit(1);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("les données n'ont pas été mis à jour");
                                    Environment.Exit(1);
                                    break;
                                }
                        }

                        break;
                    }

                default:
                    {
                        Console.Clear();
                        Affichage.enTete();
                        Affichage.Menu();
                        string qw = " ";
                        do
                        {
                            qw = Console.ReadLine();
                        }
                        while (qw == "");
                        choix = qw[0];
                        Traitement.traitementPrincipale(choix);
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
    }
}
