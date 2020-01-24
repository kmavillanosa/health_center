using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter.Events
{
    public class ControlChangedEventArgs<TControl> : EventArgs
    {
        public TControl CurrentControl { get; set; }
    }
}
