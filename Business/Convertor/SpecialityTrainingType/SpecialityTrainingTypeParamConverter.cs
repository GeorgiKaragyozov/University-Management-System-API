namespace University_Management_System_API.Business.Convertor.SpecialityTrainingType
{
    using University_Management_System_API.Business.Convertor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Speciality;
    using University_Management_System_API.DataAccess.DataAccessObject.TrainingType;

    public class SpecialityTrainingTypeParamConverter
          : BaseParamConverter<SpecialityTrainingTypeParam, Model.SpecialityTrainingType>, 
        ISpecialityTrainingTypeParamConverter
    {
        private ISpecialityDao _specialityDao;
        public ISpecialityDao SpecialityDao
        {
            get { return _specialityDao; }
            set { _specialityDao = value; }
        }


        private ITrainingTypeDao _trainingTypeDao;
        public ITrainingTypeDao TrainingTypeDao
        {
            get { return _trainingTypeDao; }
            set { _trainingTypeDao = value; }
        }

        public override Model.SpecialityTrainingType GetEntity(SpecialityTrainingTypeParam param)
        {
            return new Model.SpecialityTrainingType
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(SpecialityTrainingTypeParam param, Model.SpecialityTrainingType entity)
        {
            entity.Speciality = SpecialityDao.Find(param.SpecialityId);
            entity.TrainingType = TrainingTypeDao.Find(param.TrainingTypeId);
        }
    }
}
