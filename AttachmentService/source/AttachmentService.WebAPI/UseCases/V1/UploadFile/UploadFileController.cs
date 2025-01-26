using AttachmentService.Application.UseCases.V1.UploadFile;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AttachmentService.WebAPI.UseCases.V1.UploadFile
{
    public class UploadFileController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UploadFileController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(ApiRoutes.Attachment.Upload)]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            UploadFileInput imageUploadInput = new UploadFileInput
            {
                File = file
            };
            var response = await _mediator.Send(imageUploadInput);
            return Ok(response);
        }
    }
}
