using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    public interface IModule : IUIComponent
    {
        AccountType AccountType { get; set; }
    }
}
