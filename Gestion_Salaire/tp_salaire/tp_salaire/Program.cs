using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace tp_salaire
{
    class Program
    {
        static void Main(string[] args)
        {         
                 run();
        }
            public static void run()
            {
                char choix = ' ';
                String C;
                Affichage.enTete();
                Affichage.Menu();
                while (choix != 'q')
                {
                    do
                    {
                        C = Console.ReadLine();
                    }
                    while (C == "");
                    choix = C[0];
                    Traitement.traitementPrincipale(choix);
                }
            }
        }
    }


       
    

