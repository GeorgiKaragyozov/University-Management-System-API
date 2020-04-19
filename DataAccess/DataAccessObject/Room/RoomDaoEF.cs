namespace University_Management_System_API.DataAccess.DataAccessObject.Room
{
    using University_Management_System_API.DataAccess.DataAccessObject.Common;

    public class RoomDaoEF : BaseDaoEF<Model.Room, long>, IRoomDao
    {
        public RoomDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {
        }
    }
}
