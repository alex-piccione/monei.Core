using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monei.Core.BusinessLogic
{
    using Repositories;
    using Entities;

    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository accountRepository;

        public AccountManager(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public Account Read(string username)
        {
            return accountRepository.Read(username);
        }
    }
}
