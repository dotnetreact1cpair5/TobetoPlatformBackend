using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.FileUpload
{
    public interface IFileUploadAdapter
    {
        Task<string> UploadPath(IFormFile file);
        Task DeletePath(string PathUrl);
        Task<string> UpdatePath(IFormFile formFile, string PathUrl);
    }
}
