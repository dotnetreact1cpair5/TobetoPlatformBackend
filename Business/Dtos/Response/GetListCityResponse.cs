﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class GetListCityResponse
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
    }
}
