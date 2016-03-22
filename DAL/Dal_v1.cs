using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses;

namespace DAL
{
    class Dal_v1 : IDAL
    {
        List<User> UserList;
        public Dal_v1(List<User> UserList)
        {
            this.UserList = UserList;
        }

        public bool RegisterUser(User use)
        {
            throw new NotImplementedException();
        }

        public List<User> RetrivAllUsersData()
        {
            throw new NotImplementedException();
        }

        public User RetrivUserData(long ID)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User use)
        {
            throw new NotImplementedException();
        }
    }
}
