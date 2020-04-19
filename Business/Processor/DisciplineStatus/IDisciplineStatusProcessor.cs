namespace University_Management_System_API.Business.Processor.DisciplineStatus
{
    using University_Management_System_API.Business.Convertor.DisciplineStatus;
    using University_Management_System_API.Business.Processor.Common;

    public interface IDisciplineStatusProcessor
        : IBaseProcessor<DisciplineStatusParam, DisciplineStatusResult, long>
    {
    }
}
