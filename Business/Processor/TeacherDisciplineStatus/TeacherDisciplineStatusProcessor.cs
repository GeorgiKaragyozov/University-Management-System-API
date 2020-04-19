namespace University_Management_System_API.Business.Processor.TeacherDisciplineStatus
{
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.Business.Convertor.TeacherDisciplineStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus;

    public class TeacherDisciplineStatusProcessor
        : BaseProcessor<ITeacherDisciplineStatusParamConverter, ITeacherDisciplineStatusResultConverter,
            TeacherDisciplineStatusParam, TeacherDisciplineStatusResult, ITeacherDisciplineStatusDao,
            long, Model.TeacherDisciplineStatus>, ITeacherDisciplineStatusProcessor
    {
        protected override long GetTPK(TeacherDisciplineStatusParam param)
        {
            return param.Id;
        }

        public TeacherDisciplineStatusProcessor(
            ITeacherDisciplineStatusDao dao,
            ITeacherDisciplineStatusParamConverter paramConverter,
            ITeacherDisciplineStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
