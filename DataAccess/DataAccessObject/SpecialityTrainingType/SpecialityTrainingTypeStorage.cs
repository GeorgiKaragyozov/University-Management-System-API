namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityTrainingType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;
    public class SpecialityTrainingTypeStorage
        : BaseStorage<Model.SpecialityTrainingType, long>, ISpecialityTrainingTypeStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\SpecialityTrainingType\SpecialityTrainingTypeJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.SpecialityTrainingType entity)
        {
            return entity.Id;
        }
    }
}
