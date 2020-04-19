namespace University_Management_System_API.Business.Convertor.TrainingType
{
    using University_Management_System_API.Business.Convertor.Common;
    using University_Management_System_API.DataAccess.DataAccessObject.Speciality;

    public class TrainingTypeParamConverter
         : BaseParamConverter<TrainingTypeParam, Model.TrainingType>, ITrainingTypeParamConverter
    {
        private ISpecialityDao _specialityDao;
        public ISpecialityDao SpecialityDao
        {
            get { return _specialityDao; }
            set { _specialityDao = value; }
        }

        public TrainingTypeParamConverter(ISpecialityDao specialityDao)
        {
            this.SpecialityDao = specialityDao;
        }

        public override Model.TrainingType GetEntity(TrainingTypeParam param)
        {
            return new Model.TrainingType();
        }

        public override void ConvertSpecific(TrainingTypeParam param, Model.TrainingType entity)
        { 
        }
    }
}
