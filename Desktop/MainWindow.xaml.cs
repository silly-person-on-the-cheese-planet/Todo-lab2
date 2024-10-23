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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            email_textBoxLogIn.Text = "exam@yandex.ru";
            email_textBoxLogIn.Foreground = new SolidColorBrush(Colors.Gray);
            pass_textBoxLogIn.Text = "Введите пароль";
            pass_textBoxLogIn.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void email_textBoxLogIn_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email_textBoxLogIn.Text == "exam@yandex.ru")
            {
                email_textBoxLogIn.Text = "";
                email_textBoxLogIn.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void email_textBoxLogIn_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_textBoxLogIn.Text))
            {
                email_textBoxLogIn.Text = "exam@yandex.ru";
                email_textBoxLogIn.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void pass_textBoxLogIn_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pass_textBoxLogIn.Text == "Введите пароль")
            {
                pass_textBoxLogIn.Text = "";
                pass_textBoxLogIn.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void pass_textBoxLogIn_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pass_textBoxLogIn.Text))
            {
                pass_textBoxLogIn.Text = "Введите пароль";
                pass_textBoxLogIn.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var proVerka = new InputProverka();

            string email = email_textBoxLogIn.Text;
            string pass = pass_textBoxLogIn.Text;

            bool isEmailProV = proVerka.IsProverkaEmail(email);
            bool isPassProV = proVerka.IsProverkaPass(pass);

            if (isEmailProV && isPassProV) {
                Main_empty mainEmptyForm = new Main_empty();
                mainEmptyForm.ShowDialog();
            }
            else
                MessageBox.Show("Неудачная попытка, попробуйте ещё раз.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 regForm = new Window1();
            regForm.ShowDialog();
        }

    }
}
