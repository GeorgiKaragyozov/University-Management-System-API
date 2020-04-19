namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class SpecialityStatusDaoEF : BaseDaoEF<Model.SpecialityStatus, long>, ISpecialityStatusDao
    {
        public SpecialityStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {
        }
    }
}
