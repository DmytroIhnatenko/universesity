namespace universesity.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
