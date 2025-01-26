using AuthService.Application.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace AuthService.Infrastructure.Services
{
    public class AuthenticationService : IAuthService
    {
        private readonly IDictionary<string, string> _users = new Dictionary<string, string>();

        public async Task<bool> Register(string username, string password)
        {
            if (_users.ContainsKey(username)) return false;

            _users[username] = HashPassword(password);
            return true;
        }

        public async Task<bool> ValidateCredentials(string username, string password)
        {
            return _users.ContainsKey(username) && _users[username] == HashPassword(password);
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}
