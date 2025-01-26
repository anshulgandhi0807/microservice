using AttachmentService.Application.Interfaces;
using MediatR;

namespace AttachmentService.Application.UseCases.V1.GetFiles
{
    public class GetFilesHandler : IRequestHandler<GetFilesInput, GetFilesVm>
    {
        private readonly IBlobStorageService _blobStorageService;

        public GetFilesHandler(IBlobStorageService blobStorageService)
        {
            _blobStorageService = blobStorageService;
        }

        public async Task<GetFilesVm> Handle(GetFilesInput request, CancellationToken cancellationToken)
        {
            GetFilesVm result = new GetFilesVm();
            result.Files = await _blobStorageService.ListFilesAsync();
            return result;
        }
    }
}
