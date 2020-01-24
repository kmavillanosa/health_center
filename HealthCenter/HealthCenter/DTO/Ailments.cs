using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    [Table("Ailments")]
    public class Ailments : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
