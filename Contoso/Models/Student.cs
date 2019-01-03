using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("Last Name")] public string LastName { get; set; }
        [DisplayName("First Name")] public string FirstMidName { get; set; }

        [DisplayName("Enrollment Name")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}