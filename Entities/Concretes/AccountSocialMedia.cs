using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountSocialMedia : Entity<int>
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public int SocialMediaPlatformId { get; set; }
        public SocialMediaPlatform SocialMediaPlatform { get; set; }
        public string Link { get; set; }
    }
}
