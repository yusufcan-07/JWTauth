using System;
using System.Threading.Tasks;
using JWTauth.Interfaces;
using JWTauth.Models;

namespace JWTauth.Services
{
    public class AuthService :IAuthService
    {
        public Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request)
        {
            UserLoginResponse response = new UserLoginResponse();

            if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request.Username == "yusuf" && request.Password == "123456")
            {
                response.AccessTokenExpireDate = DateTime.UtcNow;
                response.AuthenticateResult = true;
                response.AuthToken = string.Empty;
            }

            return Task.FromResult(response);
        }

    }
}