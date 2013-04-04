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
            MesMenus.enTete(); 
            MesMenus.Menu();         
            while (choix != 'q')  
            {
               // choix = (char)Console.Read();

                choix = (char)Console.Read();
                MesMenus.MenuPrincipale(choix);
                 
            }
        }
    }
}

       
    

