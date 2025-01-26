using AttachmentService.Application.Interfaces;
using MediatR;

namespace AttachmentService.Application.UseCases.V1.DeleteFile
{
    public class DeleteFileHandler : IRequestHandler<DeleteFileInput,DeleteFileVm>
    {
        private readonly IBlobStorageService _blobStorageService;

        public DeleteFileHandler(IBlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }

        public async Task<DeleteFileVm> Handle(DeleteFileInput request, CancellationToken cancellationToken)
        {
            DeleteFileVm res = new DeleteFileVm();
            bool isDeleted = await _blobStorageService.DeleteFileAsync(request.FileName);
            
            res.IsDeleted = isDeleted;
            res.Message = isDeleted ? "Deleted successfully!" : "Something went wrong. Please try again later.";
            
            return res;
        }
    }
}
