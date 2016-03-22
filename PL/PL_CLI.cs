using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
namespace PL
{
    public class PL_CLI : IPL
    {
        IBL itsBL;

        public PL_CLI(IBL bl)
        {
            itsBL = bl;
        }

        public void Run()
        {
            long Id = VerifyCredentials();
            passwordChange(Id);
        }

        public void passwordChange(long ID)
        {
            Console.WriteLine("hello m8");
            Console.WriteLine("My name is boris and i am here to change your password! of course i nead your premission so may i have it?");
            Console.WriteLine("Enter yes if you want");
            String UsersChoise = Console.ReadLine();
            if (UsersChoise.Equals("Yes"))
            {
                Console.WriteLine("Fine So what password should it be? if you regret you can steal press no ;)");
                String NewPassword = Console.ReadLine();

                if(NewPassword!="no")
                {
                    if ((itsBL.GetType() == typeof(BL_v1)))
                    {
                        itsBL.changePassword(ID, NewPassword);
                    }
                }


            }

        }

        public long VerifyCredentials()
        {
            throw new NotImplementedException();
        }
    }
}




