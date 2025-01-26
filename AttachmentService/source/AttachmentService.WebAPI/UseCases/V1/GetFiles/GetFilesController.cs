using AttachmentService.Application.UseCases.V1.GetFiles;
using AttachmentService.Application.UseCases.V1.UploadFile;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AttachmentService.WebAPI.UseCases.V1.GetFiles
{
    public class GetFilesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GetFilesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet(ApiRoutes.Attachment.List)]
        public async Task<IActionResult> GetFiles()
        {
            GetFilesInput getFilesInput = new GetFilesInput();
            var response = await _mediator.Send(getFilesInput);
            return Ok(response);
        }
    }
}
