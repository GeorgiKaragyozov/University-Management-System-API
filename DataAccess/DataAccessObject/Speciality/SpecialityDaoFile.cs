namespace University_Management_System_API.DataAccess.DataAccessObject.Speciality
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class SpecialityDaoFile : BaseDaoFile<Model.Speciality, long, ISpecialityStorage>, ISpecialityDao
    {
        protected override long GetPK(Model.Speciality entity)
        {
            return entity.Id;
        }

        public SpecialityDaoFile(ISpecialityStorage storage)
          : base(storage)
        {
        }
    }
}
