namespace University_Management_System_API.Business.Processor.LectureStatus
{
    using University_Management_System_API.Business.Convertor.LectureStatus;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.LectureStatus;

    public class LectureStatusProcessor
         : BaseProcessor<ILectureStatusParamConverter, ILectureStatusResultConverter,
           LectureStatusParam, LectureStatusResult, ILectureStatusDao,
           long, Model.LectureStatus>, ILectureStatusProcessor
    {
        protected override long GetTPK(LectureStatusParam param)
        {
            return param.Id;
        }

        public LectureStatusProcessor(
            ILectureStatusDao dao,
            ILectureStatusParamConverter paramConverter,
            ILectureStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
