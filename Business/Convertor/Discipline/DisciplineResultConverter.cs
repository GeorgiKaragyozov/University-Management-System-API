namespace University_Management_System_API.Business.Convertor.Discipline
{
    using University_Management_System_API.Business.Convertor.Common;

    public class DisciplineResultConverter 
        : BaseResultConverter<Model.Discipline, DisciplineResult>, IDisciplineResultConverter
    {
        public override void ConvertSpecific(Model.Discipline entity, DisciplineResult result)
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override DisciplineResult GetResult()
        {
            return new DisciplineResult();
        }
    }
}
