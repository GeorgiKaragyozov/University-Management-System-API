namespace University_Management_System_API.DataAccess.DataAccessObject.Room
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class RoomDaoFile : BaseDaoFile<Model.Room, long, IRoomStorage>, IRoomDao
    {
        protected override long GetPK(Model.Room entity)
        {
            return entity.Id;
        }

        public RoomDaoFile(IRoomStorage storage)
          : base(storage)
        {
        }
    }
}
