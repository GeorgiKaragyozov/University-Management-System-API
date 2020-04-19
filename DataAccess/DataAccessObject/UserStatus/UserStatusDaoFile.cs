namespace University_Management_System_API.DataAccess.DataAccessObject.UserStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserStatusDaoFile
        : BaseDaoFile<Model.UserStatus, long, IUserStatusStorage>, IUserStatusDao
    {

        protected override long GetPK(Model.UserStatus entity)
        {
            return entity.Id;
        }

        public UserStatusDaoFile(IUserStatusStorage storage)
          : base(storage)
        {
        }
    }
}
