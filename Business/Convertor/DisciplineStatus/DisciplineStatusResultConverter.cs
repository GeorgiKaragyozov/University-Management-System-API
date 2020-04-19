namespace University_Management_System_API.Business.Convertor.DisciplineStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class DisciplineStatusResultConverter 
        : BaseResultConverter<Model.DisciplineStatus, DisciplineStatusResult>, IDisciplineStatusResultConverter
    {

        public override void ConvertSpecific(Model.DisciplineStatus entity, DisciplineStatusResult result)
        { 
        }

        public override DisciplineStatusResult GetResult()
        {
            return new DisciplineStatusResult();
        }
    }
}
