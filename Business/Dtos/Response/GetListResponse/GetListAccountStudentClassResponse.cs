namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAccountStudentClassResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountFirstLastName { get; set; }
        public string StudentClassName { get; set; }
    }
}
