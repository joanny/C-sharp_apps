using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace quizzApp
{
    
    public class Question
    {       
      #region get-set 
      /*  
        public string question
        {
            get { return this.question; }
            set { this.question = value; }
        }
    
        public  List<Indice> lesIndices
        {
            get { return this.lesIndices; }
            set { this.lesIndices = value; }
        }
          
        public string reponse
        {
            get { return this.reponse; }
            set { this.reponse = value; }
        }
          
        public string limage
        {
            get { return this.limage; }
            set { this.limage = value; }
        }
        */
      #endregion 
         
        
        [XmlElement]
        private string question;
        [XmlElement]
        private List<Indice> lesIndices;
        [XmlElement]
        [XmlElement]
        private string reponse;
        [XmlElement]
        private string limage;

        public Question(string laQuestion, List<Indice> lesIndices, string lareponse, string limage)
        {
            this.question = laQuestion;
            this.lesIndices = lesIndices;
            this.reponse = lareponse;
            this.limage = limage;
            
        }

        public bool suisJeCorrect(string uneReponse)
        {
            bool correct = false;
            if (this.reponse == uneReponse)
            {
                correct = true;
            }
            return correct;
        }
        public string getQestion()
        {
            return this.question;
        }
        public List<Indice> getLesIndices()
        {
            return this.lesIndices;
        }
        public int getNbIndices()
        {
            return this.lesIndices.Count;
        }
        public string getImage()
        {
            return this.limage;
        }

    }
}
