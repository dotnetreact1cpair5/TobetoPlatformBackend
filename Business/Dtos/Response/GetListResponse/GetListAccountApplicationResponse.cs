namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAccountApplicationResponse
    {
        public int Id { get; set; }

        public int AccountId { get; set; }
        public int ApplicationId { get; set; }
        public int ApplicationStepId { get; set; }
        //public string AccountName { get; set; }
        //public string DocumentName { get; set; }
        //public string ApplicationStepName { get; set; }
    }
}
