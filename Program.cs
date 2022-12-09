using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsersGreeting
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userList = new UserList();

            foreach (User user in userList.users)
            {
                Greeting.Greet(user.Name);
                if (!user.IsPremium) Greeting.ShowAds(); 
            }
        }
        
    }
}
