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
    /// Логика взаимодействия для recording_a_workout.xaml
    /// </summary>
    public partial class recording_a_workout : Window
    {
        Helper db;
        public recording_a_workout()
        {
            InitializeComponent();
            db = new Helper();
        }
        private void Button_Redi_Click(object sender, RoutedEventArgs e)
        {
            string LastNames = textBoxLastNames.Text.Trim();
            string FristNames = textBoxFirstNames.Text.Trim();
            string Patronymics = textBoxPatronymics.Text.Trim();
            string Phone = textBoxPhone.Text.Trim();
            string MedicalCart = textBoxMedicalCart.Text.Trim();
            string TypeTraining = textBoxTypeTraining.Text.Trim();


            if (FristNames.Length < 5)
            {
                textBoxFirstNames.ToolTip = "Фамилия введена не правильно!";
                textBoxFirstNames.Background = Brushes.DarkGoldenrod;
            }
            else if (LastNames.Length < 5)
            {
                textBoxLastNames.ToolTip = "Имя введино не правильно !";
                textBoxLastNames.Background = Brushes.DarkGoldenrod;
            }


            else if (Patronymics.Length < 1)
            {
                textBoxPatronymics.ToolTip = "Имя введино не правильно !";
                textBoxPatronymics.Background = Brushes.DarkGoldenrod;

            }

            else if (Phone.Length < 11)
            {
                textBoxPhone.ToolTip = "Имя введино не правильно !";
                textBoxPhone.Background = Brushes.DarkGoldenrod;

            }

            else if (MedicalCart.Length < 3)
            {
                textBoxMedicalCart.ToolTip = "Логин введен не правильно!";
                textBoxMedicalCart.Background = Brushes.DarkGoldenrod;
            }
            else if (TypeTraining.Length < 3)
            {
                textBoxTypeTraining.ToolTip = "Пароль введен не правильно!";
                textBoxTypeTraining.Background = Brushes.DarkGoldenrod;

            }

            else
            {

                textBoxFirstNames.ToolTip = "";
                textBoxFirstNames.Background = Brushes.Transparent;

                textBoxLastNames.ToolTip = "";
                textBoxLastNames.Background = Brushes.Transparent;




                textBoxPatronymics.ToolTip = "";
                textBoxPatronymics.Background = Brushes.Transparent;

                textBoxPhone.ToolTip = "";
                textBoxPhone.Background = Brushes.Transparent;

                textBoxMedicalCart.ToolTip = "";
                textBoxMedicalCart.Background = Brushes.Transparent;

                textBoxTypeTraining.ToolTip = "";
                textBoxTypeTraining.Background = Brushes.Transparent;



                MessageBox.Show("Все хорошо!");

                Person people = new Person()
                {
                    FristNames = FristNames,
                    LastNames = LastNames,
                    Patronymics = Patronymics,
                    Phone = Phone,
                    MedicalCart = MedicalCart,
                    TypeTraining = TypeTraining,
                };



                Helper.db.People.Add(people);
                Helper.db.SaveChanges();

                new Cabinet().Show();
                this.Close();


            }

        }

        private void Button_Entr_Click(object sender, RoutedEventArgs e)
        {
            new Cabinet().Show();
            this.Close();
        }
    }
}
