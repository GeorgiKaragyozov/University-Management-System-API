namespace University_Management_System_API.DataAccess.DataAccessObject.Lecture
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class LectureDaoEF : BaseDaoEF<Model.Lecture, long>, ILectureDao
    {
        public LectureDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {
        }
    }
}
