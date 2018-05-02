using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        [StringLength(50, ErrorMessage ="First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(65, ErrorMessage = "Last name cannot be longer than 65 characters.")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)] // you don't always have to include an error message.
        public string Address { get; set; }

        public string City { get; set; }

        [Display(Name = "Postal Code")]
        [Required]
        [StringLength(7)]
        [Column(TypeName="nchar(7)")]
        [DataType(DataType.PostalCode)]
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
