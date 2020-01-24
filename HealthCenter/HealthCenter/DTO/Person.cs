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


        public PersonGender Gender { get; set; } = PersonGender.NotDefined;

        [DisplayName("Date of birth")]
        public DateTime? BirthDate { get; set; }

        [Computed, Browsable(false)]
        public virtual PersonCategory Category { get; set; } = null;

        [Computed, Browsable(false)]
        public IEnumerable<Consultation> Consultations { get; set; }

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
