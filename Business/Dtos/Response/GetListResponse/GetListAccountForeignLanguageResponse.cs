namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAccountForeignLanguageResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string ForeignLanguageName { get; set; }
        public string ForeignLanguageLevelName { get; set; }
    }
}
