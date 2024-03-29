﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedAccountExperienceResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CityId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobDescription { get; set; }
    }
}
