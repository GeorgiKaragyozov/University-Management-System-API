namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class SpecialityStatusStorage : BaseStorage<Model.SpecialityStatus, long>, ISpecialityStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\SpecialityStatus\SpecialityStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.SpecialityStatus entity)
        {
            return entity.Id;
        }
    }
}
