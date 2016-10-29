using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monei.Core.Entities;

namespace monei.Core.Repositories
{
    public interface IAccountRepository
    {
        Account Read(string username);
        void UpdateLastLogin(int id, DateTime utcNow);
    }
}
