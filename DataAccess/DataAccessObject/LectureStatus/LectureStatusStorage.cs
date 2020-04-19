namespace University_Management_System_API.DataAccess.DataAccessObject.LectureStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class LectureStatusStorage : BaseStorage<Model.LectureStatus, long>, ILectureStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\LectureStatus\LectureStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.LectureStatus entity)
        {
            return entity.Id;
        }
    }
}
