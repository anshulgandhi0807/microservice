namespace AuthService.Application.Interfaces
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateToken(string username);
    }
}
