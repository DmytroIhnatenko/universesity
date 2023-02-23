namespace universesity.Models
{
    public class StudentGroup
    {
        public int StudentGroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
