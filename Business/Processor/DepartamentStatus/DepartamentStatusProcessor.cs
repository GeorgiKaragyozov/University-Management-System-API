namespace University_Management_System_API.Business.Processor.DepartamentStatus
{
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.Business.Convertor.DepartamentStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus;

    public class DepartamentStatusProcessor
        : BaseProcessor<IDepartamentStatusParamConverter, IDepartamentStatusResultConverter,
           DepartamentStatusParam, DepartamentStatusResult, IDepartamentStatusDao,
           long, Model.DepartamentStatus>, IDepartamentStatusProcessor
    {
        protected override long GetTPK(DepartamentStatusParam param)
        {
            return param.Id;
        }

        public DepartamentStatusProcessor(
            IDepartamentStatusDao dao,
            IDepartamentStatusParamConverter paramConverter,
            IDepartamentStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
