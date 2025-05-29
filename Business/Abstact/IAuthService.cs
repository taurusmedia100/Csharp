using Business.Utilities.Results.Abstract;
using Entities.Model;
using JetonAPI.DTOs.Auth;

namespace Business.Abstact
{
    public interface IAuthService
    {
        Task<IResult> RegisterAsync(RegisterDTO model);
        Task<IDataResult<Token>> LoginAsync(LoginDTO loginDTO);
    }
}
