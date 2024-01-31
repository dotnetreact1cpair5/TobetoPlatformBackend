namespace Business.Dtos.Request
{
    public class UpdateClassLessonRequest
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int StudentClassId { get; set; }
    }

}
