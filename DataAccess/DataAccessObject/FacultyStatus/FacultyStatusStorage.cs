namespace University_Management_System_API.DataAccess.DataAccessObject.FacultyStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class FacultyStatusStorage : BaseStorage<Model.FacultyStatus, long>, IFacultyStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\FacultyStatus\FacultyStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.FacultyStatus entity)
        {
            return entity.Id;
        }
    }
}
