namespace University_Management_System_API.Controller.Service.TrainingType
{
    using University_Management_System_API.Business.Convertor.TrainingType;
    using University_Management_System_API.Business.Processor.TrainingType;
    using University_Management_System_API.Controller.Service.Common;

    public class TrainingTypeController
         : BaseController<TrainingTypeParam, TrainingTypeResult, long, ITrainingTypeProcessor>
    {
        public TrainingTypeController(ITrainingTypeProcessor processor)
            : base(processor)
        {
        }
    }
}
