namespace University_Management_System_API.Extensions.Departament
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.Departament;
    using University_Management_System_API.Business.Processor.Departament;
    using University_Management_System_API.DataAccess.DataAccessObject.Departament;
    using University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus;

    public static class RegisterDepartamentExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IDepartamentStorage, DepartamentStorage>();
            //services.AddTransient<IDepartamentDao, DepartamentDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IDepartamentDao, DepartamentDaoEF>();

            services.AddTransient<IDepartamentParamConverter, DepartamentParamConverter>();
            services.AddTransient<IDepartamentResultConverter, DepartamentResultConverter>();

            services.AddTransient<IDepartamentStatusDao, DepartamentStatusDaoEF>();

            services.AddTransient<IDepartamentProcessor, DepartamentProcessor>();
        }
    }
}
