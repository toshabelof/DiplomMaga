using System;
using DiplomProjectTrash.VIEW_MODEL;
using System.Windows.Forms;
using System.Drawing;

namespace DiplomProjectTrash
{
    public partial class Settings : Form
    {
        DB_UTIL dB_UTIL;

        public Settings(DB_UTIL dB_UTIL)
        {
            InitializeComponent();
            this.dB_UTIL = dB_UTIL;
        }

        // Метод вызывается после загрузки формы
        private void Settings_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.det_upalgoritm;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.db_login))
                textBox1.Text = Properties.Settings.Default.db_login;

            if(!string.IsNullOrEmpty(Properties.Settings.Default.db_password))
                textBox2.Text = Properties.Settings.Default.db_password;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.db_dbname))
                textBox3.Text = Properties.Settings.Default.db_dbname;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.db_timesave.ToString()))
                textBox4.Text = Properties.Settings.Default.db_timesave.ToString();
        }

        // Кнопка "Подключиться"
        private void button1_Click(object sender, EventArgs e)
        {
            dB_UTIL.db_login = textBox1.Text;
            dB_UTIL.db_password = textBox2.Text;
            dB_UTIL.db_name = textBox3.Text;

            try
            {
                dB_UTIL.DB_CONNECT();
                label6.Text = "OK!";
                label6.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                label6.Text = "Error!";
                label6.ForeColor = Color.Red; 
                LIB_UTIL.MassageError(ex);                
            }
        }

        //Метод вызывается до закрытия формы
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.det_upalgoritm = checkBox1.Checked;

            if (!string.IsNullOrEmpty(textBox1.Text))
                Properties.Settings.Default.db_login = textBox1.Text;

            if (!string.IsNullOrEmpty(textBox2.Text))
                Properties.Settings.Default.db_password = textBox2.Text;

            if (!string.IsNullOrEmpty(textBox3.Text))
                Properties.Settings.Default.db_dbname = textBox3.Text;

            if (!string.IsNullOrEmpty(textBox4.Text))
                Properties.Settings.Default.db_timesave = Convert.ToInt32(textBox4.Text);

            Properties.Settings.Default.Save();
        }
    }
}
