using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Contoso.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")] public string FullName => LastName + ", " + FirstMidName;

        [DataType(DataType.Date)]
        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
    }
}