﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateDistrictRequest
    {
        public int CityId { get; set; }
        public string Name { get; set; }
    }
}
