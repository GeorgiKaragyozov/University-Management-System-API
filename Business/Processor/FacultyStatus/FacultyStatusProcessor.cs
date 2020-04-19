namespace University_Management_System_API.Business.Processor.FacultyStatus
{
    using University_Management_System_API.Business.Convertor.FacultyStatus;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.FacultyStatus;

    public class FacultyStatusProcessor
         : BaseProcessor<IFacultyStatusParamConverter, IFacultyStatusResultConverter,
           FacultyStatusParam, FacultyStatusResult, IFacultyStatusDao,
           long, Model.FacultyStatus>, IFacultyStatusProcessor
    {
        protected override long GetTPK(FacultyStatusParam param)
        {
            return param.Id;
        }

        public FacultyStatusProcessor(
            IFacultyStatusDao dao,
            IFacultyStatusParamConverter paramConverter,
            IFacultyStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
