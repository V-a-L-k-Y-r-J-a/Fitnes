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
    /// Логика взаимодействия для Les.xaml
    /// </summary>
    public partial class Les : Window
    {
        public Les()
        {
            InitializeComponent();
        }

        private void LogOuytBtn_Click(object sender, RoutedEventArgs e)
        {
            new Cabinet().Show();
            this.Close();
        }

        private void trainingDGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
