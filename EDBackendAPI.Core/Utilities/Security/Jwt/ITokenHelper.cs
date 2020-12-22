using EDBackendAPI.Core.Entities.Concrete;
using EDBackendAPI.Core.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaimDto> operationClaims);
    }
}
