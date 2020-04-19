namespace University_Management_System_API.Controller.Service.ApiSession
{
    using University_Management_System_API.Business.Convertor.ApiSession;
    using University_Management_System_API.Business.Processor.ApiSession;
    using University_Management_System_API.Controller.Service.Common;

    public class ApiSessionController
        : BaseController<ApiSessionParam, ApiSessionResult, long, IApiSessionProcessor>
    {
        public ApiSessionController(IApiSessionProcessor processor)
            : base(processor)
        {
        }
    }
}
