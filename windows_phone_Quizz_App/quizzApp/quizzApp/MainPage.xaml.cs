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
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace quizzApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        

        // Constructeur
        public MainPage()
        {
            InitializeComponent();
           
        }     

      /*  private void DebuterQuizz_Click(object sender, RoutedEventArgs e)
        {             
            NavigationService.Navigate(new Uri("/LesQuestionnaires2.xaml", UriKind.Relative));
        }
        */
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
         
             
             
        }

        private void DebuterQuizz_Click(object sender, RoutedEventArgs e)
        {
             

            NavigationService.Navigate(new Uri("/LesQuestionnaires2.xaml", UriKind.Relative));
        }

    
     
    }
}