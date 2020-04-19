namespace University_Management_System_API.Business.Convertor.ApiSession
{
    using University_Management_System_API.Business.Convertor.Common;

    public class ApiSessionResultConverter
         : BaseResultConverter<Model.ApiSession, ApiSessionResult>, IApiSessionResultConverter
    {
        public override void ConvertSpecific(Model.ApiSession entity, ApiSessionResult result)
        {
        }

        public override ApiSessionResult GetResult()
        {
            return new ApiSessionResult();
        }
    }
}
