namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountCourseRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int StudentClassId { get; set; }
    }
}
