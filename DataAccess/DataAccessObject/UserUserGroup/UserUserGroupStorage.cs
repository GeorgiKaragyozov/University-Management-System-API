namespace University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserUserGroupStorage : BaseStorage<Model.UserUserGroup, long>, IUserUserGroupStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System\University-Management-System-Core-API\University-Management-System-API\DataBaseJson\UserUserGroup\UserUserGroupJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.UserUserGroup entity)
        {
            return entity.Id;
        }
    }
}
