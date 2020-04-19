namespace University_Management_System_API.DataAccess.DataAccessObject.Account
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class AccountDaoEF : BaseDaoEF<Model.Account, long>, IAccountDao
    {
        public AccountDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {
        }
    }
}
