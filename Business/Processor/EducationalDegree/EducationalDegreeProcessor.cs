namespace University_Management_System_API.Business.Processor.EducationalDegree
{
    using University_Management_System_API.Business.Convertor.EducationalDegree;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree;

    public class EducationalDegreeProcessor
        : BaseProcessor<IEducationalDegreeParamConverter, IEducationalDegreeResultConverter,
           EducationalDegreeParam, EducationalDegreeResult, IEducationalDegreeDao,
           long, Model.EducationalDegree>, IEducationalDegreeProcessor
    {
        protected override long GetTPK(EducationalDegreeParam param)
        {
            return param.Id;
        }

        public EducationalDegreeProcessor(
            IEducationalDegreeDao dao,
            IEducationalDegreeParamConverter paramConverter,
            IEducationalDegreeResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
