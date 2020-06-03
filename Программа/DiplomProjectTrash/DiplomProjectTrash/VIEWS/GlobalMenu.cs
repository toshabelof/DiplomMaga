using DiplomProjectTrash.VIEW_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProjectTrash
{
    public partial class GlobalMenu : Form
    {
        static DB_UTIL dB_UTIL = new DB_UTIL();

        public GlobalMenu()
        {
            InitializeComponent();
        }

        AuthForm authForm = new AuthForm();
        Settings settingsForm = new Settings(dB_UTIL);
        Archive archiveForm = new Archive();
        AddIPcam addIPcamForm = new AddIPcam(dB_UTIL);

        // Метод вызывается перед открытием формы
        private void GlobalMenu_Load(object sender, EventArgs e)
        {
            authForm.ShowDialog();
            if (!authForm.vStatusAuth) 
            {
                this.Close();
            }

            this.Text = String.Concat(LIB_UTIL.PROG_NAME, ' ', LIB_UTIL.PROG_VERS);
        }

        // Кнопка "Настройки"
        private void button1_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        // Кнопка "Архив"
        private void button2_Click(object sender, EventArgs e)
        {
            archiveForm.ShowDialog();
        }

        // Кнопка "Добавить камеру"
        private void button5_Click(object sender, EventArgs e)
        {
            addIPcamForm.ShowDialog();
        }

        /// <summary>
        /// Метод вызывается до закрытия формы.
        /// </summary>
        private void GlobalMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            dB_UTIL.DB_CLOSE();
        }
    }
}
