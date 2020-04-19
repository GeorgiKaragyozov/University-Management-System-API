namespace University_Management_System_API.Extensions.DepartamentStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.DepartamentStatus;
    using University_Management_System_API.Business.Processor.DepartamentStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus;

    public static class RegisterDepartamentStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IDepartamentStatusStorage, DepartamentStatusStorage>();
            //services.AddTransient<IDepartamentStatusDao, DepartamentStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IDepartamentStatusDao, DepartamentStatusDaoEF>();

            services.AddTransient<IDepartamentStatusParamConverter, DepartamentStatusParamConverter>();
            services.AddTransient<IDepartamentStatusResultConverter, DepartamentStatusResultConverter>();

            services.AddTransient<IDepartamentStatusProcessor, DepartamentStatusProcessor>();
        }
    }
}
