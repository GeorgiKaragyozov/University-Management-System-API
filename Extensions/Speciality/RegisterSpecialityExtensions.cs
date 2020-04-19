namespace University_Management_System_API.Extensions.Speciality
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.Speciality;
    using University_Management_System_API.Business.Processor.Speciality;
    using University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree;
    using University_Management_System_API.DataAccess.DataAccessObject.Faculty;
    using University_Management_System_API.DataAccess.DataAccessObject.Speciality;
    using University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus;

    public static class RegisterSpecialityExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<ISpecialityStorage, SpecialityStorage>();
            //services.AddTransient<ISpecialityDao, SpecialityDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<ISpecialityDao, SpecialityDaoEF>();

            services.AddTransient<ISpecialityParamConverter, SpecialityParamConverter>();
            services.AddTransient<ISpecialityResultConverter, SpecialityResultConverter>();

            services.AddTransient<ISpecialityStatusDao, SpecialityStatusDaoEF>();
            services.AddTransient<IFacultyDao, FacultyDaoEF>();
            services.AddTransient<IEducationalDegreeDao, EducationalDegreeDaoEF>();

            services.AddTransient<ISpecialityProcessor, SpecialityProcessor>();
        }
    }
}
