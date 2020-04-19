namespace University_Management_System_API.Controller.Service.SpecialityStatus
{
    using University_Management_System_API.Business.Convertor.SpecialityStatus;
    using University_Management_System_API.Business.Processor.SpecialityStatus;
    using University_Management_System_API.Controller.Service.Common;

    public class SpecialityStatusController
         : BaseController<SpecialityStatusParam, SpecialityStatusResult, long, ISpecialityStatusProcessor>
    {
        public SpecialityStatusController(ISpecialityStatusProcessor processor)
             : base(processor)
        {
        }
    }
}
