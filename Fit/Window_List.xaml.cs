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
    /// Логика взаимодействия для Window_List.xaml
    /// </summary>
    public partial class Window_List : Window
    {
        public Window_List()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            CoachDGrid.ItemsSource = Helper.db.Coaches.ToList();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            new Cabinet().Show();
            this.Close();
        }

        private void CoachDGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Coach coaches = CoachDGrid.SelectedItem as Coach;

            if (coaches != null)
            {
                Helper.db.SaveChanges();
                LoadData();
            }

        }
    }
}
