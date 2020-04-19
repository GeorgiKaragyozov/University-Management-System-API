namespace University_Management_System_API.Controller.Service.Speciality
{
    using University_Management_System_API.Business.Convertor.Speciality;
    using University_Management_System_API.Business.Processor.Speciality;
    using University_Management_System_API.Controller.Service.Common;

    public class SpecialityController
        : BaseController<SpecialityParam, SpecialityResult, long, ISpecialityProcessor>
    {
        public SpecialityController(ISpecialityProcessor processor)
              : base(processor)
        {
        }
    }
}
