namespace universesity.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
