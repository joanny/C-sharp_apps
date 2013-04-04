using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tp_salaire
{
    class Affichage
    {
        public static void enTete()
        {
            Console.Clear();
            Entreprise uneEntreprise = Donnees.chargeEntreprise();
            Console.WriteLine("_________________________________" + uneEntreprise.getRaisonSociale() + "______________________________________");
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
    }
}
