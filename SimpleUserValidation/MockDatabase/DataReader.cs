using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDatabase
{
    public class DataReader
    {
        public string GetString(string name)
        {
            if (name == "username")
                return "somename";
            else if(name == "password")
                return "abcd";
            
            return null;
        }
    }
}
