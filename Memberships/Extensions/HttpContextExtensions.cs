using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Security.Claims;

namespace Memberships.Extensions
{
    public static class HttpContextExtensions
    {
        private const string nameidentifier = "http://schemas.xmlsoap.org/ws/2005/05/identiy/claims/nameidentifier";


        public static string GetUserId(this HttpContextBase ctx)
        {
            string uid = String.Empty;
            try
            {
                var claims = ctx.GetOwinContext()
                    .Get<ApplicationSignInManager>()
                    .AuthenticationManager.User.Claims
                    .FirstOrDefault(claim => claim.Type.Equals(nameidentifier));

                // check if the user is logged in and a claim exists
                if (claims != default(Claim)) uid = claims.Value;
            }
            catch
            {
            }
            return uid;
        }

    }
}
