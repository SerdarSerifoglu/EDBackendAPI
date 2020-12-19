using EDBackendAPI.Core.DataAccess;
using EDBackendAPI.Core.Entities;
using EDBackendAPI.Entities.Concrete;
using EDBackendAPI.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaimDto> GetClaims(User user);
    }
}
