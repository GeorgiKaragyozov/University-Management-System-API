namespace University_Management_System_API.Business.Convertor.RoomStatus
{
    using University_Management_System_API.Business.Convertor.Common;

    public class RoomStatusParamConverter : BaseParamConverter<RoomStatusParam, Model.RoomStatus>, IRoomStatusParamConverter
    {
        public override Model.RoomStatus GetEntity(RoomStatusParam param)
        {
            return new Model.RoomStatus();
        }

        public override void ConvertSpecific(RoomStatusParam param, Model.RoomStatus entity)
        { 
        }
    }
}
