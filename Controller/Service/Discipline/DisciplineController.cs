namespace University_Management_System_API.Controller.Service.Discipline
{
    using University_Management_System_API.Business.Convertor.Discipline;
    using University_Management_System_API.Business.Processor.Discipline;
    using University_Management_System_API.Controller.Service.Common;

    public class DisciplineController 
        : BaseController<DisciplineParam, DisciplineResult, long, IDisciplineProcessor>
    {
        public DisciplineController(IDisciplineProcessor processor)
          : base(processor)
        {
        }
    }
}
