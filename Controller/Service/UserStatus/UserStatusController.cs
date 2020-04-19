namespace University_Management_System_API.Controller.Service.UserStatus
{
    using University_Management_System_API.Business.Convertor.UserStatus;
    using University_Management_System_API.Business.Processor.UserStatus;
    using University_Management_System_API.Controller.Service.Common;

    public class UserStatusController 
        : BaseController<UserStatusParam, UserStatusResult, long, IUserStatusProcessor>
    {
        public UserStatusController(IUserStatusProcessor processor) 
            : base(processor)
        {
        }
    }
}
