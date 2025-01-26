namespace AuthService.Application.Interfaces
{
    public interface IAuthService
    {
        Task<bool> Register(string username, string password);
        Task<bool> ValidateCredentials(string username, string password);
    }
}
