namespace University_Management_System_API.Business.Convertor.FacultyStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class FacultyStatusResultConverter 
        : BaseResultConverter<Model.FacultyStatus, FacultyStatusResult>, IFacultyStatusResultConverter
    {
        public override void ConvertSpecific(Model.FacultyStatus entity, FacultyStatusResult result)
        {
        }

        public override FacultyStatusResult GetResult()
        {
            return new FacultyStatusResult();
        }
    }
}
