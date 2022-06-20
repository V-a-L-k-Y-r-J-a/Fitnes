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
    /// Логика взаимодействия для Entrance.xaml
    /// </summary>
    public partial class Entrance : Window
    {
        public Entrance()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxLogin.Text == "" || passBox.Password == "")
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                User user = Helper.db.Users.FirstOrDefault(q => q.Login == textBoxLogin.Text && q.Pass == passBox.Password);
                if (user != null)
                {
                    Helper.userSession = user;
                    new Cabinet().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильные логин или пароль");
                }
            }
        }
        private void Button_Registration_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}

