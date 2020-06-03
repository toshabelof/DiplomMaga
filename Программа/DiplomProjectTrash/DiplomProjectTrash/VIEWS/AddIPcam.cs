using DiplomProjectTrash.VIEW_MODEL;
using System;
using System.Windows.Forms;

namespace DiplomProjectTrash
{
    public partial class AddIPcam : Form
    {
        DB_UTIL dB_UTIL; 
        
        public AddIPcam(DB_UTIL dB_UTIL)
        {
            InitializeComponent();
            this.dB_UTIL = dB_UTIL;
        }

        private void AddIPcam_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            foreach (var idx in dB_UTIL.GET_LOCATION())
            {
                comboBox1.Items.Add(idx.location_desc);
            }
        }
    }
}
