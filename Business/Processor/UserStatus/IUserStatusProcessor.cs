namespace University_Management_System_API.Business.Processor.UserStatus
{
    using University_Management_System_API.Business.Convertor.UserStatus;
    using University_Management_System_API.Business.Processor.Common;

    public interface IUserStatusProcessor : IBaseProcessor<UserStatusParam, UserStatusResult, long>
    {
    }
}
