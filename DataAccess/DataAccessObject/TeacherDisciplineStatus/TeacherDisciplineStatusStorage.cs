namespace University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TeacherDisciplineStatusStorage 
        : BaseStorage<Model.TeacherDisciplineStatus, long>, ITeacherDisciplineStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\TeacherDisciplineStatus\TeacherDisciplineStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.TeacherDisciplineStatus entity)
        {
            return entity.Id;
        }
    }
}
