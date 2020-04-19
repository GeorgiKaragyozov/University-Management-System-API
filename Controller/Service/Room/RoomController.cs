namespace University_Management_System_API.Controller.Service.Room
{
    using University_Management_System_API.Business.Convertor.Room;
    using University_Management_System_API.Business.Processor.Room;
    using University_Management_System_API.Controller.Service.Common;

    public class RoomController : BaseController<RoomParam, RoomResult, long, IRoomProcessor>
    {
        public RoomController(IRoomProcessor processor)
              : base(processor)
        {
        }
    }
}
