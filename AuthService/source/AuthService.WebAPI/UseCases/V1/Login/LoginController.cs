using AuthService.Application.UseCases.V1.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.WebAPI.UseCases.V1.Login
{
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(ApiRoutes.Auth.Login)]
        public async Task<IActionResult> Login(LoginInput request)
        {
            var result = await _mediator.Send(request);
            if (string.IsNullOrEmpty(result.Token)) return Unauthorized(new { message = "Invalid credentials." });

            return Ok(result);
        }
    }
}
