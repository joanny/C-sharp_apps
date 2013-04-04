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
     
    public class SerieQuestionnaire
    {
       /*  
        public List<Questionnaire> lesQuestionnaires
        {
            get { return this.lesQuestionnaires; }
            set { this.lesQuestionnaires = value;  }
        }
        */
        [DataMember]
        private List<Questionnaire> lesQuestionnaires;

        public SerieQuestionnaire(List<Questionnaire> lesQestionnaires )
        {
            this.lesQuestionnaires = lesQestionnaires;
        }
        public List<Questionnaire>  getMesQuestionnaires()
        {
            return this.lesQuestionnaires;
        }
    }
}
