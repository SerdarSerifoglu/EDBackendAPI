﻿using EDBackendAPI.Core.Entities.Concrete;
using EDBackendAPI.Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaimDto> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
