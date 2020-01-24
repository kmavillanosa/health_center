using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    public interface IAccountContextService
    {
        Account LastAccount { get; set; }
        int LastLogId { get; set; }
        void SetAccount(Account acc, int logId);
    }
    public class AccountContextService : IAccountContextService
    {
        public Account LastAccount { get; set; }
        public int LastLogId { get; set; }

        public void SetAccount(Account acc, int logId)
        {
            LastAccount = acc;
            LastLogId = logId;
        }
    }
}
