namespace University_Management_System_API.DataAccess.DataAccessObject.Speciality
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class SpecialityDaoEF : BaseDaoEF<Model.Speciality, long>, ISpecialityDao
    {
        public SpecialityDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {
        }
    }
}
