namespace University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class EducationalDegreeDaoFile
         : BaseDaoFile<Model.EducationalDegree, long, IEducationalDegreeStorage>, IEducationalDegreeDao
    {
        protected override long GetPK(Model.EducationalDegree entity)
        {
            return entity.Id;
        }

        public EducationalDegreeDaoFile(IEducationalDegreeStorage storage)
            : base(storage)
        {
        }
    }
}
