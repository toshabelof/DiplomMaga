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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

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

            Properties.Settings.Default.db_saveobject = checkBox2.Checked;

            Properties.Settings.Default.Save();
        }

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

            checkBox2.Checked = Properties.Settings.Default.db_saveobject;
        }
    }
}
