using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.UpdatedResponse
{
    public class UpdatedAnnouncementResponse
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime AnnouncementDate { get; set; }
    }
}
