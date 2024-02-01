using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateLessonFavouriteRequest
    {
        public int AccountId { get; set; }
        public int LessonId { get; set; }
    }


}
