namespace Business.Dtos.Request
{
    public class UpdateStudentClassRequest
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
        public string Name { get; set; }
    }

}
