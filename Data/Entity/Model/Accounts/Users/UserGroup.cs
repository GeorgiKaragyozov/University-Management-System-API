namespace University_Management_System_API.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserGroup : PersistentNamed
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }

        public virtual UserGroupStatus Status { get; set; }
    }
}
