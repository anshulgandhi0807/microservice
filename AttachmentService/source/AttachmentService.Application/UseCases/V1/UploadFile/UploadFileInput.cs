using MediatR;
using Microsoft.AspNetCore.Http;

namespace AttachmentService.Application.UseCases.V1.UploadFile
{
    public class UploadFileInput : IRequest<UploadFileVm>
    {
        public IFormFile File { get; set; }
    }
}
