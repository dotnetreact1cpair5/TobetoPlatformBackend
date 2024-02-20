namespace Business.Dtos.Response.DeletedResponse
{
    public class DeletedAccountForeignLanguageResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ForeignLanguageId { get; set; }
        public int ForeignLanguageLevelId { get; set; }
    }
}
