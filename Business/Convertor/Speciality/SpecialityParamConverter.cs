namespace University_Management_System_API.Business.Convertor.Speciality
{
    using University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus;
    using University_Management_System_API.Business.Convertor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Faculty;
    using University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree;

    public class SpecialityParamConverter 
        : BaseParamConverter<SpecialityParam, Model.Speciality>, ISpecialityParamConverter
    {
        private ISpecialityStatusDao _statusDao;
        public ISpecialityStatusDao StatusDao
        {
            get { return _statusDao; }
            set { this._statusDao = value; }
        }


        private IFacultyDao _facultyDao;
        public IFacultyDao FacultyDao
        {
            get { return _facultyDao; }
            set { _facultyDao = value; }
        }


        private IEducationalDegreeDao _educationalDegreeDao;
        public IEducationalDegreeDao EducationalDegreeDao
        {
            get { return _educationalDegreeDao; }
            set { _educationalDegreeDao = value; }
        }

        public SpecialityParamConverter(
            ISpecialityStatusDao statusDao,
            IFacultyDao facultyDao,
            IEducationalDegreeDao educationalDegreeDao)
        {
            this.StatusDao = statusDao;
            this.FacultyDao = facultyDao;
            this.EducationalDegreeDao = educationalDegreeDao;
        }

        public override Model.Speciality GetEntity(SpecialityParam param)
        {
            return new Model.Speciality
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(SpecialityParam param, Model.Speciality entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);
            entity.Faculty = FacultyDao.Find(param.FacultyId);
            entity.EducationalDegree = EducationalDegreeDao.Find(param.EducationalDegreeId);
        }
    }
}
