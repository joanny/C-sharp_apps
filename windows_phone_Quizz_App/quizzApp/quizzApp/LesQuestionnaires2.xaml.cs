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

namespace quizzApp
{
    public partial class LesQuestionnaires2 : PhoneApplicationPage
    {
        public LesQuestionnaires2()
        {
            InitializeComponent();
        }
      
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {             
            SerieQuestionnaire lesQuestionnaires = Passerelle.getLesQuestionnaires();
            lstQuestionnaires.Items.Clear();
            Image myImage1 = new Image();
            BitmapImage bi3 = new BitmapImage();
            if (lesQuestionnaires.getMesQuestionnaires().Count > 0)
            {
                foreach (Questionnaire q in lesQuestionnaires.getMesQuestionnaires())
                {

                    string chemin = q.getIllustration();
                    //bi3.UriSource = new Uri(chemin, UriKind.RelativeOrAbsolute);
                    //image1.Stretch = Stretch.Fill;
                    //image1.Source = bi3;

                    lstQuestionnaires.Items.Add(q.getTheme());
                }
            }
        }

       

        private void lstQuestionnaires_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int numQuestionnaire = lstQuestionnaires.SelectedIndex;
            NavigationService.Navigate(new Uri("/LaQuestion.xaml?index=" + numQuestionnaire, UriKind.Relative));

        }    
    }
}