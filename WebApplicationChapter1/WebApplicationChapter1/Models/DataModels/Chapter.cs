using Microsoft.Build.Framework;

namespace WebApplicationChapter1.Models.DataModels
{
    public class Chapter:BaseEntity
    {
        [Required]
        public string List { get; set; } = string.Empty;
        public int CourseId { get; set; }
        [Required]
        public virtual Course Course { get; set; }=new Course();
    }
}
