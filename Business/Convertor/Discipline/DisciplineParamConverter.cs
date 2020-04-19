namespace University_Management_System_API.Business.Convertor.Discipline
{
    using University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus;
    using University_Management_System_API.Business.Convertor.Common;

    public class DisciplineParamConverter
        : BaseParamConverter<DisciplineParam, Model.Discipline>, IDisciplineParamConverter
    {
        private IDisciplineStatusDao _statusDao;
        public IDisciplineStatusDao StatusDao
        {
            get { return _statusDao; }
            set { _statusDao = value; }
        }

        public DisciplineParamConverter(IDisciplineStatusDao statusDao)
        {
            this.StatusDao = statusDao;
        }

        public override Model.Discipline GetEntity(DisciplineParam param)
        {
            return new Model.Discipline
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(DisciplineParam param, Model.Discipline entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);
        }
    }
}
