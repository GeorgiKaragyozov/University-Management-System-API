namespace University_Management_System_API
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class Persistent
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [System.ComponentModel.DefaultValue(1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public sbyte Active { get; set; }
    }
}
