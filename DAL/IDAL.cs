using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClasses;
namespace DAL
{
    interface IDAL
    {
        List<User> RetrivAllUsersData();
        User RetrivUserData(long ID);
        bool UpdateUser(User use);
        bool RegisterUser(User use);
    }
}

