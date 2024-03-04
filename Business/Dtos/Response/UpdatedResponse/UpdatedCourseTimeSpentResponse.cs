﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.UpdatedResponse
{
    public class UpdatedCourseTimeSpentResponse
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public string TimeSpent { get; set; }
    }
}
