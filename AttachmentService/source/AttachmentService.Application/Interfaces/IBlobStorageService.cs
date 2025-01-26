using Microsoft.AspNetCore.Http;

namespace AttachmentService.Application.Interfaces
{
    public interface IBlobStorageService
    {
        Task<string> UploadFileAsync(IFormFile file);
        Task<IEnumerable<string>> ListFilesAsync();
        Task<Stream> DownloadFileAsync(string fileName);
        Task<bool> DeleteFileAsync(string fileName);
    }
}
