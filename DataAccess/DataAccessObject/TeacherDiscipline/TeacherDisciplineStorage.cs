namespace University_Management_System_API.DataAccess.DataAccessObject.TeacherDiscipline
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TeacherDisciplineStorage : BaseStorage<Model.TeacherDiscipline, long>, ITeacherDisciplineStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\TeacherDiscipline\TeacherDisciplineJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.TeacherDiscipline entity)
        {
            return entity.Id;
        }
    }
}
