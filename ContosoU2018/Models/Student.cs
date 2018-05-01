using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2018.Models
{
    public class Student: Person
    {
        // Student specific properties

        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}", ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        // 1 Student, many enrollments. This is the navigation property between students and enrollments.
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        /*
         * The enrollment property is a navigation propety (EF Core). Navigation properties hold other entities 
         * that are related to this entity. In this case, the enrollments property of a student entity will hold all 
         * of the enrollments that are related to that student. 
         * 
         * In other words, if a given student row in the database has 2 related enrollment rows, 
         * (rows that contain that student's PK value in their foreign key column), that student entity's enrollment navigation 
         * property will contain those two enrollment entities. 
         * 
         * Navigation properties are typically defined as cirtual so that they can take advantage of certain EF functionality
         * such as lazy loading. 
         * Note: Lazy loading is not yet available in the EF Core (but has in EF 5, 6, ...)
         * 
         * Lazy loading is not enabled by default - so that means that when a particular student entity is instantiated, 
         * it will automatically load all related entities. 
         */
    }
}
