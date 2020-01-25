using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HealthCenter
{
    public enum PersonGender
    {
        NotDefined = 0,
        Male = 1,
        Female = 2,
    }

    public enum CivilStatus
    {
        Single = 0,
        Married = 1,
        Divorced = 2,
        Separated = 3,
        Widowed = 4
    }


    [Table("person"),Category("Person information"),ReadOnly(true)]
    public class Person : EntityBase
    {
        [Computed,DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                var fullname = string.Empty;

                if (!string.IsNullOrEmpty(LastName))
                    fullname += $"{LastName}, ";

                if (!string.IsNullOrEmpty(FirstName))
                    fullname += $"{FirstName} ";

                if (!string.IsNullOrEmpty(Suffix))
                    fullname += $"{Suffix} ";

                if (!string.IsNullOrEmpty(MiddleName))
                    fullname += $"{MiddleName}";

                return fullname.ToUpper();
            }
        }
        [Computed, DisplayName("Patient category")]
        public string PersonCategory
        {
            get
            {
                if(Category != null)
                {
                    return Category.Value;
                }
                else
                {
                    return "No category";
                }
            }
        }

        public CivilStatus CivilStatus { get; set; } = CivilStatus.Single;
        
        public PersonGender Gender { get; set; } = PersonGender.NotDefined;
        public string CivilPartnerName { get; set; }

        [DisplayName("Date of birth"), Browsable(false)]
        public DateTime? BirthDate { get; set; }

        //[DisplayName("Birthday")]
        //public int BirthDay
        //{
        //    get
        //    {
        //        int difference = DateTime.Now.Year - BirthDate.Value.Year;
        //        return difference;

        //    }
        //}

        [Computed, Browsable(false)]
        public virtual PersonCategory Category { get; set; } = null;

        [Computed, Browsable(false)]
        public IEnumerable<Consultation> Consultations { get; set; }

        [Computed, Browsable(false)]
        public IEnumerable<EventConsultations> EventConsultations { get; set; }

        public string Address { get; set; } = null;

        [Browsable(false)]
        public string FirstName { get; set; } = null;
        [Browsable(false)]
        public int CategoryId { get; set; } = 0;
        [Browsable(false)]
        public string LastName { get; set; } = null;
        [Browsable(false)]
        public string MiddleName { get; set; } = null;
        [Browsable(false)]
        public string Suffix { get; set; } = null;

    }
}
