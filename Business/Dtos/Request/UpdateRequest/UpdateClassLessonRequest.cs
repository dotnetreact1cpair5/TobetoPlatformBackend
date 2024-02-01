namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateClassLessonRequest
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int StudentClassId { get; set; }
    }

}
