using EDBackendAPI.Business.Abstract;
using EDBackendAPI.DataAccess.Abstract;
using EDBackendAPI.Entities.Concrete;
using EDBackendAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Business.Concrete
{
    public class UserService : IUserService
    {
        IUserDal _userDal;
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
