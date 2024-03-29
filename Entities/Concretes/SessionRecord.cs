﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SessionRecord:Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Lesson>? Lessons { get; set; }
    }
}
