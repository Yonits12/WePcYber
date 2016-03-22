using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SharedClasses;

namespace BL
{
    public class BL_v1 : IBL
    {
        IDAL itsDAL;

        public BL_v1(IDAL dal)
        {
            itsDAL = dal;
        }

        public void changePassword(long Id,String passWord)
        {
            User MyUser = itsDAL.RetrivUserData(Id);
            MyUser.passwordUpdate(passWord);
            itsDAL.UpdateUser(MyUser);
        }

        public long VerifyCredentials(string UserName, string Password)
        {
            throw new NotImplementedException();
        }
    }
}
