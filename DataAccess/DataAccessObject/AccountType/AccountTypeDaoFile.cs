namespace University_Management_System_API.DataAccess.DataAccessObject.AccountType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class AccountTypeDaoFile : BaseDaoFile<Model.AccountType, long, IAccountTypeStorage>, IAccountTypeDao
    {
        protected override long GetPK(Model.AccountType entity)
        {
            return entity.Id;
        }

        public AccountTypeDaoFile(IAccountTypeStorage storage)
            : base(storage)
        {
        }
    }
}
