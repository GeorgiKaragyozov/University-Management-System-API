namespace University_Management_System_API.DataAccess.DataAccessObject.Faculty
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class FacultyStorage : BaseStorage<Model.Faculty, long>, IFacultyStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\Faculty\FacultyJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.Faculty entity)
        {
            return entity.Id;
        }
    }
}
