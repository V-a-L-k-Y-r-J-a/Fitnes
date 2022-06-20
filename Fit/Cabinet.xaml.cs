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
using System.Windows.Shapes;

namespace Fit
{
    /// <summary>
    /// Логика взаимодействия для Cabinet.xaml
    /// </summary>
    public partial class Cabinet : Window
    {
        public Cabinet()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Auct_Click(object sender, RoutedEventArgs e)
        {
            new list_coaches().Show();
            this.Close();
        }


        private void Button_Aucz_Click(object sender, RoutedEventArgs e)
        {
            new recording_a_workout().Show();
            this.Close();
        }

        private void Button_Aut_Click(object sender, RoutedEventArgs e)
        {
            new Training().Show();
            this.Close();
        }

        private void Button_Au_Click(object sender, RoutedEventArgs e)
        {
           new Les().Show();
            this.Close();
        }
    }
}

