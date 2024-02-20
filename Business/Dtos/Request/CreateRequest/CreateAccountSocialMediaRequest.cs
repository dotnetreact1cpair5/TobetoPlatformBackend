namespace Business.Dtos.Request
{
    public class CreateAccountSocialMediaRequest
    {
        public int AccountId { get; set; }
        public int SocialMediaPlatformId { get; set; }
        public string Link { get; set; }
    }
}
