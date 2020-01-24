using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    public class CollectionLoadedEventArgs<TEntity> : EventArgs
    {
        public TEntity Data { get; set; }
    }
}
