namespace Business.Dtos.Response.DeletedResponse
{
    public class DeletedAccountSocialMediaResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SocialMediaPlatformId { get; set; }
        public string Link { get; set; }
    }
}
