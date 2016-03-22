using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses
{
    public class User
    {
        private string UserName, Email, Password;
        private long ID;

        public User(string UserName, string Email, string Password, long ID)
        {
            this.UserName = UserName;
            this.Email = Email;
            this.Password = Password;
            this.ID = ID;
        }
    }
}
