namespace University_Management_System_API.DataAccess.DataAccessObject.Departament
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DepartamentStorage : BaseStorage<Model.Departament, long>, IDepartamentStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\Departament\DepartamentJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.Departament entity)
        {
            return entity.Id;
        }
    }
}
