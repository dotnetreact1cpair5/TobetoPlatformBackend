using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateAccountCertificateRequest
    {
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string FileFormat { get; set; }
    }
}
