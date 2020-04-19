namespace University_Management_System_API.Business.Processor.UserStatus
{
    using University_Management_System_API.Business.Convertor.UserStatus;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.UserStatus;

    public class UserStatusProcessor 
        : BaseProcessor<IUserStatusParamConverter, IUserStatusResultConverter, UserStatusParam,
            UserStatusResult, IUserStatusDao, long, Model.UserStatus> ,IUserStatusProcessor 
    {
        protected override long GetTPK(UserStatusParam param)
        {
            return param.Id;
        }

        public UserStatusProcessor(
            IUserStatusDao dao,
            IUserStatusParamConverter paramConverter,
            IUserStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
