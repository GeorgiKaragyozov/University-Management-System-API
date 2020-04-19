namespace University_Management_System_API.Business.Processor.UserGroupStatus
{
    using University_Management_System_API.Business.Convertor.UserGroupStatus;
    using University_Management_System_API.Business.Processor.Common;

    public interface IUserGroupStatusProcessor : IBaseProcessor<UserGroupStatusParam, UserGroupStatusResult, long>
    {
    }
}
