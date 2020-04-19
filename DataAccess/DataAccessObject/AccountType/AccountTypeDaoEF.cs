namespace University_Management_System_API.DataAccess.DataAccessObject.AccountType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class AccountTypeDaoEF : BaseDaoEF<Model.AccountType, long>, IAccountTypeDao
    {
        public AccountTypeDaoEF(UniversityManagementSystemContext context)
          : base(context)
        {
        }
    }
}
