namespace University_Management_System_API.Business.Convertor.DepartamentStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class DepartamentStatusResultConverter 
        : BaseResultConverter<Model.DepartamentStatus, DepartamentStatusResult>, IDepartamentStatusResultConverter
    {
        public override void ConvertSpecific(Model.DepartamentStatus entity, DepartamentStatusResult result) 
        { 
        }

        public override DepartamentStatusResult GetResult()
        {
            return new DepartamentStatusResult();
        }
    }
}
