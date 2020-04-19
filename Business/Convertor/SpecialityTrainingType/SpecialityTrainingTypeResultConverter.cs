namespace University_Management_System_API.Business.Convertor.SpecialityTrainingType
{
    using University_Management_System_API.Business.Convertor.Common;

    public class SpecialityTrainingTypeResultConverter
         : BaseResultConverter<Model.SpecialityTrainingType, SpecialityTrainingTypeResult>,
           ISpecialityTrainingTypeResultConverter
    {
        public override void ConvertSpecific(Model.SpecialityTrainingType entity, SpecialityTrainingTypeResult result)
        {
            result.SpecialityId = entity.Speciality.Id;
            result.SpecialityName = entity.Speciality.Name;
            result.TrainingTypeId = entity.TrainingType.Id;
            result.TrainingTypeName = entity.TrainingType.Name;
        }

        public override SpecialityTrainingTypeResult GetResult()
        {
            return new SpecialityTrainingTypeResult();
        }
    }
}
