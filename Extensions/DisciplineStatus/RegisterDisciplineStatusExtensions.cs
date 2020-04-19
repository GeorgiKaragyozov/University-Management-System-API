namespace University_Management_System_API.Extensions.DisciplineStatus
{
    using Microsoft.Extensions.DependencyInjection;
    using University_Management_System_API.Business.Convertor.DisciplineStatus;
    using University_Management_System_API.Business.Processor.DisciplineStatus;
    using University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus;

    public static class RegisterDisciplineStatusExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            //------------------- File Json -------------------//
            //services.AddTransient<IDisciplineStatusStorage, DisciplineStatusStorage>();
            //services.AddTransient<IDisciplineStatusDao, DisciplineStatusDaoFile>();

            //------------------- Entity Framework -------------------//
            services.AddTransient<IDisciplineStatusDao, DisciplineStatusDaoEF>();

            services.AddTransient<IDisciplineStatusParamConverter, DisciplineStatusParamConverter>();
            services.AddTransient<IDisciplineStatusResultConverter, DisciplineStatusResultConverter>();

            services.AddTransient<IDisciplineStatusProcessor, DisciplineStatusProcessor>();
        }
    }
}
