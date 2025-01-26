using AuthService.Application.Interfaces;
using MediatR;

namespace AuthService.Application.UseCases.V1.Registration
{
    public class RegistrationHandler: IRequestHandler<RegistrationInput, RegistrationVm>
    {
        private readonly IAuthService _authService;

        public RegistrationHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<RegistrationVm> Handle(RegistrationInput request, CancellationToken cancellationToken)
        {
            RegistrationVm result = new RegistrationVm();
            bool isSuccess =  await _authService.Register(request.Username, request.Password);

            result.IsSuccess = isSuccess;
            result.Message = isSuccess ? "Done" : "Failed";

            return result;
        }
    }
}
