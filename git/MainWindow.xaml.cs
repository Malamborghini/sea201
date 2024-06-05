using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SAE_201_MARATHON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
    }

        private void Button_Suivant_1(object sender, RoutedEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Visible;
            imgCourse.Visibility = Visibility.Hidden;
        }

        private void Button_Suivant_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Visible;
        }

        private void Button_Precedent_1(object sender, RoutedEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Visible;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            imgCourse.Visibility = Visibility.Visible;
        }

        private void Button_Precedent_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Visible;
            SelectionCoureurs.Visibility = Visibility.Hidden;
        }
        private void Button_Suivant_3(object sender, RoutedEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Visible;
        }

        private void Button_Confirmer(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Merci d'avoir confirmé", "Confirmation",
            MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Precedent_3(object sender, RoutedEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Visible;
            ConfirmationInscription.Visibility = Visibility.Hidden;
        }
    }
    

    
}
