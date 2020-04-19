namespace University_Management_System_API.Business.Processor.SpecialityStatus
{
    using University_Management_System_API.Business.Convertor.SpecialityStatus;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus;

    public class SpecialityStatusProcessor
        : BaseProcessor<ISpecialityStatusParamConverter, ISpecialityStatusResultConverter,
           SpecialityStatusParam, SpecialityStatusResult, ISpecialityStatusDao,
           long, Model.SpecialityStatus>, ISpecialityStatusProcessor
    {
        protected override long GetTPK(SpecialityStatusParam param)
        {
            return param.Id;
        }

        public SpecialityStatusProcessor(
            ISpecialityStatusDao dao,
            ISpecialityStatusParamConverter paramConverter,
            ISpecialityStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
