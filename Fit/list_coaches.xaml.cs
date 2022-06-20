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
    /// Логика взаимодействия для list_coaches.xaml
    /// </summary>
    public partial class list_coaches : Window
    {
        Helper db;
        public list_coaches()
        {
            InitializeComponent();
            db = new Helper();
        }
        private void Button_Redi_Click(object sender, RoutedEventArgs e)
        {
            string LastNam = textBoxLastNam.Text.Trim();
            string FristNam = textBoxFirstNam.Text.Trim();
            string Patromym = textBoxPatromym.Text.Trim();
            string Phones = textBoxPhones.Text.Trim();
            string Description = textBoxDescription.Text.Trim();





            if (FristNam.Length < 5)
            {
                textBoxFirstNam.ToolTip = "Фамилия введена не правильно!";
                textBoxFirstNam.Background = Brushes.DarkGoldenrod;
            }
            else if (LastNam.Length < 5)
            {
                textBoxLastNam.ToolTip = "Имя введино не правильно !";
                textBoxLastNam.Background = Brushes.DarkGoldenrod;
            }


            else if (Patromym.Length < 1)
            {
                textBoxPatromym.ToolTip = "Имя введино не правильно !";
                textBoxPatromym.Background = Brushes.DarkGoldenrod;

            }

            else if (Phones.Length < 11)
            {
                textBoxPhones.ToolTip = "Имя введино не правильно !";
                textBoxPhones.Background = Brushes.DarkGoldenrod;

            }

            else if (Description.Length < 3)
            {
                textBoxDescription.ToolTip = "Логин введен не правильно!";
                textBoxDescription.Background = Brushes.DarkGoldenrod;
            }


            else
            {

                textBoxFirstNam.ToolTip = "";
                textBoxFirstNam.Background = Brushes.Transparent;

                textBoxLastNam.ToolTip = "";
                textBoxLastNam.Background = Brushes.Transparent;




                textBoxPatromym.ToolTip = "";
                textBoxPatromym.Background = Brushes.Transparent;

                textBoxPhones.ToolTip = "";
                textBoxPhones.Background = Brushes.Transparent;

                textBoxDescription.ToolTip = "";
                textBoxDescription.Background = Brushes.Transparent;





                MessageBox.Show("Все хорошо!");

                Coach coaches = new Coach()
                {
                    FristNam = FristNam,
                    LastNam = LastNam,
                    Patromym = Patromym,
                    Phones = Phones,
                    Description = Description,

                };
                Helper.db.Coaches.Add(coaches);
                Helper.db.SaveChanges();

                new Cabinet().Show();
                this.Close();
            }
        }

        private void Button_Entra_Click(object sender, RoutedEventArgs e)
        {
            new Cabinet().Show();
            this.Close();
        }

        private void Button_ct_Click(object sender, RoutedEventArgs e)
        {
            new Window_List().Show();
            this.Close();
        }
    }
}
