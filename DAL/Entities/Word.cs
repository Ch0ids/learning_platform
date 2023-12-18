using DAL.Entities.Common;

namespace DAL.Entities
{
    public class Word : BaseEntity<Guid>
    {
        public required string Term { get; set; }
        public string? Definition { get; set; }
        public string? Explaination { get; set; }
        public string? Pronounciation { get; set; }
        //public string? Example { get; set; }
        public int? Frequency { get; set; }
        public int? RepeatedLeftover { get; set; }
        public bool? IsMarked { get; set; }
        public Guid LessonId { get; set; }

        public virtual Lesson? Lesson { get; set; }
    }
}
