namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserGroupStatusDaoFile : BaseDaoFile<Model.UserGroupStatus, long, IUserGroupStatusStorage>,
        IUserGroupStatusDao
    {
        protected override long GetPK(Model.UserGroupStatus entity)
        {
            return entity.Id;
        }

        public UserGroupStatusDaoFile(IUserGroupStatusStorage storage)
          : base(storage)
        {
        }
    }
}
