namespace University_Management_System_API.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class User : Persistent
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual UserStatus Status { get; set; }
    }
}
