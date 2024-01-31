using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Business.Dtos.Response
{
    public class GetListCoursePageResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentName { get; set; }
        public DateTime CreatedDate { get; set; }

       
       
    }
}
