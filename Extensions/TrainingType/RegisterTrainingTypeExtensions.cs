namespace University_Management_System_API.Extensions.TrainingType
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.TrainingType;
    using University_Management_System_API.Business.Processor.TrainingType;
    using University_Management_System_API.DataAccess.DataAccessObject.TrainingType;

    public static class RegisterTrainingTypeExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ITrainingTypeStorage, TrainingTypeStorage>();
            //services.AddTransient<ITrainingTypeDao, TrainingTypeDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ITrainingTypeDao, TrainingTypeDaoEF>();

            services.AddTransient<ITrainingTypeParamConverter, TrainingTypeParamConverter>();
            services.AddTransient<ITrainingTypeResultConverter, TrainingTypeResultConverter>();

            services.AddTransient<ITrainingTypeProcessor, TrainingTypeProcessor>();
        }
    }
}
