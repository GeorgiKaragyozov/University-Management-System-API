namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroup
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserGroupStorage : BaseStorage<Model.UserGroup, long>, IUserGroupStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System\University-Management-System-Core-API\University-Management-System-API\DataBaseJson\UserGroup\UserGroupJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.UserGroup entity)
        {
            return entity.Id;
        }
    }
}
