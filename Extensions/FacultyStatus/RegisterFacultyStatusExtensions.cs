namespace University_Management_System_API.Extensions.FacultyStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.FacultyStatus;
    using University_Management_System_API.Business.Processor.FacultyStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.FacultyStatus;

    public static class RegisterFacultyStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IFacultyStatusStorage, FacultyStatusStorage>();
            //services.AddTransient<IFacultyStatusDao, FacultyStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IFacultyStatusDao, FacultyStatusDaoEF>();

            services.AddTransient<IFacultyStatusParamConverter, FacultyStatusParamConverter>();
            services.AddTransient<IFacultyStatusResultConverter, FacultyStatusResultConverter>();

            services.AddTransient<IFacultyStatusProcessor, FacultyStatusProcessor>();
        }
    }
}
