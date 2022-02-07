using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Core
{
    public class User
    {
        public User(string username)
        {
            Username = username;
        }

        public string Username { get; set; }
    }
}
