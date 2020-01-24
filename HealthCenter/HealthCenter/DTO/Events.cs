using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    //Id, Title, Description, LastModified
    [Table("events")]
    public class PersonEvents : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }

        [Computed, Browsable(false)]
        public IEnumerable<EventLogs> Logs { get; set; }

        [Computed]
        public int PersonCount
        {
            get
            {
                if (Logs != null && Logs.Count() > 0)
                {
                    return Logs.Count();
                }
                else
                {
                    return 0;
                }
            }
        }

    }

    [Table("eventlogs")]
    public class EventLogs : EntityBase
    {
        [Browsable(false)]
        public int Event { get; set; }

        [Browsable(false)]
        public int PersonId { get; set; }

        [Browsable(false)]
        public int ConsultationId { get; set; }

        [Computed,Browsable(false)]
        public Consultation Consultation { get; set; }
        

        [Computed, DisplayName("Participant")]
        public string FullName
        {
            get
            {
                if(Person != null)
                {
                    var fullname = string.Empty;

                    if (!string.IsNullOrEmpty(Person.LastName))
                        fullname += $"{Person.LastName}, ";

                    if (!string.IsNullOrEmpty(Person.FirstName))
                        fullname += $"{Person.FirstName} ";

                    if (!string.IsNullOrEmpty(Person.Suffix))
                        fullname += $"{Person.Suffix} ";

                    if (!string.IsNullOrEmpty(Person.MiddleName))
                        fullname += $"{Person.MiddleName}";

                    return fullname.ToUpper();
                }
                else
                {
                    return null;
                }
            }
        }

        [Computed, DisplayName("Date participated")]
        public override DateTime? LastModified { get; set; }

        [Computed,Browsable(false)]
        public Person Person { get; set; }
    }
}
