namespace University_Management_System_API.Business.Convertor.Room
{
    using University_Management_System_API.Business.Convertor.Common;

    public class RoomResultConverter : BaseResultConverter<Model.Room, RoomResult>, IRoomResultConverter
    {
        public override void ConvertSpecific(Model.Room entity, RoomResult result)
        {
            result.StatusId = entity.Status.Id;
            result.StatusName = entity.Status.Name;
        }

        public override RoomResult GetResult()
        {
            return new RoomResult();
        }
    }
}
