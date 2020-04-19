namespace University_Management_System_API.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class Speciality : PersistentNamed
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual SpecialityStatus Status { get; set; }

        [ForeignKey("EducationalDegree")]
        public long EducationalDegreeId { get; set; }
        public virtual EducationalDegree EducationalDegree { get; set; }

        [ForeignKey("Faculty")]
        public long FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
