namespace University_Management_System_API.DataAccess.DataAccessObject.RoomStatus
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class RoomStatusDaoEF : BaseDaoEF<Model.RoomStatus, long>, IRoomStatusDao
    {
        public RoomStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {
        }
    }
}
