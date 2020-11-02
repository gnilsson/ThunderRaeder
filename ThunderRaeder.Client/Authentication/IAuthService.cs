using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThunderRaeder.Shared.Authentication;

namespace ThunderRaeder.Client.Authentication
{
    public interface IAuthService
    {
        public Task<AuthenticationResult> Register(UserRegistrationRequest userRegistrationRequest);
        public Task<AuthenticationResult> Login(UserLoginRequest userLoginRequest);
        public Task<string> RefreshToken();
        public Task Logout();
    }
}
