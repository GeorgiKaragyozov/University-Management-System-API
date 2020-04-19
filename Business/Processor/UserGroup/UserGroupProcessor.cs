namespace University_Management_System_API.Business.Processor.UserGroup
{
    using University_Management_System_API.Business.Convertor.UserGroup;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.UserGroup;

    public class UserGroupProcessor
         : BaseProcessor<IUserGroupParamConverter, IUserGroupResultConverter, UserGroupParam, UserGroupResult,
             IUserGroupDao, long, Model.UserGroup>, IUserGroupProcessor
    {
        protected override long GetTPK(UserGroupParam param)
        {
            return param.Id;
        }

        public UserGroupProcessor(
            IUserGroupDao dao,
            IUserGroupParamConverter paramConverter,
            IUserGroupResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
