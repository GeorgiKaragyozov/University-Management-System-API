namespace University_Management_System_API.Business.Convertor.SpecialityTrainingType
{
    public class SpecialityTrainingTypeResult : BaseResultNamed
    {
        public string SpecialityName { get; set; }
        public long SpecialityId { get; set; }

        public string TrainingTypeName { get; set; }
        public long TrainingTypeId { get; set; }
    }
}
