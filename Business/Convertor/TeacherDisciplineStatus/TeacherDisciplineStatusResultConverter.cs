namespace University_Management_System_API.Business.Convertor.TeacherDisciplineStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class TeacherDisciplineStatusResultConverter 
        : BaseResultConverter<Model.TeacherDisciplineStatus, TeacherDisciplineStatusResult>,
            ITeacherDisciplineStatusResultConverter
    {
        public override void ConvertSpecific(Model.TeacherDisciplineStatus entity, TeacherDisciplineStatusResult result)
        { 
        }

        public override TeacherDisciplineStatusResult GetResult()
        {
            return new TeacherDisciplineStatusResult();
        }
    }
}
