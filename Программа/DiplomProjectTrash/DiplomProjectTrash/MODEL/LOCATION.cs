using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProjectTrash.MODEL
{
    public class LOCATION
    {
        public int location_num_id { get; set; }
        public string location_desc { get; set; }

        public LOCATION()
        {
            this.location_num_id = 0;
            this.location_desc = string.Empty;
        }

        public LOCATION(int location_num_id, string location_desc)
        {
            this.location_num_id = location_num_id;
            this.location_desc = location_desc;
        }
    }
}
