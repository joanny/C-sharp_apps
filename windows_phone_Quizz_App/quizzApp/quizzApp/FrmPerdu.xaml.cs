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

namespace quizzApp
{
    public partial class FrmPerdu : PhoneApplicationPage
    {
        public FrmPerdu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LesQuestionnaires2.xaml", UriKind.Relative));  
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
        }
    }
}