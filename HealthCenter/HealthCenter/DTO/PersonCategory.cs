using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthCenter
{
    [Table("personcategory")]
    public class PersonCategory : EntityBase
    {
        public string Value { get; set; } = null;
        public string Description { get; set; } = null;
    }
}
