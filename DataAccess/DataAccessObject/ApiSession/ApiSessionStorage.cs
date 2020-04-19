namespace University_Management_System_API.DataAccess.DataAccessObject.ApiSession
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class ApiSessionStorage : BaseStorage<Model.ApiSession, long>, IApiSessionStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core-API\University-Management-System-API\DataBaseJson\ApiSession\ApiSessionJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.ApiSession entity)
        {
            return entity.Id;
        }
    }
}
