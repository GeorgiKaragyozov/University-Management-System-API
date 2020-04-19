namespace University_Management_System_API.Controller.Service.UserGroupStatus
{
    using University_Management_System_API.Business.Convertor.UserGroupStatus;
    using University_Management_System_API.Business.Processor.UserGroupStatus;
    using University_Management_System_API.Controller.Service.Common;

    public class UserGroupStatusController
        : BaseController<UserGroupStatusParam, UserGroupStatusResult, long, IUserGroupStatusProcessor>
    {
        public UserGroupStatusController(IUserGroupStatusProcessor processor)
           : base(processor)
        {
        }
    }
}
