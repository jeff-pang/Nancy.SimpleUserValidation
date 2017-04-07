using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDatabase
{
    public class Command : IDisposable
    {
        public class Parameter
        {
            public void AddWithValue(string name, object value) { }
        }
        public Command(string command, Connection connection) { }
        public Parameter Parameters { get; set; } = new Parameter();
        public void Dispose()
        {
        }

        public DataReader ExecuteReader() {
            return new DataReader();
        }
    }
}
