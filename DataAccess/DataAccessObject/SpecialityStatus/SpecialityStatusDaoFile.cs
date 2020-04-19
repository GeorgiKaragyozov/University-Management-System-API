namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class SpecialityStatusDaoFile
        : BaseDaoFile<Model.SpecialityStatus, long, ISpecialityStatusStorage>, ISpecialityStatusDao
    {
        protected override long GetPK(Model.SpecialityStatus entity)
        {
            return entity.Id;
        }

        public SpecialityStatusDaoFile(ISpecialityStatusStorage storage)
          : base(storage)
        {
        }
    }
}
