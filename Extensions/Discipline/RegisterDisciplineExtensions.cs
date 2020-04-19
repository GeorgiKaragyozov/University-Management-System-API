namespace University_Management_System_API.Extensions.Discipline
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.Discipline;
    using University_Management_System_API.Business.Processor.Discipline;
    using University_Management_System_API.DataAccess.DataAccessObject.Discipline;
    using University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus;

    public static class RegisterDisciplineExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IDisciplineStorage, DisciplineStorage>();
            //services.AddTransient<IDisciplineDao, DisciplineDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IDisciplineDao, DisciplineDaoEF>();

            services.AddTransient<IDisciplineParamConverter, DisciplineParamConverter>();
            services.AddTransient<IDisciplineResultConverter, DisciplineResultConverter>();

            services.AddTransient<IDisciplineStatusDao, DisciplineStatusDaoEF>();

            services.AddTransient<IDisciplineProcessor, DisciplineProcessor>();
        }
    }
}
