namespace University_Management_System_API.DataAccess.DataAccessObject.TrainingType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TrainingTypeStorage : BaseStorage<Model.TrainingType, long>, ITrainingTypeStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\TrainingType\TrainingTypeJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.TrainingType entity)
        {
            return entity.Id;
        }
    }
}
