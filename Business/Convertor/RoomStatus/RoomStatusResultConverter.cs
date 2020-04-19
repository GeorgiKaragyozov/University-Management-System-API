namespace University_Management_System_API.Business.Convertor.RoomStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class RoomStatusResultConverter 
        : BaseResultConverter<Model.RoomStatus, RoomStatusResult>, IRoomStatusResultConverter
    {
        public override void ConvertSpecific(Model.RoomStatus entity, RoomStatusResult result) 
        {
        }

        public override RoomStatusResult GetResult()
        {
            return new RoomStatusResult();
        }
    }
}
