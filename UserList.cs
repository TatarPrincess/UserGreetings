using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersGreeting
{
    public class UserList
    {
        public List <User> users;

        public UserList()
        { 
          users= new List<User>();
          users.Add(new User("Tanya", "Tanya Kim", true));
          users.Add(new User("Sasha", "Sasha Kim", false));
          users.Add(new User("Igor", "Igor Kim", false));
        }        
    }
}
