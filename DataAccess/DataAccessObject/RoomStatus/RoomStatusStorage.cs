namespace University_Management_System_API.DataAccess.DataAccessObject.RoomStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class RoomStatusStorage : BaseStorage<Model.RoomStatus, long>, IRoomStatusStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\RoomStatus\RoomStatusJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.RoomStatus entity)
        {
            return entity.Id;
        }
    }
}
