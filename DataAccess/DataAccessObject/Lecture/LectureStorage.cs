namespace University_Management_System_API.DataAccess.DataAccessObject.Lecture
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class LectureStorage : BaseStorage<Model.Lecture, long>, ILectureStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\Lecture\LectureJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.Lecture entity)
        {
            return entity.Id;
        }
    }
}
