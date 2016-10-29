using monei.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei.Core.BusinessLogic
{
    public interface IAccountSecurity
    {
        LoginResult Login(string username, string password, bool caseSensitive = false);

        void ChangePassword(string username, string newPassword);
    }
}
