namespace University_Management_System_API.DataAccess.DataAccessObject.Departament
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DepartamentDaoEF : BaseDaoEF<Model.Departament, long>,  IDepartamentDao
    {
        public DepartamentDaoEF(UniversityManagementSystemContext context)
         : base(context)
        {
        }
    }
}
