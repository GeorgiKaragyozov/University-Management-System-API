namespace University_Management_System_API.Extensions.SpecialityTrainingType
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.SpecialityTrainingType;
    using University_Management_System_API.Business.Processor.SpecialityTrainingType;
    using University_Management_System_API.DataAccess.DataAccessObject.Speciality;
    using University_Management_System_API.DataAccess.DataAccessObject.SpecialityTrainingType;
    using University_Management_System_API.DataAccess.DataAccessObject.TrainingType;

    public static class RegisterSpecialityTrainingTypeExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ISpecialityTrainingTypeStorage, SpecialityTrainingTypeStorage>();
            //services.AddTransient<ISpecialityTrainingTypeDao, SpecialityTrainingTypeDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ISpecialityTrainingTypeDao, SpecialityTrainingTypeDaoEF>();

            services.AddTransient<ISpecialityTrainingTypeParamConverter, SpecialityTrainingTypeParamConverter>();
            services.AddTransient<ISpecialityTrainingTypeResultConverter, SpecialityTrainingTypeResultConverter>();

            services.AddTransient<ISpecialityDao, SpecialityDaoEF>();
            services.AddTransient<ITrainingTypeDao, TrainingTypeDaoEF>();

            services.AddTransient<ISpecialityTrainingTypeProcessor, SpecialityTrainingTypeProcessor>();
        }
    }
}
