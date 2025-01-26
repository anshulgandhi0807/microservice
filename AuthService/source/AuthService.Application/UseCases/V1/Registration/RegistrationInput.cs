using MediatR;

namespace AuthService.Application.UseCases.V1.Registration
{
    public class RegistrationInput : IRequest<RegistrationVm>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
