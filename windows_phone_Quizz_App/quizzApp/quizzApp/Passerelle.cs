using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
namespace quizzApp
{
    public class Passerelle
    {
        //public static List<Questionnaire> getLesQuestionnaires()
        //{
        //    Indice unIndice = new Indice("Ce film fantastique d’épouvante de 1987 est un remake du film de Kurt Neumann de 1958");
        //    Indice unAutreIndice = new Indice("Le personnage de Seth Brundle devait initialement être interprété par Michael Keaton, mais il refusa.");
        //    List<Indice> uneListeIndice = new List<Indice>();
        //    uneListeIndice.Add(unIndice);
        //    uneListeIndice.Add(unAutreIndice);
        //    Question q = new Question("De quel film s’agit-il?", uneListeIndice, "la mouche", "image");
        //    List<Question> desQuestions = new List<Question>();
        //    desQuestions.Add(q);
        //    Questionnaire unQuest = new Questionnaire(q , "chemin 

        //    List<Questionnaire> uneSerie = new List<Questionnaire>();
            
        //    return null;
        //}

        public static void sauve( Stream fichier, SerieQuestionnaire uneSerieDeQestion)
        {
            if (uneSerieDeQestion == null || fichier == null)
              return;
            CustomBinarySerializer ser = new CustomBinarySerializer(uneSerieDeQestion.GetType());
             ser.WriteObject(fichier, uneSerieDeQestion);              
        }
        public static SerieQuestionnaire getLesQuestionnaires()
        {

            Indice unIndice = new Indice("Ce film fantastique d’épouvante de 1987 est un remake du film de Kurt Neumann de 1958");
            Indice unAutreIndice = new Indice("Le personnage de Seth Brundle devait initialement être interprété par Michael Keaton, mais il refusa.");
            List<Indice> uneListeIndice = new List<Indice>();
            uneListeIndice.Add(unIndice);
            uneListeIndice.Add(unAutreIndice);
            Question uneQuestion = new Question("De quel film s’agit-il?",
            uneListeIndice, "la mouche", "/quizzApp;component/images/cinema88.jpg");
            List<Question> ls = new List<Question>();
            ls.Add(uneQuestion);
            Questionnaire lesQestions = new Questionnaire(ls, "/quizzApp;component/images/Idées-de-thèmes-Le-cinéma-300x214.jpg", "Cinéma");
            List<Questionnaire> dec = new List<Questionnaire>();
            dec.Add(lesQestions);                
            SerieQuestionnaire uneSerie = new SerieQuestionnaire(dec);   
                                                                          
            return uneSerie;

        }
        public static Questionnaire getLesQuestionnaires(int numQuestionnaire)
        {

            if (Passerelle.getLesQuestionnaires().getMesQuestionnaires().Count > numQuestionnaire)
            {
                return Passerelle.getLesQuestionnaires().getMesQuestionnaires()[numQuestionnaire];
            }
            else
            {
                return null;
            }
        }

       
        //public static ServiceCommercial charge(String fichier)
        //{
        //    ServiceCommercial s;
        //    FileStream lefichier = new FileStream(fichier, FileMode.Open);
        //    BinaryFormatter bf = new BinaryFormatter();
        //    s = (ServiceCommercial)bf.Deserialize(lefichier);
        //    lefichier.Close();
        //    return s;
        //}

    }
}
