using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Security.Claims;
using WebAPIPractice.Repository;

namespace WebAPIPractice
{
    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            using(UserMasterRepository _repo = new UserMasterRepository())
            {
                var user = _repo.ValidateUser(context.UserName, context.Password);
                if(user == null)
                {
                    context.SetError("Invalid_Grant", "Provided username and password is invalid");
                    return;
                }
                var claimsIdentity = new ClaimsIdentity(context.Options.AuthenticationType);
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, user.UserRoles));
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                claimsIdentity.AddClaim(new Claim("Email", user.UserEmailID));
                context.Validated(claimsIdentity);
            }
        }
    }
}