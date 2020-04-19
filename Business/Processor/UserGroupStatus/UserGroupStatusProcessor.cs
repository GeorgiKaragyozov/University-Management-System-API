namespace University_Management_System_API.Business.Processor.UserGroupStatus
{
    using University_Management_System_API.Business.Convertor.UserGroupStatus;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus;

    public class UserGroupStatusProcessor
         : BaseProcessor<IUserGroupStatusParamConverter, IUserGroupStatusResultConverter, UserGroupStatusParam,
             UserGroupStatusResult, IUserGroupStatusDao, long, Model.UserGroupStatus>, 
                IUserGroupStatusProcessor
    {
        protected override long GetTPK(UserGroupStatusParam param)
        {
            return param.Id;
        }

        public UserGroupStatusProcessor(
            IUserGroupStatusDao dao,
            IUserGroupStatusParamConverter paramConverter,
            IUserGroupStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
