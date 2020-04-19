namespace University_Management_System_API.DataAccess.DataAccessObject.UserStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserStatusStorage : BaseStorage<Model.UserStatus, long>, IUserStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\UserStatus\UserStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.UserStatus entity)
        {
            return entity.Id;
        }
    }
}
