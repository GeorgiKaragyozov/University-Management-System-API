namespace University_Management_System_API.Controller.Service.UserGroup
{
    using University_Management_System_API.Business.Convertor.UserGroup;
    using University_Management_System_API.Business.Processor.UserGroup;
    using University_Management_System_API.Controller.Service.Common;

    public class UserGroupController
        : BaseController<UserGroupParam, UserGroupResult, long, IUserGroupProcessor>
    {
        public UserGroupController(IUserGroupProcessor processor)
            : base(processor)
        {
        }
    }
}
