using System.ComponentModel.DataAnnotations;
namespace university_backent.Models.DataModels
{
    public class Chapter: BaseEntity
    {
        public int CourseId { get; set; }
        public virtual curso Curso { get; set; } = new curso();
        [Required]
        public String List { get; set; } = string.Empty;
    }
}
