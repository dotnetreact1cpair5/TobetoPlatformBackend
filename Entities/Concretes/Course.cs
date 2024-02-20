﻿using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<int>
    {
        //public int CourseContentId { get; set; }
        //public int CourseAboutId { get; set; }
        //public int LessonId { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}

