using AuthService.Application.UseCases.V1.Registration;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.WebAPI.UseCases.V1.Registration
{
    public class RegistrationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RegistrationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.Auth.Register)]
        public async Task<IActionResult> Register(RegistrationInput request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }
    }
}
