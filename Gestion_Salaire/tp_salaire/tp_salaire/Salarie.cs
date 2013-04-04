using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
 

namespace tp_salaire
{
    [System.Serializable]
    public class Salarie
    {
        private string nomSalarie;
        public ArrayList mesBulletins = new ArrayList();
       
        public Salarie(string nom)
        {
            this.nomSalarie = nom;            
        }
        public Salarie()
        {
            this.nomSalarie = "";
        }
        public void ajouterBulletin(Bulletin b)
        {
            this.mesBulletins.Add(b);
        }
        public float salaireAnnuel()
        {
           float salaireA = 0;
            foreach (Bulletin b in this.mesBulletins)
            {
                salaireA  = salaireA  + (float)b.salaireNet();
            }             
            return salaireA;
        }
        public string getNomSalarie()
        {
            return this.nomSalarie;
        }
        public ArrayList getLesBulletins()
        {
            return this.mesBulletins;
        }        
       
    }
}
