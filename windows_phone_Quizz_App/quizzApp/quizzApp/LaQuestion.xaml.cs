using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
 


namespace quizzApp
{
    public partial class LaQuestion : PhoneApplicationPage
    {
        
        private int nbClick;
        private Questionnaire unQuestionnaire;
        private int numQuestion;
    
        public LaQuestion()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string indexStr;
            if (NavigationContext.QueryString.TryGetValue("index", out indexStr))
            {
                int index = int.Parse(indexStr);
                if ( index > 0)
                {
                    this.unQuestionnaire = Passerelle.getLesQuestionnaires(index);
                }
                else
                {
                    this.unQuestionnaire = Passerelle.getLesQuestionnaires(0);
                }
            }
            base.OnNavigatedTo(e);
        }
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            zoneQuestion.Text = this.unQuestionnaire.getLesQuestions()[0].getQestion();
            nbClick = 0;
            numQuestion = 0;             
            string chemin = this.unQuestionnaire.getLesQuestions()[0].getImage();
            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.UriSource = new Uri(chemin , UriKind.RelativeOrAbsolute);
            image1.Stretch = Stretch.Fill;
            image1.Source = bi3;
        }

        private void valiver_Click(object sender, RoutedEventArgs e)
        {
            
                if (this.unQuestionnaire.getLesQuestions()[this.numQuestion].suisJeCorrect(zoneReponse.Text))
                {
                    MessageBox.Show("Bravo !!!!");                   
                    NavigationService.Navigate(new Uri("/LesQuestionnaires2.xaml", UriKind.Relative));
                }
                else
                {                    
                        if (nbClick < this.unQuestionnaire.getLesQuestions()[this.numQuestion].getNbIndices())
                        {
                            string indice = this.unQuestionnaire.getLesQuestions()[this.numQuestion].getLesIndices()[nbClick].getIndice();                          
                            MessageBox.Show(indice);
                            nbClick++;
                        }
                        else
                        {
                            MessageBox.Show("Partie finie, nombre d'essais maximun atteint");
                            NavigationService.Navigate(new Uri("/FrmPerdu.xaml", UriKind.Relative));
                        }
                }               
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LesQuestionnaires2.xaml", UriKind.Relative));   
        }
    }
}