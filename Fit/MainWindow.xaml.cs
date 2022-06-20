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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Helper db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Helper();
        }

        private void Button_RedrClick(object sender, RoutedEventArgs e)
        {
            string LastName = textBoxLastName.Text.Trim();
            string FristName = textBoxFirstName.Text.Trim();
            string Patronymic = textBoxPatronymic.Text.Trim();

            string Post = textBoxPost.Text.Trim();
            string Login = textBoxLogin.Text.Trim();
            string Pass = PassBox.Password.Trim();
            string Pass_2 = PassBox_2.Password.Trim();

            if (FristName.Length < 5)
            {
                textBoxFirstName.ToolTip = "Фамилия введена не правильно!";
                textBoxFirstName.Background = Brushes.DarkGoldenrod;
            }
            else if (LastName.Length < 5)
            {
                textBoxLastName.ToolTip = "Имя введино не правильно !";
                textBoxLastName.Background = Brushes.DarkGoldenrod;
            }


            else if (Patronymic.Length < 1)
            {
                textBoxPatronymic.ToolTip = "Имя введино не правильно !";
                textBoxPatronymic.Background = Brushes.DarkGoldenrod;

            }

            else if (Post.Length < 5)
            {
                textBoxPost.ToolTip = "Имя введино не правильно !";
                textBoxPost.Background = Brushes.DarkGoldenrod;

            }

            else if (Login.Length < 3)
            {
                textBoxLogin.ToolTip = "Логин введен не правильно!";
                textBoxLogin.Background = Brushes.DarkGoldenrod;
            }
            else if (Pass.Length < 3)
            {
                PassBox.ToolTip = "Пароль введен не правильно!";
                PassBox.Background = Brushes.DarkGoldenrod;

            }
            else if (Pass != Pass_2)
            {
                PassBox_2.ToolTip = "Пароль введен не правильно!";
                PassBox_2.Background = Brushes.DarkGoldenrod;

            }
            else
            {

                textBoxFirstName.ToolTip = "";
                textBoxFirstName.Background = Brushes.Transparent;

                textBoxLastName.ToolTip = "";
                textBoxLastName.Background = Brushes.Transparent;




                textBoxPatronymic.ToolTip = "";
                textBoxPatronymic.Background = Brushes.Transparent;

                textBoxPost.ToolTip = "";
                textBoxPost.Background = Brushes.Transparent;

                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;

                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;

                PassBox_2.ToolTip = "";
                PassBox_2.Background = Brushes.Transparent;

                MessageBox.Show("Все хорошо!");

                User user = new User()
                {
                    FristName = FristName,
                    LastName = LastName,
                    Patronymic = Patronymic,
                    Post = Post,
                    Login = Login,
                    Pass = Pass,
                };



                Helper.db.Users.Add(user);
                Helper.db.SaveChanges();

                Entrance Taskwindow = new Entrance();
                Taskwindow.Show();
                this.Close();

            }

        }

        private void Button_Entrance_Click(object sender, RoutedEventArgs e)
        {
            new Entrance().Show();
            this.Close();

        }

    }
}

