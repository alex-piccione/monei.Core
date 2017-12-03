using System;
using System.Collections.Generic;
using System.Linq;
using monei.Core.Entities;

namespace monei.Core.Repositories
{
    public interface IAccountRepository
    {
        Account Read(string username);
        void SetLastLoginDate(int id, DateTime when);
    }
}
