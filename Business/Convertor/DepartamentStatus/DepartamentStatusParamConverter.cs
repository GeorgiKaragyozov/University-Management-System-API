namespace University_Management_System_API.Business.Convertor.DepartamentStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class DepartamentStatusParamConverter 
        : BaseParamConverter<DepartamentStatusParam, Model.DepartamentStatus>, IDepartamentStatusParamConverter
    {
        public override Model.DepartamentStatus GetEntity(DepartamentStatusParam param)
        {
            return new Model.DepartamentStatus();
        }

        public override void ConvertSpecific(DepartamentStatusParam param, Model.DepartamentStatus entity)
        { 
        }
    }
}
