namespace University_Management_System_API.Extensions.SpecialityStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.SpecialityStatus;
    using University_Management_System_API.Business.Processor.SpecialityStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus;

    public static class RegisterSpecialityStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ISpecialityStatusStorage, SpecialityStatusStorage>();
            //services.AddTransient<ISpecialityStatusDao, SpecialityStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ISpecialityStatusDao, SpecialityStatusDaoEF>();

            services.AddTransient<ISpecialityStatusParamConverter, SpecialityStatusParamConverter>();
            services.AddTransient<ISpecialityStatusResultConverter, SpecialityStatusResultConverter>();

            services.AddTransient<ISpecialityStatusProcessor, SpecialityStatusProcessor>();
        }
    }
}
