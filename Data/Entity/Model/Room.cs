namespace University_Management_System_API.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Room : PersistentNamed
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual RoomStatus Status { get; set; }
    }
}
