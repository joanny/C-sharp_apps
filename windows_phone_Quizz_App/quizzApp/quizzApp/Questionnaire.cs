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
    
    public class Questionnaire
    {
        #region get- set 
         /*
        public List<Question> mesQuestions
        {
            get { return this.mesQuestions; }
            set { this.mesQuestions = value; }
        }
         
        public string Illutration
        {
            get { return this.Illutration; }
            set { this.Illutration = value; }
        }
          * */
        #endregion get-set         
                
        private string theme;
        private string Illutration;
        private List<Question> mesQuestions;
        
        public Questionnaire(List<Question> desQuestions ,  string CheminImage , string unTheme)
        {
            this.mesQuestions = desQuestions;
            this.Illutration = CheminImage;
            this.theme = unTheme;
        }
        public List<Question> getLesQuestions()
        {
            return this.mesQuestions;
        }
        public string getIllustration()
        {
            return this.Illutration;
        }
        public string getTheme()
        {
            return this.theme;
        }
    }
}
