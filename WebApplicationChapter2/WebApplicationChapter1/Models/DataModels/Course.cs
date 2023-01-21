using System.ComponentModel.DataAnnotations;


namespace WebApplicationChapter1.Models.DataModels
{
    public enum Level
    {
        NULL,
        Basic,
        Intermediate,
        Advanced
    }
    public class Course:BaseEntity
    {
        [Required,StringLength(50)]
        public string Name { get; set; } =string.Empty;
        [Required, StringLength(200)]
        public string ShortCourseDescription { get; set; } = string.Empty;
        [Required]
        public string LongCourseDescription { get; set; } = string.Empty;
        [Required]
        public string TargetAudience { get; set; } = string.Empty;
        [Required]
        public string Targets { get; set; } = string.Empty;
        [Required]
        public string Requierments { get; set; }=string.Empty;
        public Level Level { get; set; } = Level.NULL;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();

    }

}
