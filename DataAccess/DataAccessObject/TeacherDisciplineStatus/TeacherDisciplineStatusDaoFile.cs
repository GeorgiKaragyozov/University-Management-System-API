namespace University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TeacherDisciplineStatusDaoFile
         : BaseDaoFile<Model.TeacherDisciplineStatus, long, ITeacherDisciplineStatusStorage>, ITeacherDisciplineStatusDao
    {
        protected override long GetPK(Model.TeacherDisciplineStatus entity)
        {
            return entity.Id;
        }

        public TeacherDisciplineStatusDaoFile(ITeacherDisciplineStatusStorage storage)
          : base(storage)
        {
        }
    }
}
