using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserLogin
    {
        
            public bool login(string username, string password)
            {
                if (username.Equals("Admin") && password.Equals("admin123"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        
        static void Main(string[] args)
        {
        }
    }
}
