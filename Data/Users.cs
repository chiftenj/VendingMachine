using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    class Users
    {
        
        public Users()
        {
            
        }

        public static User GetUser()
        {
            return new User()
            {
                FullUsername = "Elliot A.",
                Avatar = "/Images/avatar.png"
            };
        }
    }
}
