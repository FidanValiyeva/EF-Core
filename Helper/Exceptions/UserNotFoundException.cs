using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Helper.Exceptions
{
    internal class UserNotFoundException:Exception
    {
        public UserNotFoundException(string msg) : base(msg)
        {
        }
        public UserNotFoundException() { }

    }
}
