namespace University_Management_System_API.Business.Convertor.Departament
{
    using University_Management_System_API.Business.Convertor.Common;

    public class DepartamentResultConverter 
        : BaseResultConverter<Model.Departament, DepartamentResult>, IDepartamentResultConverter
    {
        public override void ConvertSpecific(Model.Departament entity, DepartamentResult result)
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override DepartamentResult GetResult()
        {
            return new DepartamentResult();
        }
    }
}
