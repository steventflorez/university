using System.ComponentModel.DataAnnotations;

namespace university_backent.Models.DataModels
{
    public class Student: BaseEntity
    {
        [Required]
        public String FirstName { get; set; } = String.Empty;
        [Required]
        public String LastName { get; set; } = string.Empty;

        [Required]
        public DateTime Dob { get; set; }

        public ICollection<curso> Cursos { get; set; } = new List<curso>();
    }
}
