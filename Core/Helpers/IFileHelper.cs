using Core.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public interface IFileHelper
    {

        IDataResult<string> Upload(IFormFile file, string path, string fileType);
        Results.IResult Delete(string path, string file);
        Results.IResult Move(string oldPath, string newPath);
        IDataResult<string> FileControl(IFormFile file, string[] fileExtention);
        IDataResult<string[]> FileExtensionRotates(string FileType);
    }
}
