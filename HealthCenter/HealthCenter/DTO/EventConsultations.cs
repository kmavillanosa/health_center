using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    public class EventConsultations : IEntity
    {
        public string Event { get; set; }
        [DisplayName("Ailment / Purpose")]
        public string Ailment { get; set; }
        public string BloodPressure { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public PersonGender ExpectedChildGender { get; set; }
        public DateTime PregnancyDueDate { get; set; }
        public string Diagnosis { get; set; }
        public string Remarks { get; set; }
        public DateTime ConsultationDate { get; set; }
    }
}
