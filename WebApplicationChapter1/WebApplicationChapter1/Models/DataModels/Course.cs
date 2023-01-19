using System.ComponentModel.DataAnnotations;


namespace WebApplicationChapter1.Models.DataModels
{
    public class Course:BaseEntity
    {
        [Required]
        public string CourseName { get; set; } =string.Empty;
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

    }

    public enum Level
    {
        NULL,
        Basic,
        Intermediate,
        Advanced
    }

}
