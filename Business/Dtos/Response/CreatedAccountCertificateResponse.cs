﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedAccountCertificateResponse
    {
        public int Id {  get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string FileFormat { get; set; }
    }
}