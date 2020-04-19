namespace University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DepartamentStatusStorage : BaseStorage<Model.DepartamentStatus, long>, IDepartamentStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\DepartamentStatus\DepartamentStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.DepartamentStatus entity)
        {
            return entity.Id;
        }
    }
}
