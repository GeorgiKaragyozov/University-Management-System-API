namespace University_Management_System_API.Business.Convertor.TrainingType
{
    using University_Management_System_API.Business.Convertor.Common;

    public class TrainingTypeResultConverter
        : BaseResultConverter<Model.TrainingType, TrainingTypeResult>, ITrainingTypeResultConverter
    {
        public override void ConvertSpecific(Model.TrainingType entity, TrainingTypeResult result) 
        {
        }

        public override TrainingTypeResult GetResult()
        {
            return new TrainingTypeResult();
        }
    }
}
