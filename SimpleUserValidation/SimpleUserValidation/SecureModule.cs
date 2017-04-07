using Nancy;
using Nancy.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUserValidation
{
    public class SecureModule:NancyModule
    {
        public SecureModule()
        {
            this.RequiresAuthentication();

            Get["secure"] = p =>
             {
                 var identity = Context.CurrentUser as UserIdentity;
                 string role = "none";
                 if(identity.HasClaim("basicrole"))
                 {
                     role = "basic";
                 }

                 return $"Access Granted to {identity?.UserName} with role {role}";
             };
        }
    }
}
