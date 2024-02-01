using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedCoursePageResponse
    {
        public int Id { get; set; }
        public int PathFileId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
