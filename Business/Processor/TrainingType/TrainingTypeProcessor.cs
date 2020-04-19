namespace University_Management_System_API.Business.Processor.TrainingType
{
    using University_Management_System_API.Business.Convertor.TrainingType;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.TrainingType;

    public class TrainingTypeProcessor
         : BaseProcessor<ITrainingTypeParamConverter, ITrainingTypeResultConverter, TrainingTypeParam,
            TrainingTypeResult, ITrainingTypeDao, long, Model.TrainingType>, ITrainingTypeProcessor
    {
        protected override long GetTPK(TrainingTypeParam param)
        {
            return param.Id;
        }

        public TrainingTypeProcessor(
            ITrainingTypeDao dao,
            ITrainingTypeParamConverter paramConverter,
            ITrainingTypeResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
