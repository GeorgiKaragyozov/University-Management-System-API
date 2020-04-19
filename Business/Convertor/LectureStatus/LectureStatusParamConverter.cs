namespace University_Management_System_API.Business.Convertor.LectureStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class LectureStatusParamConverter 
        : BaseParamConverter<LectureStatusParam, Model.LectureStatus>, ILectureStatusParamConverter
    {
        public override Model.LectureStatus GetEntity(LectureStatusParam param)
        {
            return new Model.LectureStatus();
        }

        public override void ConvertSpecific(LectureStatusParam param, Model.LectureStatus entity)
        { 
        }
    }
}
