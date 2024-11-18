using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Models
{
    internal class Users
    {
        public int Id {  get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;
    }

}
