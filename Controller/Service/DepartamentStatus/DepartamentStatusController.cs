namespace University_Management_System_API.Controller.Service.DepartamentStatus
{
    using University_Management_System_API.Business.Convertor.DepartamentStatus;
    using University_Management_System_API.Business.Processor.DepartamentStatus;
    using University_Management_System_API.Controller.Service.Common;

    public class DepartamentStatusController
        : BaseController<DepartamentStatusParam, DepartamentStatusResult, long, IDepartamentStatusProcessor>
    {
        public DepartamentStatusController(IDepartamentStatusProcessor processor)
           : base(processor)
        {
        }
    }
}
