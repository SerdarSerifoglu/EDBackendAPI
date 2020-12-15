using EDBackendAPI.Core.Entities;
using EDBackendAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.DataAccess.Abstract
{
    public interface IUserDal : IEntity
    {
        List<OperationClaim> GetClaims(User user);
    }
}
