namespace University_Management_System_API.DataAccess.DataAccessObject.AccountType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class AccountTypeStorage : BaseStorage<Model.AccountType, long>, IAccountTypeStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\AccountType\AccountTypeJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.AccountType entity)
        {
            return entity.Id;
        }
    }
}
