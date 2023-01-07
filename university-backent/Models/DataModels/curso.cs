using System.ComponentModel.DataAnnotations;

namespace university_backent.Models.DataModels
{
    public enum Leavel
    {
        Basic,
        Medium,
        Advanced,
        Expert
    }
    public class curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(280)]
        public string descripcion_corta { get; set; } = string.Empty;

        [Required, StringLength(700)]
        public string Descripcion_larga { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string publico_objetivo { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string objetivo { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string requicitos { get; set; } = string.Empty;

        [Required]
        public Leavel nivel { get; set; } = Leavel.Basic;

        [Required]
        public Chapter chapter { get; set; } = new Chapter();

        [Required]

        public ICollection<Category> categories { get; set; } = new List<Category>();

        [Required]
        public ICollection<Student> students { get; set; } = new List<Student>();

    }
}

