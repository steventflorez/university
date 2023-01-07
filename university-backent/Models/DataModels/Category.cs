using System.ComponentModel.DataAnnotations;

namespace university_backent.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required]
        public String name { get; set; } = string.Empty;
        public ICollection<curso> cursos { get; set; } = new List<curso>();
    }
}
