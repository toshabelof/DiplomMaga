using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomProjectTrash
{
    class LIB_UTIL
    {
        public const string PROG_NAME = "PROJECT TRASH";
        public const string PROG_VERS = "v1.20.0602";

        public static void Massage(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        public static void Massage(string text)
        {
            MessageBox.Show(text);
        }

        public static void MassageError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MassageError(string text)
        {
            MessageBox.Show(text, "Возникла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MassageWarning(Exception ex)
        {
            MessageBox.Show(ex.Message, "Возникла предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MassageWarning(string text)
        {
            MessageBox.Show(text, "Возникла предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MassageInfo(Exception ex)
        {
            MessageBox.Show(ex.Message, "Возникла предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MassageInfo(string text)
        {
            MessageBox.Show(text, "Возникла предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
