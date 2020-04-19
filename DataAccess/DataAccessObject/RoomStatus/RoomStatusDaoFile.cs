namespace University_Management_System_API.DataAccess.DataAccessObject.RoomStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class RoomStatusDaoFile : BaseDaoFile<Model.RoomStatus, long, IRoomStatusStorage>, IRoomStatusDao
    {
        protected override long GetPK(Model.RoomStatus entity)
        {
            return entity.Id;
        }

        public RoomStatusDaoFile(IRoomStatusStorage storage)
          : base(storage)
        {
        }
    }
}
