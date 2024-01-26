namespace Business.Dtos.Request
{
    public class UpdateEducationProgramRequest
    {
        public int Id { get; set; }
        public int UniversityId { get; set; }
        public string Name { get; set; }
    }
}
