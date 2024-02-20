using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedAnnouncementResponse
    {
        public int Id { get; set; }
        public int AnnouncementTypeId { get; set; }
        public int OrganizationId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
