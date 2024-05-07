using System.ComponentModel.DataAnnotations;

namespace u20530545_HW01_API.Models
{
    public class Course
    {
        [Key]
        public int courseId { get; set; }

        public string courseName { get; set; } = String.Empty;

        public string courseDescription { get; set; } = String.Empty;

        public string courseDuration {  get; set; }   = String.Empty; 


    }
}
