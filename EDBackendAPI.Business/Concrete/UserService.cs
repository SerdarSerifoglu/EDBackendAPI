using EDBackendAPI.Business.Abstract;
using EDBackendAPI.Core.Entities.Concrete;
using EDBackendAPI.Core.Entities.Dtos;
using EDBackendAPI.DataAccess.Abstract;
using EDBackendAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(x => x.Email == email);
        }

        public List<OperationClaimDto> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
