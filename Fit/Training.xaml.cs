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
    /// Логика взаимодействия для Training.xaml
    /// </summary>
    public partial class Training : Window
    {
        Helper db;
        public Training()
        {
            InitializeComponent();
            db = new Helper();
        }
        private void Button_Redik_Click(object sender, RoutedEventArgs e)
        {
            string Name = textName.Text.Trim();
            string TrainingPlace = textTrainingPlace.Text.Trim();



            if (Name.Length < 1)
            {
                textName.ToolTip = "Название введена не правильно!";
                textName.Background = Brushes.DarkGoldenrod;
            }
            else if (TrainingPlace.Length < 1)
            {
                textTrainingPlace.ToolTip = "Цена введина не правильно !";
                textTrainingPlace.Background = Brushes.DarkGoldenrod;
            }

            else
            {

                textName.ToolTip = "";
                textName.Background = Brushes.Transparent;

                textTrainingPlace.ToolTip = "";
                textTrainingPlace.Background = Brushes.Transparent;


                MessageBox.Show("Все хорошо!");

                training trainings = new training()
                {
                    Name = Name,
                    TrainingPlace = TrainingPlace,

                };

                Helper.db.trainings.Add(trainings);
                Helper.db.SaveChanges();

                new Cabinet().Show();
                this.Close();

            }
        }
        private void Button_En_Click(object sender, RoutedEventArgs e)
        {
            new Cabinet().Show();
            this.Close();
        }

        private void Button_ini_Click(object sender, RoutedEventArgs e)
        {
            new Lessons().Show();
            this.Close();
        }
    }
}

