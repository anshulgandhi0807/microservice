using MediatR;

namespace AuthService.Application.UseCases.V1.Login
{
    public class LoginInput : IRequest<LoginVm>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
