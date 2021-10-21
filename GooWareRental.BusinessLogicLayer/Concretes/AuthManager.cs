using GooWareRental.BusinessLogicLayer.Abstracts;
using GooWareRental.BusinessLogicLayer.ResultMessages;
using GooWareRental.Core.Entities.Concretes;
using GooWareRental.Core.Utilities.Abstracts;
using GooWareRental.Core.Utilities.Concretes;
using GooWareRental.Core.Utilities.Security.Hashing;
using GooWareRental.Core.Utilities.Security.JasonWebToken;
using GooWareRental.Entities.DataTransformationObjects;

namespace GooWareRental.BusinessLogicLayer.Concretes
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                UserEMail = userForRegisterDto.Email,
                UserFirstName = userForRegisterDto.FirstName,
                UserLastName = userForRegisterDto.LastName,
                UserPasswordHash = passwordHash,
                UserPasswordSalt = passwordSalt,
                UserState = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.MSG_USER_REGISTERED);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(null, Messages.MSG_USER_NOT_FOUND);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.UserPasswordHash, userToCheck.UserPasswordSalt))
            {
                return new ErrorDataResult<User>(null, Messages.MSG_PASSWORD_ERROR);
            }

            return new SuccessDataResult<User>(userToCheck, Messages.MSG_SUCCESSFUL_LOGIN);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.MSG_USER_ALREADY_EXISTS);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.MSG_ACCESS_TOKEN_CREATED);
        }
    }
}
