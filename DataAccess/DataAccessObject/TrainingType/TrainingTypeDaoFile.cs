namespace University_Management_System_API.DataAccess.DataAccessObject.TrainingType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TrainingTypeDaoFile 
        : BaseDaoFile<Model.TrainingType, long, ITrainingTypeStorage>, ITrainingTypeDao
    {
        protected override long GetPK(Model.TrainingType entity)
        {
            return entity.Id;
        }

        public TrainingTypeDaoFile(ITrainingTypeStorage storage)
          : base(storage)
        {
        }
    }
}
