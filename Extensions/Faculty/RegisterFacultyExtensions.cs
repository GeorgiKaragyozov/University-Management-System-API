namespace University_Management_System_API.Extensions.Faculty
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.Faculty;
    using University_Management_System_API.Business.Processor.Faculty;
    using University_Management_System_API.DataAccess.DataAccessObject.Faculty;
    using University_Management_System_API.DataAccess.DataAccessObject.FacultyStatus;

    public static class RegisterFacultyExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IFacultyStorage, FacultyStorage>();
            //services.AddTransient<IFacultyDao, FacultyDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IFacultyDao, FacultyDaoEF>();

            services.AddTransient<IFacultyParamConverter, FacultyParamConverter>();
            services.AddTransient<IFacultyResultConverter, FacultyResultConverter>();

            services.AddTransient<IFacultyStatusDao, FacultyStatusDaoEF>();

            services.AddTransient<IFacultyProcessor, FacultyProcessor>();
        }
    }
}
