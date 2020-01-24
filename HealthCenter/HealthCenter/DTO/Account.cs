using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HealthCenter
{
    public enum AccountType
    {
        Administrator = 101,
        Regular = 100,
        Guest = 102,
        None = 0,
    }
    public enum AccountStatus
    {
        Active = 1,
        Inactive = 0,
        None = 0,
    }

    [Table("useraccount")]
    public class Account : EntityBase
    {
        public string Username { get; set; } = null;
        [PasswordPropertyText(true),Browsable(false)]
        public string Password { get; set; } = null;
        public AccountType Type { get; set; } = AccountType.None;
        public AccountStatus AccountStatus { get; set; } = AccountStatus.None;

        [Computed]
        public IEnumerable<AccountLogs> Logs { get; set; }

    }
    [Table("accountlogs")]
    public class AccountLogs : EntityBase
    {
        public int AccountId { get; set; }
        [Computed]
        public DateTime TimeIn { get; set; }

        public DateTime TimeOut { get; set; }

        [Browsable(false),Computed]
        public override DateTime? LastModified { get; set; }
    }
}
