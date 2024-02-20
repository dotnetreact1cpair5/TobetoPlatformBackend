namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedAccountSocialMediaResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SocialMediaPlatformId { get; set; }
        public string Link { get; set; }
    }
}
