using System.Collections.Generic;
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
         
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        // Navigation properties
        // 1 course, many enrollments 
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        
    }
}