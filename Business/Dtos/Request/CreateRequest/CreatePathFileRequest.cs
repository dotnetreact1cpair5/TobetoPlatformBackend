using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreatePathFileRequest
    {
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public string? Extension { get; set; }
    }
}
