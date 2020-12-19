using EDBackendAPI.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
