using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.DeletedResponse
{
    public class DeletedAnnouncementResponse
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime AnnouncementDate { get; set; }
    }
}
