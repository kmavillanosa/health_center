using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    [Table("medical_consultation")]
    public class Consultation : EntityBase
    {
        [Browsable(false)]
        public int PersonId { get; set; }
        [Computed, DisplayName("Ailment")]
        public string AilmentDetail
        {
            get
            {
                string res = string.Empty;
                if (Ailment != null)
                {
                    res += $"{Ailment.Name} " + Environment.NewLine;
                    res += Ailment.Description;
                }

                return res;
            }
        }

        [Browsable(false)]
        public int AilmentGroupId { get; set; }

        public string Diagnosis { get; set; }
        public string Remarks { get; set; }

        [Computed, DisplayName("Consultation date")]
        public override DateTime? LastModified { get; set; }

        [Computed,Browsable(false)]
        public Ailments Ailment { get; set; }

    }
}
