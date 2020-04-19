namespace University_Management_System_API.DataAccess.DataAccessObject.Discipline
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DisciplineStorage : BaseStorage<Model.Discipline, long>, IDisciplineStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\Discipline\DisciplineJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.Discipline entity)
        {
            return entity.Id;
        }
    }
}
