namespace University_Management_System_API.Business.Convertor.Lecture
{
    using University_Management_System_API.Business.Convertor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Room;
    using University_Management_System_API.DataAccess.DataAccessObject.TeacherDiscipline;
    using University_Management_System_API.DataAccess.DataAccessObject.LectureStatus;

    public class LectureParamConverter : BaseParamConverter<LectureParam, Model.Lecture>, ILectureParamConverter
    {
        private ITeacherDisciplineDao _teacherDisciplineDao;
        public ITeacherDisciplineDao TeacherDisciplineDao
        {
            get { return _teacherDisciplineDao; }
            set { _teacherDisciplineDao = value; }
        }


        private IRoomDao _roomDao;
        public IRoomDao RoomDao
        {
            get { return _roomDao; }
            set { _roomDao = value; }
        }


        private ILectureStatusDao _statusDao;
        public ILectureStatusDao StatusDao
        {
            get { return _statusDao; }
            set { _statusDao = value; }
        }     

        public LectureParamConverter(
            ITeacherDisciplineDao teacherDisciplineDao,
            IRoomDao roomDao,
            ILectureStatusDao statusDao)
        {
            this.TeacherDisciplineDao = teacherDisciplineDao;
            this.RoomDao = roomDao;
            this.StatusDao = statusDao;
        }

        public override Model.Lecture GetEntity(LectureParam param)
        {
            return new Model.Lecture
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(LectureParam param, Model.Lecture entity)
        {
            entity.TeacherDiscipline = TeacherDisciplineDao.Find(param.TeacherDisciplineId);
            entity.Room = RoomDao.Find(param.RoomId);
            entity.Status = StatusDao.Find(param.StatusId);
        }
    }
}
