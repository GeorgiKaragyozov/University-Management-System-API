namespace University_Management_System_API.Controller.Service.TeacherDisciplineStatus
{
    using University_Management_System_API.Business.Convertor.TeacherDisciplineStatus;
    using University_Management_System_API.Business.Processor.TeacherDisciplineStatus;
    using University_Management_System_API.Controller.Service.Common;

    public class TeacherDisciplineStatusController
         : BaseController<TeacherDisciplineStatusParam, TeacherDisciplineStatusResult, long,
             ITeacherDisciplineStatusProcessor>
    {
        public TeacherDisciplineStatusController(ITeacherDisciplineStatusProcessor processor)
            : base(processor)
        {
        }
    }
}
