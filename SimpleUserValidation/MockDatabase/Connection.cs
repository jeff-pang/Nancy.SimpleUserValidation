using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDatabase
{
    public class Connection : IDisposable
    {
        public Connection(string fakeConnectionString) { }
        public void Open() { }
        public void Dispose()
        {
        }
    }
}
