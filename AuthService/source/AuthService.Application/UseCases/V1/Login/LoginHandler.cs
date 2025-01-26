using AuthService.Application.Interfaces;
using MediatR;

namespace AuthService.Application.UseCases.V1.Login
{
    public class LoginHandler : IRequestHandler<LoginInput, LoginVm>
    {
        private readonly IAuthService _authService;
        private readonly IJwtTokenGenerator _tokenGenerator;

        public LoginHandler(IAuthService authService, IJwtTokenGenerator tokenGenerator)
        {
            _authService = authService;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<LoginVm> Handle(LoginInput request, CancellationToken cancellationToken)
        {
            LoginVm result = new LoginVm();
            if (await _authService.ValidateCredentials(request.Username, request.Password))
            {
                result.Token = await _tokenGenerator.GenerateToken(request.Username);
            }

            return result;
        }
    }
}
