using EDBackendAPI.Core.Entities.Concrete;
using EDBackendAPI.Core.Utilities.Results;
using EDBackendAPI.Core.Utilities.Security.Jwt;
using EDBackendAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
