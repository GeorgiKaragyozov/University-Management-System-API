namespace University_Management_System_API.Business.Processor.TeacherDisciplineStatus
{
    using University_Management_System_API.Business.Convertor.TeacherDisciplineStatus;
    using University_Management_System_API.Business.Processor.Common;

    public interface ITeacherDisciplineStatusProcessor
        : IBaseProcessor<TeacherDisciplineStatusParam, TeacherDisciplineStatusResult, long>
    {
    }
}
