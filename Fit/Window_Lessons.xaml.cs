using Fit.Model;
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
    /// Логика взаимодействия для Window_Lessons.xaml
    /// </summary>
    public partial class Window_Lessons : Window
    {
        

        public Window_Lessons()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            trainingDGrid.ItemsSource = Helper.db.trainings.ToList();
        }
        private void trainingDGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            training trainings = trainingDGrid.SelectedItem as training;

            if (trainings != null)
            {
                Helper.db.SaveChanges();
                LoadData();
            }

        }

        private void LogOuytBtn_Click(object sender, RoutedEventArgs e)
        {
            new Cabinet().Show();
            this.Close();
        }
    }
}
