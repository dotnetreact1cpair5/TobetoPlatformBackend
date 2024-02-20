using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdatePathFileRequest
    {
        public int Id { get; set; }
        public IFormFile? File { get; set; }
        public string Description { get; set; }
    }
}
