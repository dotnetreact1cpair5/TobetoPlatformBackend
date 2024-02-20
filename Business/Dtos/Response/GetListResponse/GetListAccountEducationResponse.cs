namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAccountEducationResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int EducationStatusId { get; set; }
        public int UniversityId { get; set; }
        public int EducationProgramId { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime GraduationYear { get; set; }
        public bool IsGraduated { get; set; }
    }
}
