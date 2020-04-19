namespace University_Management_System_API.DataAccess.DataAccessObject.TeacherDiscipline
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TeacherDisciplineDaoEF : BaseDaoEF<Model.TeacherDiscipline, long>, ITeacherDisciplineDao
    {
        public TeacherDisciplineDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {
        }
    }
}
