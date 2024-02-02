using Microsoft.AspNetCore.Components.Forms;

namespace FoodDelivery.Utilities
{
    public interface IFileUploadService
    {
        Task<(int, string)> UploadFileAsync(IBrowserFile file, int maxFileSize, string[] allowedExtensions);
        Task<(int, string)> UploadItemAsync(IBrowserFile file, int maxFileSize, string[] allowedExtensions);

    }
}
