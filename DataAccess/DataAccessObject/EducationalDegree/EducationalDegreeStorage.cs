namespace University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class EducationalDegreeStorage : BaseStorage<Model.EducationalDegree, long>, IEducationalDegreeStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\EducationalDegree\EducationalDegreeJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.EducationalDegree entity)
        {
            return entity.Id;
        }
    }
}
