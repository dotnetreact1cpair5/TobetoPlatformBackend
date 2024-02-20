namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateEducationProgramRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UniversityId { get; set; }
    }
}
