namespace University_Management_System_API.DataAccess.DataAccessObject.AccountStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class AccountStatusStorage : BaseStorage<Model.AccountStatus, long>, IAccountStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\AccountStatus\AccountStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.AccountStatus entity)
        {
            return entity.Id;
        }
    }
}
