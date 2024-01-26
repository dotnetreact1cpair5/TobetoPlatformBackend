﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SocialMediaPlatform : Entity<int>
    {
        public string Name { get; set; }
        public AccountSocialMedia AccountSocialMedia { get; set; }
    }
}