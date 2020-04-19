namespace University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DisciplineStatusStorage : BaseStorage<Model.DisciplineStatus, long>, IDisciplineStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\DisciplineStatus\DisciplineStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.DisciplineStatus entity)
        {
            return entity.Id;
        }
    }
}
