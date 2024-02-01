namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountEducationRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime GraduationYear { get; set; }
        public bool IsGraduated { get; set; }
    }
}
