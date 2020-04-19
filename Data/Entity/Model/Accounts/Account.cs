namespace University_Management_System_API.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Account : PersistentNamed
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Egn { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string MobilePhone { get; set; }
        public string HomePhone { get; set; }
        public string Email { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual AccountStatus Status { get; set; }

        [ForeignKey("Speciality")]
        public long SpecialityId { get; set; }
        public virtual Speciality Speciality { get; set; }

        [ForeignKey("Departament")]
        public long DepartamentId { get; set; }
        public virtual Departament Departament { get; set; }

        [ForeignKey("TypeAccount")]
        public long TypeAccountId { get; set; }
        public virtual AccountType TypeAccount { get; set; }
    }
}

