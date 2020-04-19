namespace University_Management_System_API.DataAccess.DataAccessObject.TrainingType
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class TrainingTypeDaoEF : BaseDaoEF<Model.TrainingType, long>, ITrainingTypeDao
    {
        public TrainingTypeDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {
        }
    }
}
