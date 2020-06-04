using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProjectTrash.MODEL
{
    public class SETTING
    {
        public string db_status { get; set; }

        public SETTING()
        {
            this.db_status = string.Empty;
        }

        public SETTING(string db_status)
        {
            this.db_status = db_status;
        }
    }
}
