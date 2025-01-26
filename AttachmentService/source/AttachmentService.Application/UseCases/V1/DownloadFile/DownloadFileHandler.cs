using AttachmentService.Application.Interfaces;
using MediatR;

namespace AttachmentService.Application.UseCases.V1.DownloadFile
{
    internal class DownloadFileHandler : IRequestHandler<DownloadFileInput, DownloadFileVm>
    {
        private readonly IBlobStorageService _blobStorageService;

        public DownloadFileHandler(IBlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }

        public async Task<DownloadFileVm> Handle(DownloadFileInput request, CancellationToken cancellationToken)
        {
            DownloadFileVm result = new DownloadFileVm();
            result.FileContent = await _blobStorageService.DownloadFileAsync(request.FileName);
            return result;
        }
    }
}
