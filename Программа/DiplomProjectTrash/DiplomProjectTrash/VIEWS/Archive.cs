using System;
using DiplomProjectTrash.VIEW_MODEL;
using System.Windows.Forms;

namespace DiplomProjectTrash
{
    public partial class Archive : Form
    {
        DB_UTIL dB_UTIL;

        public Archive(DB_UTIL dB_UTIL)
        {
            InitializeComponent();
            this.dB_UTIL = dB_UTIL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (var idx in dB_UTIL.GET_ARCHIVE())
            {
                dataGridView1.Rows.Add(idx.photo, idx.coord, idx.ip_cam, idx.location_desc, idx.accauting_date);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LIB_UTIL.Massage(s);
        }
    }
}
