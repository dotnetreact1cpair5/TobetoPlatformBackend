using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedCourseFavouriteResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CourseId { get; set; }
    }


}
