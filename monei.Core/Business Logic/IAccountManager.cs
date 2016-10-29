using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monei.Core.BusinessLogic
{
    using Entities;

    public interface IAccountManager
    {
        Account Read(string username);
    }
}
