namespace University_Management_System_API.DataAccess.DataAccessObject.Room
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class RoomStorage : BaseStorage<Model.Room, long>, IRoomStorage
    {
        private readonly string _jsonFile = @"D:\Users\Georgi\Desktop\University-Management-System-Core\University-Management-System\DataBaseJson\Room\RoomJsonFile.json";

        public override string GetPath()
        {
            return _jsonFile;
        }

        public override long GetTPK(Model.Room entity)
        {
            return entity.Id;
        }
    }
}
