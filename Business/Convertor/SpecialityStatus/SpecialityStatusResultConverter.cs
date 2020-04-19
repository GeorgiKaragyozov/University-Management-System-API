namespace University_Management_System_API.Business.Convertor.SpecialityStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class SpecialityStatusResultConverter 
        : BaseResultConverter<Model.SpecialityStatus, SpecialityStatusResult>, ISpecialityStatusResultConverter
    {
        public override void ConvertSpecific(Model.SpecialityStatus entity, SpecialityStatusResult result)
        { 
        }

        public override SpecialityStatusResult GetResult()
        {
            return new SpecialityStatusResult();
        }
    }
}
