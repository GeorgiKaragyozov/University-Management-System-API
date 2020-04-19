namespace University_Management_System_API.Business.Convertor.Speciality
{
    public class SpecialityResult : BaseResultNamed
    {
        public long StatusId { get; set; }
        public string StatusName { get; set; }

        public long FacultyId { get; set; }
        public string FacultyName { get; set; }

        public long EducationalDegreeId { get; set; }
        public string EducationalDegreeName { get; set; }
    }
}
