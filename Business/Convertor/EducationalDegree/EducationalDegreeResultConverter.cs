namespace University_Management_System_API.Business.Convertor.EducationalDegree
{
    using University_Management_System_API.Business.Convertor.Common;

    public class EducationalDegreeResultConverter   
         : BaseResultConverter<Model.EducationalDegree, EducationalDegreeResult>,
        IEducationalDegreeResultConverter
    {
        public override void ConvertSpecific(Model.EducationalDegree entity, EducationalDegreeResult result)
        { 
        }

        public override EducationalDegreeResult GetResult()
        {
            return new EducationalDegreeResult();
        }
    }
}
