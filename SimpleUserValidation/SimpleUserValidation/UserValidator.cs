using Nancy.Authentication.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Security;
using System.Security.Claims;
using MockDatabase;

namespace SimpleUserValidation
{
    public class UserValidator : IUserValidator
    {
        public IUserIdentity Validate(string userid, string password)
        {
            using (var conn = new Connection("fake database connection"))
            {
                using (var cmd = new Command("select something where userid=@userid", conn))
                {
                    var reader = cmd.ExecuteReader();
                    string username = reader.GetString("username");
                    string pwd = reader.GetString("password");
                    if (pwd == password)
                    {
                        var claims = new List<string>();
                        claims.Add("basicrole");

                        var user= new UserIdentity() {
                            UserName =username,
                            Claims = claims,
                            Guid = new Guid()
                        };

                        return user;
                    }
                }
            }
            
            return null;
        }
    }
}
