using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Models
{
    public class Person
    {
        /* 
         * These properties will become database fields within the Person table by using the Entity Framework Core.
         * As we see the properties here, they will appear in the database. 
         * The ID property will become the Primary Key column.
         * By default, the EF interprets property that's named ID or *ClassName*ID (PersonID, InstructorID) as the PK.
         */

        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        public string Province { get; set; }

        // Read only properties

        [Display(Name = "Name")]

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public string IDFullName
        {
            get
            {
                return "(" + ID + ") " + LastName + ", " + FirstName;
            }
        }

    }
}
