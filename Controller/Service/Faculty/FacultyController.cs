namespace University_Management_System_API.Controller.Service.Faculty
{
    using University_Management_System_API.Business.Convertor.Faculty;
    using University_Management_System_API.Business.Processor.Faculty;
    using University_Management_System_API.Controller.Service.Common;

    public class FacultyController 
        : BaseController<FacultyParam, FacultyResult,long, IFacultyProcessor>
    {
        public FacultyController(IFacultyProcessor processor)
            : base(processor)
        {
        }
    }
}
