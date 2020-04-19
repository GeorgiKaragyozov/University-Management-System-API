namespace University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DepartamentStatusDaoEF : BaseDaoEF<Model.DepartamentStatus, long>, IDepartamentStatusDao
    {
        public DepartamentStatusDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {
        }
    }
}
