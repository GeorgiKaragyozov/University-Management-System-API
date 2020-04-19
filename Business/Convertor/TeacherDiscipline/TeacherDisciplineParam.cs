namespace University_Management_System_API.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineParam : BaseParamNamed
    {
        public long TeacherId { get; set; }
        public long DisciplineId { get; set; }
        public long StatusId { get; set; }
    }
}
