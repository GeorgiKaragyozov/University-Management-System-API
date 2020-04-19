namespace University_Management_System_API.Business.Convertor.Room
{
    using University_Management_System_API.DataAccess.DataAccessObject.RoomStatus;
    using University_Management_System_API.Business.Convertor.Common;

    public class RoomParamConverter : BaseParamConverter<RoomParam, Model.Room>, IRoomParamConverter
    {
        private IRoomStatusDao _statusDao;
        public IRoomStatusDao StatusDao
        {
            get { return _statusDao; }
            set { _statusDao = value; }
        }

        public RoomParamConverter(
            IRoomStatusDao statusDao)
        {
            this.StatusDao = statusDao;
        }

        public override Model.Room GetEntity(RoomParam param)
        {
            return new Model.Room
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(RoomParam param, Model.Room entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);
        }
    }
}
