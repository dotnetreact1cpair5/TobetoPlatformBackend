﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.DeleteRequest
{
    public class DeleteSocialMediaRequest
    {
        public int Id { get; set; }
        public string SocialMediaName { get; set; }
        public string Description { get; set; }
    }
}
