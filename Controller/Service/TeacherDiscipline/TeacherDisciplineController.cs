namespace University_Management_System_API.Controller.Service.TeacherDiscipline
{
    using University_Management_System_API.Business.Convertor.TeacherDiscipline;
    using University_Management_System_API.Business.Processor.TeacherDiscipline;
    using University_Management_System_API.Controller.Service.Common;

    public class TeacherDisciplineController
        : BaseController<TeacherDisciplineParam, TeacherDisciplineResult, long, ITeacherDisciplineProcessor>
    {
        public TeacherDisciplineController(ITeacherDisciplineProcessor processor)
            : base(processor)
        {
        }
    }
}
