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
            
            while (choix != 'q')
            {
                MesMenus.Menu();
                choix = Console.ReadLine()[0];
                MesMenus.MenuPrincipale(choix);
            }
        }
  
    }
}
       
    

