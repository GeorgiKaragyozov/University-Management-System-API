namespace University_Management_System_API.Controller.Service.EducationalDegree
{
    using University_Management_System_API.Business.Convertor.EducationalDegree;
    using University_Management_System_API.Business.Processor.EducationalDegree;
    using University_Management_System_API.Controller.Service.Common;

    public class EducationalDegreeController
        : BaseController<EducationalDegreeParam, EducationalDegreeResult, long, IEducationalDegreeProcessor>
    {
        public EducationalDegreeController(IEducationalDegreeProcessor processor)
          : base(processor)
        {
        }
    }
}
