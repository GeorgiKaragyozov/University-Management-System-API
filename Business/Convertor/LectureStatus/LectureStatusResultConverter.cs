namespace University_Management_System_API.Business.Convertor.LectureStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class LectureStatusResultConverter 
        : BaseResultConverter<Model.LectureStatus, LectureStatusResult>, ILectureStatusResultConverter
    {
        public override void ConvertSpecific(Model.LectureStatus entity, LectureStatusResult result) 
        {
        }

        public override LectureStatusResult GetResult()
        {
            return new LectureStatusResult();
        }
    }
}
