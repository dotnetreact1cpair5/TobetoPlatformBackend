using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAnnouncementResponse
    {
        public int Id { get; set; }
        public string AnnouncementTypeName { get; set; }
        public string OrganizationName { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
