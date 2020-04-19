namespace University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class DisciplineStatusDaoFile
        : BaseDaoFile<Model.DisciplineStatus, long, IDisciplineStatusStorage>, IDisciplineStatusDao
    {
        protected override long GetPK(Model.DisciplineStatus entity)
        {
            return entity.Id;
        }

        public DisciplineStatusDaoFile(IDisciplineStatusStorage storage)
            : base(storage)
        {
        }
    }
}
