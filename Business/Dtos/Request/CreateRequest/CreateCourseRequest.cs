﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateCourseRequest
    {
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public int ContentTypeId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}