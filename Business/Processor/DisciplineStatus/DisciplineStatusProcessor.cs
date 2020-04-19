namespace University_Management_System_API.Business.Processor.DisciplineStatus
{
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.Business.Convertor.DisciplineStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus;

    public class DisciplineStatusProcessor
        : BaseProcessor<IDisciplineStatusParamConverter, IDisciplineStatusResultConverter,
           DisciplineStatusParam, DisciplineStatusResult, IDisciplineStatusDao,
           long, Model.DisciplineStatus>, IDisciplineStatusProcessor
    {
        protected override long GetTPK(DisciplineStatusParam param)
        {
            return param.Id;
        }

        public DisciplineStatusProcessor(
            IDisciplineStatusDao dao,
            IDisciplineStatusParamConverter paramConverter,
            IDisciplineStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
