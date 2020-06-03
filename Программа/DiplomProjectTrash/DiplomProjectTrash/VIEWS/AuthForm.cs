using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DiplomProjectTrash
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        const string loginFormat = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                   @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
        public bool vStatusAuth = false;

        private void button1_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox2.Text))
            //{
            //    MessageBox.Show(@"Ошибка аутентификации. Поле ""Логин"" не может быть пустым.");
            //    return;
            //}
            
            //if (!checkLogin(textBox1.Text))
            //{
            //    MessageBox.Show("Ошибка аутентификации. Проверьте введеный логин.");
            //    return;
            //}

            //if (string.IsNullOrEmpty(textBox2.Text))
            //{
            //    MessageBox.Show(@"Ошибка аутентификации. Поле ""Пароль"" не может быть пустым.");
            //    return;
            //}

            vStatusAuth = true;
            this.Close();
        }

        private bool checkLogin(string text)
        {
            try
            {
                return Regex.IsMatch(text,
                                     loginFormat,
                                     RegexOptions.IgnoreCase,
                                     TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
