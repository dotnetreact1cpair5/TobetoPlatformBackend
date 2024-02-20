namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountSocialMediaRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SocialMediaPlatformId { get; set; }
        public string Link { get; set; }
    }
}
