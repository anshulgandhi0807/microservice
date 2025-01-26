using AttachmentService.Application.UseCases.V1.DownloadFile;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AttachmentService.WebAPI.UseCases.V1.DownloadFile
{
    public class DownloadFileController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DownloadFileController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRoutes.Attachment.Download)]
        public async Task<IActionResult> DownloadFile([FromQuery] string fileName)
        {
            DownloadFileInput downloadFileInput = new DownloadFileInput
            {
                FileName = fileName
            };
            var response = await _mediator.Send(downloadFileInput);
            return Ok(response);
        }
    }
}
