namespace University_Management_System_API.Business.Processor.Speciality
{
    using University_Management_System_API.Business.Convertor.Speciality;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Speciality;

    public class SpecialityProcessor
        : BaseProcessor<ISpecialityParamConverter, ISpecialityResultConverter, SpecialityParam,
            SpecialityResult, ISpecialityDao, long, Model.Speciality>, ISpecialityProcessor
    {
        protected override long GetTPK(SpecialityParam param)
        {
            return param.Id;
        }

        public SpecialityProcessor(
            ISpecialityDao dao,
            ISpecialityParamConverter paramConverter,
            ISpecialityResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
