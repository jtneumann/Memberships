using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Memberships.Extensions;

namespace Memberships.Controllers
{
    public class RegisterCodeController : Controller
    {
       public async Task<ActionResult> Register(string code)
        {
            if (Request.IsAuthenticated)
            {
                // Ext. method for fetching the user id
                var userId = HttpContext.GetUserId();

                // Ext. method for registering a code with a user
                var registered = await SubscriptionExtensions
                    .RegisterUserSubscriptionCode(code, userId);

                if (!registered) throw new ApplicationException();

                return PartialView("_RegisterCodePartial");
            }
            return View();
        }
    }
}