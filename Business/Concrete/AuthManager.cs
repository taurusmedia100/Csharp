using Business.Abstact;
using Business.Utilities.Results.Abstract;
using Entities.Model;
using JetonAPI.DTOs.Auth;
using Microsoft.AspNetCore.Identity;

namespace Business.Concrete
{
    public class AuthManager :IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenService _tokenService;

        public Task<IDataResult<Token>> LoginAsync(LoginDTO loginDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> RegisterAsync(RegisterDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
