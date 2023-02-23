namespace universesity.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public DateTime Date { get; set; }
        public int RoomId { get; set; }
        public int SubjectId { get; set; }
        public int StudentGroupId { get; set; }

        public virtual Room Room { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual StudentGroup StudentGroup { get; set; }
    }
}
