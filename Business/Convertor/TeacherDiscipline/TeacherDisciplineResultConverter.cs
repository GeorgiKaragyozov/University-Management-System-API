namespace University_Management_System_API.Business.Convertor.TeacherDiscipline
{
    using University_Management_System_API.Business.Convertor.Common;

    public class TeacherDisciplineResultConverter 
        : BaseResultConverter<Model.TeacherDiscipline, TeacherDisciplineResult>, ITeacherDisciplineResultConverter
    {
        public override void ConvertSpecific(Model.TeacherDiscipline entity, TeacherDisciplineResult result)
        {
            result.TeacherId = entity.Account.Id;
            result.TeacherName = entity.Account.Name;
            result.DisciplineId = entity.Discipline.Id;
            result.DisciplineName = entity.Discipline.Name;
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override TeacherDisciplineResult GetResult()
        {
            return new TeacherDisciplineResult();
        }
    }
}
