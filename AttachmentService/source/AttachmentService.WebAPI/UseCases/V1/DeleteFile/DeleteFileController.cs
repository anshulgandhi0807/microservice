using AttachmentService.Application.UseCases.V1.DeleteFile;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AttachmentService.WebAPI.UseCases.V1.DeleteFile
{
    public class DeleteFileController: ControllerBase
    {
        private readonly IMediator _mediator;
        public DeleteFileController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpDelete(ApiRoutes.Attachment.Delete)]
        public async Task<IActionResult> DeleteFile([FromQuery] string fileName)
        {
            DeleteFileInput deleteFileInput = new DeleteFileInput
            {
                FileName = fileName
            };
            var response = await _mediator.Send(deleteFileInput);
            return Ok(response);
        }
    }
}
