using GooWareRental.Core.Entities.Concretes;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Core.Utilities.Security.JasonWebToken;
using GooWareRental.Entities.DataTransformationObjects;

namespace GooWareRental.BusinessLogicLayer.Abstracts
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
