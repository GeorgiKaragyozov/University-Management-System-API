namespace University_Management_System_API.DataAccess.DataAccessObject.TeacherDiscipline
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TeacherDisciplineDaoFile
        : BaseDaoFile<Model.TeacherDiscipline, long, ITeacherDisciplineStorage>, ITeacherDisciplineDao
    {
        protected override long GetPK(Model.TeacherDiscipline entity)
        {
            return entity.Id;
        }

        public TeacherDisciplineDaoFile(ITeacherDisciplineStorage storage)
          : base(storage)
        {
        }
    }
}
