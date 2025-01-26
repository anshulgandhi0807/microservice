using AttachmentService.Application.Interfaces;
using MediatR;

namespace AttachmentService.Application.UseCases.V1.UploadFile
{
    public class UploadFileHandler : IRequestHandler<UploadFileInput, UploadFileVm>
    {
        private readonly IBlobStorageService _blobStorageService;

        public UploadFileHandler(IBlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }
        public async Task<UploadFileVm> Handle(UploadFileInput request, CancellationToken cancellationToken)
        {
            var fileUrl = await _blobStorageService.UploadFileAsync(request.File);
            return new UploadFileVm { FileUrl = fileUrl };
        }
    }
}
