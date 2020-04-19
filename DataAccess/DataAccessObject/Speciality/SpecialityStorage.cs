namespace University_Management_System_API.DataAccess.DataAccessObject.Speciality
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class SpecialityStorage : BaseStorage<Model.Speciality, long>, ISpecialityStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\Speciality\SpecialityJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.Speciality entity)
        {
            return entity.Id;
        }
    }
}
