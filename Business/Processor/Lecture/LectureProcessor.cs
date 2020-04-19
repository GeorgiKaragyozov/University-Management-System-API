namespace University_Management_System_API.Business.Processor.Lecture
{
    using University_Management_System_API.Business.Convertor.Lecture;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Lecture;

    public class LectureProcessor
          : BaseProcessor<ILectureParamConverter, ILectureResultConverter, LectureParam, LectureResult,
              ILectureDao, long, Model.Lecture>, ILectureProcessor
    {
        protected override long GetTPK(LectureParam param)
        {
            return param.Id;
        }

        public LectureProcessor(
            ILectureDao dao,
            ILectureParamConverter paramConverter,
            ILectureResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
