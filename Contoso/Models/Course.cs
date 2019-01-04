using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required] [StringLength(50)] public string Title { get; set; }
        
        [Range(0, 5)] public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}