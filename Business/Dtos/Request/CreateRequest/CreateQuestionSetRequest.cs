using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateQuestionSetRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string TotalQuestion { get; set; }
        public string Type { get; set; }
        //public bool Status { get; set; }
    }
}
