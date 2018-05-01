namespace ContosoU2018.Models
{
    public class Enrollment
    {
        /* 
         * The enrollment ID property will become the primary key: this entity used the ClassNameID pattern instead of the
         * ID by itself that you have seen in the student entity. 
         */

        public int EnrollmentID { get; set; }  // PK

        public int CourseID { get; set; } // FK with corresponding navigation property Course

        public int StudentID { get; set; } // FK with corresponding navigation property Student

        public Grade? Grade { get; set; } // optional

        // navigation property : each enrollment must be for one student
        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }


    }

    public enum Grade
    {
        A, B, C, D, F
    }
}