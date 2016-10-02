using System;
using System.Collections.Generic;
using System.Linq;

namespace monei.Core.Entities
{
    public class Account :EntityBase<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid Guid { get; set; }
        public AccountRole Role { get; set; }
        public DateTime? LastLogin { get; set; }

        public enum AccountRole
        {
            Administrator,
            User,
        }

        public static Account Create(string username, string password, AccountRole role)
        {
            Account account = new Account()
            {
                Guid = Guid.NewGuid(),
                Username = username,
                Password = password,
                Role = AccountRole.User,
                LastLogin = null,
            };

            return account;
        }
    }
}
