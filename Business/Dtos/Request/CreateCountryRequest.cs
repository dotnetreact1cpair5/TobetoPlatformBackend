﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateCountryRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
