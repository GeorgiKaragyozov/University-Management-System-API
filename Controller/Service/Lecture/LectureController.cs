namespace University_Management_System_API.Controller.Service.Lecture
{
    using University_Management_System_API.Business.Convertor.Lecture;
    using University_Management_System_API.Business.Processor.Lecture;
    using University_Management_System_API.Controller.Service.Common;

    public class LectureController 
        : BaseController<LectureParam, LectureResult, long, ILectureProcessor>
    {
        public LectureController(ILectureProcessor processor)
            : base(processor)
        {
        }
    }
}
