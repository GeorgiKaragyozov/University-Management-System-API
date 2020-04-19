namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserGroupStatusDaoEF : BaseDaoEF<Model.UserGroupStatus, long>, IUserGroupStatusDao
    {
        public UserGroupStatusDaoEF(UniversityManagementSystemContext context)
          : base(context)
        {
        }
    }
}
