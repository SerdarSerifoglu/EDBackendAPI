﻿using EDBackendAPI.Core.DataAccess;
using EDBackendAPI.Core.Entities;
using EDBackendAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}