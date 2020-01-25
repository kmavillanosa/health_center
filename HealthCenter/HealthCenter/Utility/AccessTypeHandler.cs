using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    public interface IAccessTypeHandler
    {
        AccountType Type { get; set; }
        void SetType(AccountType type);
    }

    public class AccessTypeHandler : IAccessTypeHandler
    {
        public AccountType Type { get; set; }

        public void SetType(AccountType type)
        {
            Type = type;
        }
    }
}
