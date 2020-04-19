namespace University_Management_System_API.DataAccess.DataAccessObject.Account
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class AccountStorage : BaseStorage<Model.Account, long>, IAccountStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\Account\AccountJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.Account entity)
        {
            return entity.Id;
        }
    }
}
