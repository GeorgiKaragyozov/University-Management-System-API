namespace University_Management_System_API.Business.Processor.Departament
{
    using University_Management_System_API.Business.Convertor.Departament;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Departament;

    public class DepartamentProcessor
        : BaseProcessor<IDepartamentParamConverter, IDepartamentResultConverter, DepartamentParam,
            DepartamentResult, IDepartamentDao, long, Model.Departament>, IDepartamentProcessor
    {
        protected override long GetTPK(DepartamentParam param)
        {
            return param.Id;
        }

        public DepartamentProcessor(
            IDepartamentDao dao,
            IDepartamentParamConverter paramConverter,
            IDepartamentResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
