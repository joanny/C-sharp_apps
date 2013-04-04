using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
 
namespace tp_salaire
{
    public class PersisteSalarie
    {        
        public static void sauve(Salarie unSalarie)
        {                    
                FileStream fichier = new FileStream("Salarie.txt", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fichier, unSalarie);
                fichier.Close();                                 
        }       
        public static Salarie charge(string fichier)
        {
            Salarie s;
            FileStream lefichier = new FileStream(fichier, FileMode.Open ); ;
            BinaryFormatter bf = new BinaryFormatter();
            s = (Salarie)bf.Deserialize(lefichier);            
            lefichier.Close();
            return s;
        }
        // unEntreprise.txt
        public static void sauveEntreprise(Entreprise uneEntreprise)
        {
            FileStream fichier = new FileStream("Microsoft.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fichier, uneEntreprise);
            fichier.Close();
        }
        public static Entreprise chargeEntreprise()
        {
            FileStream lefichier = new FileStream("Microsoft.txt", FileMode.Open); ;
            BinaryFormatter bf = new BinaryFormatter();
            Entreprise e = (Entreprise)bf.Deserialize(lefichier);
            lefichier.Close();
            return e;
        }   
    }
}
