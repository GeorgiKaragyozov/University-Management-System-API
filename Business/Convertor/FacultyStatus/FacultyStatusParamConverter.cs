namespace University_Management_System_API.Business.Convertor.FacultyStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class FacultyStatusParamConverter 
        : BaseParamConverter<FacultyStatusParam, Model.FacultyStatus>, IFacultyStatusParamConverter
    {
        public override Model.FacultyStatus GetEntity(FacultyStatusParam param)
        {
            return new Model.FacultyStatus();
        }

        public override void ConvertSpecific(FacultyStatusParam param, Model.FacultyStatus entity)
        {
        }
    }
}
