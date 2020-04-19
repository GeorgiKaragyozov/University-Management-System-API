namespace University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserUserGroupDaoEF : BaseDaoEF<Model.UserUserGroup, long>, IUserUserGroupDao
    {
        public UserUserGroupDaoEF(UniversityManagementSystemContext context)
          : base(context)
        {
        }
    }
}
