namespace University_Management_System_API.Business.Processor.TeacherDiscipline
{
    using University_Management_System_API.Business.Convertor.TeacherDiscipline;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.TeacherDiscipline;

    public class TeacherDisciplineProcessor
         : BaseProcessor<ITeacherDisciplineParamConverter, ITeacherDisciplineResultConverter,
            TeacherDisciplineParam, TeacherDisciplineResult, ITeacherDisciplineDao,
            long, Model.TeacherDiscipline>, ITeacherDisciplineProcessor
    {
        protected override long GetTPK(TeacherDisciplineParam param)
        {
            return param.Id;
        }

        public TeacherDisciplineProcessor(
            ITeacherDisciplineDao dao,
            ITeacherDisciplineParamConverter paramConverter,
            ITeacherDisciplineResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
