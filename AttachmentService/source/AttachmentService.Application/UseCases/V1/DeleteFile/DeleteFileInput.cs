using MediatR;

namespace AttachmentService.Application.UseCases.V1.DeleteFile
{
    public class DeleteFileInput : IRequest<DeleteFileVm>
    {
        public string FileName { get;set; }
    }
}
