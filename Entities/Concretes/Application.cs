﻿using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Application : Entity<int>
    {
       
        public int ApplicationStepId { get; set; }
        public int OrganizationId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string DocumentName { get; set; }

        public  ApplicationStep? ApplicationStep { get; set; }
        public  Organization? Organization { get; set; }
        public User? User { get; set; }
    }
}
