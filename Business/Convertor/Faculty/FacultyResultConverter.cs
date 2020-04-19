namespace University_Management_System_API.Business.Convertor.Faculty
{
    using University_Management_System_API.Business.Convertor.Common;

    public class FacultyResultConverter : BaseResultConverter<Model.Faculty, FacultyResult>, IFacultyResultConverter
    {
        public override void ConvertSpecific(Model.Faculty entity, FacultyResult result)
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override FacultyResult GetResult()
        {
            return new FacultyResult();
        }
    }
}
