namespace University_Management_System_API.Business.Convertor.Departament
{
    using University_Management_System_API.Business.Convertor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus;

    public class DepartamentParamConverter 
        : BaseParamConverter<DepartamentParam, Model.Departament>, IDepartamentParamConverter
    {
        private IDepartamentStatusDao _statusDao;
        public IDepartamentStatusDao StatusDao
        {
            get { return _statusDao; }
            set { _statusDao = value; }
        }

        public DepartamentParamConverter(IDepartamentStatusDao statusDao)
        {
            this.StatusDao = statusDao;
        }

        public override void ConvertSpecific(DepartamentParam param, Model.Departament entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);
        }

        public override Model.Departament GetEntity(DepartamentParam param)
        {
            return new Model.Departament
            {
                Id = param.Id,
                Code = param.Code
            };
        }
    }
}
