namespace University_Management_System_API.Model
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class SpecialityTrainingType : PersistentNamed
    {
        [ForeignKey("TrainingType")]
        public long TrainingTypeId { get; set; }
        public virtual TrainingType TrainingType { get; set; }


        [ForeignKey("Speciality")]
        public long SpecialityId { get; set; }
        public virtual Speciality Speciality { get; set; }
    }
}
