using EDBackendAPI.Business.Abstract;
using EDBackendAPI.Business.Contants;
using EDBackendAPI.Core.Entities.Concrete;
using EDBackendAPI.Core.Utilities.Results;
using EDBackendAPI.Core.Utilities.Security.Jwt;
using EDBackendAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Business.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        public AuthService(IUserService userService)
        {
            _userService = userService;
        }
        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            return null;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IResult UserExists(string email)
        {
            throw new NotImplementedException();
        }
    }
}
