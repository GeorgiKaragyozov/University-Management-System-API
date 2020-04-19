namespace University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DepartamentStatusDaoFile
        : BaseDaoFile<Model.DepartamentStatus, long, IDepartamentStatusStorage>, IDepartamentStatusDao
    {
        protected override long GetPK(Model.DepartamentStatus entity)
        {
            return entity.Id;
        }

        public DepartamentStatusDaoFile(IDepartamentStatusStorage storage)
            : base(storage)
        {
        }
    }
}
