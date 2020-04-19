namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserStorage : BaseStorage<Model.User, long>, IUserStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\User\UserJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.User entity)
        {
            return entity.Id;
        }
    }
}
