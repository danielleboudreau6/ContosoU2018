using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoU2018.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /*
         * You can turn off Identity (on by default) by using the option above.
         * You have the following 3 options:
         * 1 - None: the database does not generate a value
         * 2 - Identity: Database generates a value when a row is inserted
         * 3 - Computed - Database generates a value when a row is inserted or updated.
         */
        [Display(Name = "Course Number")] 
        public int CourseID { get; set; }

        [StringLengthAttribute(50, MinimumLength =3)]
        [Required]
        public string Title { get; set; }

        [Range(0, 5)] // possible values are : 0, 1, 2, 2, 4, 5
        public int Credits { get; set; }

        // Navigation properties
        // 1 course, many enrollments 
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        
    }
}