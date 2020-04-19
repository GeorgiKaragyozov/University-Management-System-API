namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityTrainingType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class SpecialityTrainingTypeDaoFile
        : BaseDaoFile<Model.SpecialityTrainingType, long, ISpecialityTrainingTypeStorage>,
        ISpecialityTrainingTypeDao
    {
        protected override long GetPK(Model.SpecialityTrainingType entity)
        {
            return entity.Id;
        }

        public SpecialityTrainingTypeDaoFile(ISpecialityTrainingTypeStorage storage)
          : base(storage)
        {
        }
    }
}
