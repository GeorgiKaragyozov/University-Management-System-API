namespace University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TeacherDisciplineStatusDaoEF : BaseDaoEF<Model.TeacherDisciplineStatus, long>,
        ITeacherDisciplineStatusDao
    {
        public TeacherDisciplineStatusDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {
        }
    }
}
