namespace University_Management_System_API.Controller.Service.UserUserGroup
{
    using University_Management_System_API.Business.Convertor.UserUserGroup;
    using University_Management_System_API.Business.Processor.UserUserGroup;
    using University_Management_System_API.Controller.Service.Common;

    public class UserUserGroupController
        : BaseController<UserUserGroupParam, UserUserGroupResult, long, IUserUserGroupProcessor>
    {
        public UserUserGroupController(IUserUserGroupProcessor processor)
            : base(processor)
        {
        }
    }
}
