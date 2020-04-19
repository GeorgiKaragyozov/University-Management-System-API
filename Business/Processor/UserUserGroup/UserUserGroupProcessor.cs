namespace University_Management_System_API.Business.Processor.UserUserGroup
{
    using University_Management_System_API.Business.Convertor.UserUserGroup;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup;

    public class UserUserGroupProcessor
         : BaseProcessor<IUserUserGroupParamConverter, IUserUserGroupResultConverter, UserUserGroupParam,
             UserUserGroupResult, IUserUserGroupDao, long, Model.UserUserGroup>, IUserUserGroupProcessor
    {
        protected override long GetTPK(UserUserGroupParam param)
        {
            return param.Id;
        }

        public UserUserGroupProcessor(
            IUserUserGroupDao dao,
            IUserUserGroupParamConverter paramConverter,
            IUserUserGroupResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
