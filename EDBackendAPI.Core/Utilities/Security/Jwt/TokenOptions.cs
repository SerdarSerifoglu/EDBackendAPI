using System;
using System.Collections.Generic;
using System.Text;

namespace EDBackendAPI.Core.Utilities.Security.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; } //TR Anlam, Audience: İzleyici
        public string Issuer { get; set; }//TR Anlam, Issuer: Sağlayıcı
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
