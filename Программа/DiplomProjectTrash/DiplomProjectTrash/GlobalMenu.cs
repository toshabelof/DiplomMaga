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
        public GlobalMenu()
        {
            InitializeComponent();
        }

        AuthForm authForm = new AuthForm();
        Settings settingsForm = new Settings();
        Archive archiveForm = new Archive();
        AddIPcam addIPcamForm = new AddIPcam();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GlobalMenu_Load(object sender, EventArgs e)
        {
            authForm.ShowDialog();
            if (!authForm.vStatusAuth) 
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            archiveForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addIPcamForm.ShowDialog(); //
        }
    }
}
