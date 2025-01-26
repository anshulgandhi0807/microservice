using MediatR;

namespace AttachmentService.Application.UseCases.V1.DownloadFile
{
    public class DownloadFileInput :IRequest<DownloadFileVm>
    {
        public string FileName { get; set; }
    }
}
