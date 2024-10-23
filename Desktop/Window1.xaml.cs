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

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            user_textbox.Text = "Введите имя пользователя";
            user_textbox.Foreground = new SolidColorBrush(Colors.Gray);
            email_textBoxReg.Text = "exam@yandex.ru";
            email_textBoxReg.Foreground = new SolidColorBrush(Colors.Gray);
            pass_textBoxReg.Text = "Введите пароль";
            pass_textBoxReg.Foreground = new SolidColorBrush(Colors.Gray);
            pass2_textBoxReg.Text = "Повторите пароль";
            pass2_textBoxReg.Foreground = new SolidColorBrush(Colors.Gray);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var proVerka = new InputProverka();

            string email = email_textBoxReg.Text;
            string pass = pass_textBoxReg.Text;

            bool isEmailProV = proVerka.IsProverkaEmail(email);
            bool isPassProV = proVerka.IsProverkaPass(pass);

            if (isEmailProV && isPassProV) {
                Main_empty main_Empty = new Main_empty();
                main_Empty.ShowDialog();
            }
            else
                MessageBox.Show("Неудачная попытка, попробуйте ещё раз.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainForm = new MainWindow();
            mainForm.ShowDialog();
        }

        private void user_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (user_textbox.Text == "Введите имя пользователя")
            {
                user_textbox.Text = "";
                user_textbox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void user_textbox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(user_textbox.Text))
            {
                user_textbox.Text = "Введите имя пользователя";
                user_textbox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void email_textBoxReg_GotFocus(object sender, RoutedEventArgs e)
        {
            if (email_textBoxReg.Text == "exam@yandex.ru")
            {
                email_textBoxReg.Text = "";
                email_textBoxReg.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void email_textBoxReg_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_textBoxReg.Text))
            {
                email_textBoxReg.Text = "exam@yandex.ru";
                email_textBoxReg.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void pass_textBoxReg_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pass_textBoxReg.Text == "Введите пароль")
            {
                pass_textBoxReg.Text = "";
                pass_textBoxReg.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void pass_textBoxReg_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pass_textBoxReg.Text))
            {
                pass_textBoxReg.Text = "Введите пароль";
                pass_textBoxReg.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void pass2_textBoxReg_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pass2_textBoxReg.Text == "Повторите пароль")
            {
                pass2_textBoxReg.Text = "";
                pass2_textBoxReg.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void pass2_textBoxReg_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pass2_textBoxReg.Text))
            {
                pass2_textBoxReg.Text = "Повторите пароль";
                pass2_textBoxReg.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
