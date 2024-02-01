using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Core.Utilities.FileUpload
{
    public class CloudinaryAdapter : IFileUploadAdapter
    {
        private readonly Cloudinary _cloudinary;

        public CloudinaryAdapter(IConfiguration configuration)
        {
            Account account = configuration.GetSection("CloudinaryAccount").Get<Account>();
            _cloudinary = new Cloudinary(account);
        }

        public async Task<string> UploadPath(IFormFile file)
        {
            await FileMustBeInPathFormat(file);
            var fileUploadResponse = new ImageUploadResult();

            using (var stream = file.OpenReadStream())
            {
                var parameters = new ImageUploadParams()
                {
                    File = new FileDescription(file.FileName, stream)
                };
                fileUploadResponse = await _cloudinary.UploadAsync(parameters);
            }
            return fileUploadResponse.SecureUri.AbsoluteUri;
        }
        public async Task DeletePath(string PathUrl)
        {
            DeletionParams deletionParams = new(GetPublicId(PathUrl));
            await _cloudinary.DestroyAsync(deletionParams);
        }

        public async Task<string> UpdatePath(IFormFile formFile, string PathUrl)
        {
            await FileMustBeInPathFormat(formFile);

            await DeletePath(PathUrl);
            return await UploadPath(formFile);
        }
        private string GetPublicId(string PathUrl)
        {
            int startIndex = PathUrl.LastIndexOf('/') + 1;
            int endIndex = PathUrl.LastIndexOf('.');
            int length = endIndex - startIndex;
            return PathUrl.Substring(startIndex, length);
        }

        protected async Task FileMustBeInPathFormat(IFormFile formFile)
        {
            List<string> extensions = new() { ".jpg", ".png", ".jpeg", ".webp", ".pdf", ".mp4" };

            string extension = Path.GetExtension(formFile.FileName).ToLower();
            if (!extensions.Contains(extension))
                throw new BusinessException("Unsupported format");
            await Task.CompletedTask;
        }
    }
}
