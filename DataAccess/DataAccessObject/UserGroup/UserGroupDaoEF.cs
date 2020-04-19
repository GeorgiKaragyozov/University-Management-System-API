namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroup
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserGroupDaoEF : BaseDaoEF<Model.UserGroup, long>, IUserGroupDao
    {
        public UserGroupDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {
        }
    }
}
