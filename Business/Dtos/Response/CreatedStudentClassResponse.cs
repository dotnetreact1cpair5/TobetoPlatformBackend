using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedStudentClassResponse
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
        public string Name { get; set; }
    }
}
