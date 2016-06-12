using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TATADALLib;
namespace TATAIdentityLib
{
    public class CredentialManager
    {
       public static bool Validate(string userName, string password)
       {
          bool status= CredentialDAL.validate(userName, password);
          return status;
       }
       public static bool ChangePassword(string userName, string oldPassword, string newPassword)
       {
           return true;
       }
    }
}
