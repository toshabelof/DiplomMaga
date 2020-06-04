using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomProjectTrash.MODEL
{
    public class ARCHIVE
    {
        public string photo { get; set; }
        public string ip_cam { get; set; }
        public string coord { get; set; }
        public string location_desc { get; set; }
        public string accauting_date { get; set; }

        public ARCHIVE()
        {
            this.photo = string.Empty;
            this.ip_cam = string.Empty;
            this.coord = string.Empty;
            this.location_desc = string.Empty;
            this.accauting_date = string.Empty;
        }

        public ARCHIVE(string photo, string ip_cam, string coord, string location_desc, string accauting_date)
        {
            this.photo = photo;
            this.ip_cam = ip_cam;
            this.coord = coord;
            this.location_desc = location_desc;
            this.accauting_date = accauting_date;
        }
    }
}
