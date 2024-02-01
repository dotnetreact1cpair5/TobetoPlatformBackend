using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Business.Dtos.Response.GetListResponse
{
    public class GetListCoursePageResponse
    {
        public int Id { get; set; }
        public int PathFileId { get; set; }
        public string CourseName { get; set; }
        public DateTime CreatedDate { get; set; }



    }
}
