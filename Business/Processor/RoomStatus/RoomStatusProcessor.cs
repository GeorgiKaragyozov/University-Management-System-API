namespace University_Management_System_API.Business.Processor.RoomStatus
{
    using University_Management_System_API.Business.Convertor.RoomStatus;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.RoomStatus;

    public class RoomStatusProcessor
         : BaseProcessor<IRoomStatusParamConverter, IRoomStatusResultConverter, RoomStatusParam, RoomStatusResult,
             IRoomStatusDao, long, Model.RoomStatus>, IRoomStatusProcessor
    {
        protected override long GetTPK(RoomStatusParam param)
        {
            return param.Id;
        }

        public RoomStatusProcessor(
            IRoomStatusDao dao,
            IRoomStatusParamConverter paramConverter,
            IRoomStatusResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
