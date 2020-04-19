namespace University_Management_System_API.Business.Convertor.Speciality
{
    using University_Management_System_API.Business.Convertor.Common;

    public class SpecialityResultConverter 
        : BaseResultConverter<Model.Speciality, SpecialityResult>, ISpecialityResultConverter
    {
        public override void ConvertSpecific(Model.Speciality entity, SpecialityResult result)
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
            result.FacultyId = entity.Faculty.Id;
            result.FacultyName = entity.Faculty.Name;
            result.EducationalDegreeId = entity.EducationalDegree.Id;
            result.EducationalDegreeName = entity.EducationalDegree.Name;
        }

        public override SpecialityResult GetResult()
        {
            return new SpecialityResult();
        }
    }
}
