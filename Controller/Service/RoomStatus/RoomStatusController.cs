namespace University_Management_System_API.Controller.Service.RoomStatus
{
    using University_Management_System_API.Business.Convertor.RoomStatus;
    using University_Management_System_API.Business.Processor.RoomStatus;
    using University_Management_System_API.Controller.Service.Common;

    public class RoomStatusController
        : BaseController<RoomStatusParam, RoomStatusResult, long, IRoomStatusProcessor>
    {
        public RoomStatusController(IRoomStatusProcessor processor)
              : base(processor)
        {
        }
    }
}
