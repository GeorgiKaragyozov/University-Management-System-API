namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class UserGroupStatusStorage : BaseStorage<Model.UserGroupStatus, long>, IUserGroupStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System\University-Management-System-Core-API\University-Management-System-API\DataBaseJson\UserGroupStatus\UserGroupStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.UserGroupStatus entity)
        {
            return entity.Id;
        }
    }
}
