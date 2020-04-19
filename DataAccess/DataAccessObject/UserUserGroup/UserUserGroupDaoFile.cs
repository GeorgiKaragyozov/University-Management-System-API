namespace University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserUserGroupDaoFile
        : BaseDaoFile<Model.UserUserGroup, long, IUserUserGroupStorage>, IUserUserGroupDao
    {
        protected override long GetPK(Model.UserUserGroup entity)
        {
            return entity.Id;
        }

        public UserUserGroupDaoFile(IUserUserGroupStorage storage)
          : base(storage)
        {
        }
    }
}
