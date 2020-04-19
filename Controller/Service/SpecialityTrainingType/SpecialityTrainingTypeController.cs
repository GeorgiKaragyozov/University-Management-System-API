namespace University_Management_System_API.Controller.Service.SpecialityTrainingType
{
    using University_Management_System_API.Business.Convertor.SpecialityTrainingType;
    using University_Management_System_API.Business.Processor.SpecialityTrainingType;
    using University_Management_System_API.Controller.Service.Common;

    public class SpecialityTrainingTypeController
          : BaseController<SpecialityTrainingTypeParam, SpecialityTrainingTypeResult, long, ISpecialityTrainingTypeProcessor>
    {
        public SpecialityTrainingTypeController(ISpecialityTrainingTypeProcessor processor)
             : base(processor)
        {
        }
    }
}
