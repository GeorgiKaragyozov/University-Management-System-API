namespace University_Management_System_API.Business.Processor.Faculty
{
    using University_Management_System_API.Business.Convertor.Faculty;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Faculty;

    public class FacultyProcessor
        : BaseProcessor<IFacultyParamConverter, IFacultyResultConverter, FacultyParam, FacultyResult, IFacultyDao,
           long, Model.Faculty>, IFacultyProcessor
    {
        protected override long GetTPK(FacultyParam param)
        {
            return param.Id;
        }

        public FacultyProcessor(
            IFacultyDao dao,
            IFacultyParamConverter paramConverter,
            IFacultyResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
