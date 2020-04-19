namespace University_Management_System_API.Business.Processor.Room
{
    using University_Management_System_API.Business.Convertor.Room;
    using University_Management_System_API.Business.Processor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Room;

    public class RoomProcessor
        : BaseProcessor<IRoomParamConverter, IRoomResultConverter, RoomParam, RoomResult, IRoomDao,
            long, Model.Room>, IRoomProcessor
    {
        protected override long GetTPK(RoomParam param)
        {
            return param.Id;
        }

        public RoomProcessor(
            IRoomDao dao,
            IRoomParamConverter paramConverter,
            IRoomResultConverter resultConverter)

            : base(dao, paramConverter, resultConverter)
        {
        }
    }
}
