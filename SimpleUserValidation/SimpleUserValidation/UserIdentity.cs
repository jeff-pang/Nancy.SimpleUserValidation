using Nancy.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUserValidation
{
    class UserIdentity : IUserIdentity
    {
        public Guid Guid { get; set; }
        public string UserName { get; set; }

        public IEnumerable<string> Claims { get; set; }
    }
}
