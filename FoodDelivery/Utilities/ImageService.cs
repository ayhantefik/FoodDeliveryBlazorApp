using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FoodDelivery.Utilities
{
    public class ImageService : IFileUploadService
    {

        private readonly IWebHostEnvironment _environment;

        public ImageService(IWebHostEnvironment environment, ILogger<ImageService> logger)
        {
            _environment = environment;
        }
        public async Task<(int, string)> UploadFileAsync(IBrowserFile file, int maxFileSize, string[] allowedExtensions)
        {
            var uploadDirectory = Path.Combine(_environment.WebRootPath, "eateryimg");
            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }

            if (file.Size > maxFileSize)
            {
                return (0, $"File: {file.Name} exceeds the maximum allowed file size.");
            }

            var fileExtension = Path.GetExtension(file.Name);
            if (!allowedExtensions.Contains(fileExtension))
            {
                return (0, $"File: {file.Name}, File type not allowed");
            }

            var path = Path.Combine(uploadDirectory, file.Name);
            await using var fs = new FileStream(path, FileMode.Create);
            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);

            return (1, file.Name);
        }
        public async Task<(int, string)> UploadItemAsync(IBrowserFile file, int maxFileSize, string[] allowedExtensions)
        {
            var uploadDirectory = Path.Combine(_environment.WebRootPath, "productsimages");
            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }

            if (file.Size > maxFileSize)
            {
                return (0, $"File: {file.Name} exceeds the maximum allowed file size.");
            }

            var fileExtension = Path.GetExtension(file.Name);
            if (!allowedExtensions.Contains(fileExtension))
            {
                return (0, $"File: {file.Name}, File type not allowed");
            }

            var path = Path.Combine(uploadDirectory, file.Name);
            await using var fs = new FileStream(path, FileMode.Create);
            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);

            return (1, file.Name);
        }
    }
}
