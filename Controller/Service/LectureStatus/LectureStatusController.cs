namespace University_Management_System_API.Controller.Service.LectureStatus
{
    using University_Management_System_API.Business.Convertor.LectureStatus;
    using University_Management_System_API.Business.Processor.LectureStatus;
    using University_Management_System_API.Controller.Service.Common;

    public class LectureStatusController
        : BaseController<LectureStatusParam, LectureStatusResult, long, ILectureStatusProcessor>
    {
        public LectureStatusController(ILectureStatusProcessor processor)
            : base(processor)
        {
        }
    }
}
