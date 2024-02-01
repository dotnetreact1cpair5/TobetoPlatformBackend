namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateStudentClassRequest
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
        public string Name { get; set; }
    }

}
