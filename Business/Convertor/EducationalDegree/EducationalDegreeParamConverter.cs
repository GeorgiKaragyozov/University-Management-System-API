namespace University_Management_System_API.Business.Convertor.EducationalDegree
{
    using University_Management_System_API.Business.Convertor.Common;

    public class EducationalDegreeParamConverter
        : BaseParamConverter<EducationalDegreeParam, Model.EducationalDegree>, IEducationalDegreeParamConverter
    {
        public override Model.EducationalDegree GetEntity(EducationalDegreeParam param)
        {
            return new Model.EducationalDegree();
        }

        public override void ConvertSpecific(EducationalDegreeParam param, Model.EducationalDegree entity)
        { 
        }
    }
}
