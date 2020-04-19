namespace University_Management_System_API.Business.Processor.Discipline
{
    using University_Management_System_API.Business.Convertor.Discipline;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Discipline;

    public class DisciplineProcessor
         : BaseProcessor<IDisciplineParamConverter, IDisciplineResultConverter, DisciplineParam,
             DisciplineResult, IDisciplineDao, long, Model.Discipline>, IDisciplineProcessor
    {
        protected override long GetTPK(DisciplineParam param)
        {
            return param.Id;
        }

        public DisciplineProcessor(
            IDisciplineDao dao,
            IDisciplineParamConverter paramConverter,
            IDisciplineResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
